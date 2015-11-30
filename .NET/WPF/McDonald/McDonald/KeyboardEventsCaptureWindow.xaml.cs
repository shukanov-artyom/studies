using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace McDonald
{
    /// <summary>
    /// Interaction logic for KeyboardEventsCaptureWindow.xaml
    /// </summary>
    public partial class KeyboardEventsCaptureWindow : Window
    {
        private const string fmt = @"{0}
{1}";

        public KeyboardEventsCaptureWindow()
        {
            InitializeComponent();
        }

        private void Process(object sender, KeyEventArgs e)
        {
            StringBuilder bld = new StringBuilder();
            bld.AppendFormat("Event: {0}, Key: {1}", e.RoutedEvent, e.Key);
            textBlockMessage.Text = String.Format(fmt, textBlockMessage.Text, bld);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            StringBuilder bld = new StringBuilder();
            bld.AppendFormat("Event: {0}, Changes: {1}", e.RoutedEvent, e.Changes);
            textBlockMessage.Text = String.Format(fmt, textBlockMessage.Text, bld);
        }

        private void TextInputHandle(object sender, TextCompositionEventArgs e)
        {
            StringBuilder bld = new StringBuilder();
            bld.AppendFormat("Event: {0}, Control text: {1}", e.RoutedEvent, e.ControlText);
            textBlockMessage.Text = String.Format(fmt, textBlockMessage.Text, bld);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            textBlockMessage.Text = String.Empty;
        }
    }
}
