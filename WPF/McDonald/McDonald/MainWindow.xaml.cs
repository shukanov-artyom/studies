using System;
using System.Windows;
using System.Windows.Input;

namespace McDonald
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (ReferenceEquals(e.OriginalSource,button1))
            {
                new KeyboardEventsCaptureWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button2))
            {
                new MouseCaptureWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button3))
            {
                new SystemColorsWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button4))
            {
                new TextFormattingModeWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button5))
            {
                new TooltipPopupWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button6))
            {
                MessageBox.Show(String.Format("MainWindow: {0}", Application.Current.MainWindow));
            }
            else if (ReferenceEquals(e.OriginalSource, button7))
            {
                new BindingsWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button8))
            {
                new CommandsWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button9))
            {
                new SharedResourcesWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button10))
            {
                new StylesWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button11))
            {
                new BehaviorsWindow().ShowDialog();
            }
            else if (ReferenceEquals(e.OriginalSource, button12))
            {
                new ViewboxWindow().ShowDialog();
            }
        }
    }
}
