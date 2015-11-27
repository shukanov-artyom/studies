using System;
using System.Windows;
using System.Windows.Threading;

namespace asyncTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            this.DispatcherUnhandledException += (o, args) =>
            {
                DispatcherUnhandledExceptionEventArgs ea = args as DispatcherUnhandledExceptionEventArgs;
                if (ea != null)
                {
                    Console.WriteLine(ea.Exception.GetType());
                    ea.Handled = true;
                }
            };
        }
    }
}
