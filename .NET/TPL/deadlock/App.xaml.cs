using System;
using System.Windows;
using shared;

namespace deadlock
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DeadlockDemo demo = new DeadlockDemo();
            demo.Test();
            Console.WriteLine("This will not be reached!"); // Deadlock here as UI thread is locked by t.Wait(); call
        }
    }
}
