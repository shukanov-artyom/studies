using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace Starter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentTask = 0;
        private int maxItem = 0;
        private CountersContainer currentContainer;

        private const string CategoryName = "Custom Performance Counters";
        private const string SpeedCounterName = "Items/s Speed counter";
        private const string SpeedBytesCounterName = "Bytes/s Speed counter";

        private readonly ObservableCollection<int> tasks = new ObservableCollection<int>(); 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeClicked(object sender, RoutedEventArgs e)
        {
            if (PerformanceCounterCategory.Exists(CategoryName))
            {
                PerformanceCounterCategory.Delete(CategoryName);
            }
            if (!PerformanceCounterCategory.Exists(CategoryName))
            {
                CounterCreationDataCollection creationDataCollection =
                    new CounterCreationDataCollection();

                CounterCreationData ctrCreationData = new CounterCreationData();
                ctrCreationData.CounterType = PerformanceCounterType.RateOfCountsPerSecond32;
                ctrCreationData.CounterName = SpeedCounterName;
                creationDataCollection.Add(ctrCreationData);

                CounterCreationData ctrCreationData2 = new CounterCreationData();
                ctrCreationData2.CounterType = PerformanceCounterType.RateOfCountsPerSecond64;
                ctrCreationData2.CounterName = SpeedBytesCounterName;
                creationDataCollection.Add(ctrCreationData2);

                PerformanceCounterCategory.Create(CategoryName,
                    "Sample Custom category",
                    PerformanceCounterCategoryType.MultiInstance,
                    creationDataCollection);
            }
            currentContainer = new CountersContainer()
            {
                BytesPerSecCounter = SetupCounter(CategoryName, SpeedCounterName, "Task " + currentTask),
                ItemsPerSecCounter = SetupCounter(CategoryName, SpeedBytesCounterName, "Task " + currentTask)
            };
        }

        private void AddThreadClicked(object sender, RoutedEventArgs e)
        {
            new Thread(DoProcessing) { IsBackground = true} .Start(currentContainer);
        }

        private void AddInstanceClicked(object sender, RoutedEventArgs e)
        {
            maxItem++;
            currentContainer = new CountersContainer()
            {
                BytesPerSecCounter = SetupCounter(CategoryName, SpeedCounterName, "Task " + currentTask),
                ItemsPerSecCounter = SetupCounter(CategoryName, SpeedBytesCounterName, "Task " + currentTask)
            };
            comboBoxInstance.Items.Add(maxItem);
        }

        private static PerformanceCounter SetupCounter(string categoryName, string counterName, string instanceName)
        {
            return new PerformanceCounter(categoryName, counterName, instanceName, false) { RawValue = 0 };
        }

        private static void DoProcessing(object arg)
        {
            CountersContainer ctr = arg as CountersContainer;
            Random r = new Random(DateTime.Now.Millisecond);
            ctr.ItemsPerSecCounter.NextSample();
            ctr.BytesPerSecCounter.NextSample();
            while (true)
            {
                Thread.Sleep(r.Next(20, 300));
                int messageSize = r.Next(512, 1024 * 500);
                ctr.ItemsPerSecCounter.Increment();
                ctr.BytesPerSecCounter.IncrementBy(messageSize);
            }
        }

        private void Selector_OnSelected(object sender, RoutedEventArgs e)
        {
            currentTask = (int)comboBoxInstance.SelectedValue;
        }
    }
}
