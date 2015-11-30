using System;
using System.Windows;
using System.Windows.Input;

namespace McDonald
{
    /// <summary>
    /// Interaction logic for TooltipPopupWindow.xaml
    /// </summary>
    public partial class TooltipPopupWindow : Window
    {
        public TooltipPopupWindow()
        {
            InitializeComponent();
        }

        private void ButtonPopupTgt_OnMouseEnter(object sender, MouseEventArgs e)
        {
            popupViolet.IsOpen = true;
        }

        private void PopupButtonClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, "Popup button clicked!");
        }
    }
}
