﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Wrox.ProCSharp.Async
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private SearchInfo searchInfo;
    private object lockList = new object();
    private CancellationTokenSource cts = new CancellationTokenSource();

    public MainWindow()
    {
      InitializeComponent();
      searchInfo = new SearchInfo();
      this.DataContext = searchInfo;

      BindingOperations.EnableCollectionSynchronization(searchInfo.List, lockList);
    }

    private IEnumerable<IImageRequest> GetSearchRequests()
    {
      return new List<IImageRequest>
      {
        new BingRequest { SearchTerm = searchInfo.SearchTerm },
        new FlickrRequest { SearchTerm = searchInfo.SearchTerm}
      };
    }


    private void OnSearchSync(object sender, RoutedEventArgs e)
    {
      foreach (var req in GetSearchRequests())
      {
        WebClient client = new WebClient();
        client.Credentials = req.Credentials;
        string resp = client.DownloadString(req.Url); // блокирует поток до получения результата
        IEnumerable<SearchItemResult> images = req.Parse(resp);
        foreach (var image in images)
        {
          searchInfo.List.Add(image);
        }

      }
    }

    private void OnSeachAsyncPattern(object sender, RoutedEventArgs e)
    {
      Func<string, ICredentials, string> downloadString = (address, cred) =>
        {
          var client = new WebClient();
          client.Credentials = cred;
          return client.DownloadString(address);
        };

      Action<SearchItemResult> addItem = item => searchInfo.List.Add(item);

      foreach (var req in GetSearchRequests())
      {
        // асинхронный шаблон использует методы BeginInvoke, EndInvoke и объект IAsyncResult
        // код продолжения выполняется в потоке из пула, и он не может взять и просто выполнить операцию с UI-элементом
        // поэтому приходится использовать диспетчер
        downloadString.BeginInvoke(req.Url, req.Credentials, ar =>
          {
            string resp = downloadString.EndInvoke(ar);
            var images = req.Parse(resp);
            foreach (var image in images) // это лямбда-выражение вызывается в фоновом потоке из пула
            {
              this.Dispatcher.Invoke(addItem, image); // используем диспетчер, иначе упадёт эксепшен
            }
          }, null);
      }
    }

    /// <summary>
    /// Асинхронный шаблон на событиях
    /// </summary>
    private void OnAsyncEventPattern(object sender, RoutedEventArgs e)
    {
      foreach (var req in GetSearchRequests())
      {
        var client = new WebClient();
        client.Credentials = req.Credentials;
        client.DownloadStringCompleted += (sender1, e1) =>
          {
            string resp = e1.Result;
            var images = req.Parse(resp);
            foreach (var image in images)
            {
              searchInfo.List.Add(image); // выполняется в правильном потоке сразу же! не надо мучиться с Диспетчером!
                  // вызывается с учётом контекста синхронизации
            }
          };
        client.DownloadStringAsync(new Uri(req.Url));
      }
    }

    private async void OnTaskBasedAsyncPattern(object sender, RoutedEventArgs e)
    {
      cts = new CancellationTokenSource();
      try
      {
        foreach (var req in GetSearchRequests())
        {
          var clientHandler = new HttpClientHandler
          {
             Credentials = req.Credentials
          };
          var client = new HttpClient(clientHandler);

          var response = await client.GetAsync(req.Url, cts.Token);
          string resp = await response.Content.ReadAsStringAsync();

          await Task.Run(() =>
          {
            var images = req.Parse(resp);
            foreach (var image in images)
            {
              cts.Token.ThrowIfCancellationRequested();
              searchInfo.List.Add(image);
            }
          }, cts.Token);
        }
      }
      catch (OperationCanceledException ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void OnTaskBasedAsyncPattern1(object sender, RoutedEventArgs e)
    {
      foreach (var req in GetSearchRequests())
      {
        var client = new WebClient();
        client.Credentials = req.Credentials;
        string resp = await client.DownloadStringTaskAsync(req.Url);

        var images = req.Parse(resp);
        foreach (var image in images)
        {
          searchInfo.List.Add(image);
        }
      }
    }

    private void OnCancel(object sender, RoutedEventArgs e)
    {
      if (cts != null)
        cts.Cancel();
      
    }

    private void OnClear(object sender, RoutedEventArgs e)
    {
      searchInfo.List.Clear();
    }






  }
}
