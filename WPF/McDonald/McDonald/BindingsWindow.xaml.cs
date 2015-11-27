using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace McDonald
{
    /// <summary>
    /// Interaction logic for BindingsWindow.xaml
    /// </summary>
    public partial class BindingsWindow : Window
    {
        public BindingsWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            textBoxLal.FontSize = 45;
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            var binding = new Binding();
            binding.ElementName = "sliderMy";
            binding.Path = new PropertyPath("Value");
            binding.Mode = BindingMode.TwoWay;
            textBoxLal.SetBinding(TextBox.FontSizeProperty, binding);
        }
    }
}
