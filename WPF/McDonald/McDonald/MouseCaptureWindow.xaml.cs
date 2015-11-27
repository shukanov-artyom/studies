using System;
using System.Windows;
using System.Windows.Input;

namespace McDonald
{
    /// <summary>
    /// Interaction logic for MouseCaptureWindow.xaml
    /// </summary>
    public partial class MouseCaptureWindow : Window
    {
        public MouseCaptureWindow()
        {
            InitializeComponent();
        }

        private void ButtonMouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.Capture(buttonForMouse);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "Second clicked!");
        }

        private void ButtonForMouse_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(this, "Main mouse Down!");
        }

        private void ButtonForMouse_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "Main clicked!");
        }
    }
}
