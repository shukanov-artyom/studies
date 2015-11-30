using System;
using System.Windows;

namespace McDonald
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Вызывается перед появлением главного окна.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

        }

        /// <summary>
        /// Первое окно само установится как Application.MainWindow!
        /// </summary>
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length == 0)
            {
                new MainWindow().Show();
            }
            else
            {
                new ViewerWindow().Show();
            }
        }
    }
}
