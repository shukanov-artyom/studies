using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace async_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Go(object sender, RoutedEventArgs e)
        {
            if (SynchronizationContext.Current != null)
            {
                SynchronizationContext.Current.ToString();
            }
            button.IsEnabled = false;
            int k = 1000000;
            for (int i = 1; i < 5; i++)
            {
                int r = await GetPrimesCountAsync(i*k, k);
                results.Text += String.Format("{0} primes between {1} and {2}{3}",
                    r,
                    i * k,
                    (i + 1) * k - 1,
                    Environment.NewLine);
            }
            button.IsEnabled = true;
        }

        private async void Go2(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;
            string[] urls = "www.albahari.com www.oreilly.com www.linqpad.net".Split();
            int totalLength = 0;
            try
            {
                foreach (string url in urls)
                {
                    Uri uri = new Uri("http://" + url);
                    byte[] data = await new WebClient().DownloadDataTaskAsync(uri);
                    results.Text += "Length of " + url + " is " + data.Length + Environment.NewLine;
                    totalLength += data.Length;
                }
                results.Text += "Total length: " + totalLength + Environment.NewLine;
            }
            catch (WebException ex)
            {
                results.Text = "Error: " + ex.Message;
            }
            finally
            {
                button.IsEnabled = true;
            }
            button.IsEnabled = true;
        }

        private Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() => 
                ParallelEnumerable.Range(start, count)
                    .Count(r => Enumerable.Range(2, (int)Math.Sqrt(r) - 1).All(p => r % p > 0)));
        }
    }
}
