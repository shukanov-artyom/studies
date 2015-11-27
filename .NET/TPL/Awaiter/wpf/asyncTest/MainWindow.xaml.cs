using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace asyncTest
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

        private void Go(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;
            int k = 1000000;
            for (int i = 1; i < 5; i++)
            {
                textBlock.Text += String.Format("{0} primes between {1} and {2}{3}",
                    GetPrimesCount(i*k, k),
                    i*k,
                    (i+1)*k-1,
                    Environment.NewLine);
            }
            button.IsEnabled = true;
        }

        private int GetPrimesCount(int start, int count)
        {
            return ParallelEnumerable.Range(start, count)
                    .Count(r => Enumerable.Range(2, (int) Math.Sqrt(r) - 1).All(p => r%p > 0));
        }

        private async void Throw_OnClick(object sender, RoutedEventArgs e)
        {
            await Task.Delay(3000);
            throw new Exception("Ignored?");
        }
    }
}
