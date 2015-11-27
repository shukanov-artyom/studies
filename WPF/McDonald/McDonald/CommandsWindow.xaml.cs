using System;
using System.Windows;
using System.Windows.Input;

namespace McDonald
{
    /// <summary>
    /// Interaction logic for CommandsWindow.xaml
    /// </summary>
    public partial class CommandsWindow : Window
    {
        public CommandsWindow()
        {
            InitializeComponent();
            CommandBinding b = new CommandBinding(ApplicationCommands.New);
            b.Executed += BOnExecuted;
            CommandBindings.Add(b);
        }

        private void BOnExecuted(object sender, ExecutedRoutedEventArgs executedRoutedEventArgs)
        {
            MessageBox.Show(executedRoutedEventArgs.OriginalSource.ToString());
        }
    }
}
