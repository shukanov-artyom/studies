using System;
using System.Diagnostics;
using System.Threading;

namespace PerformanceCounters
{
    class Program
    {
        private const string CategoryName = "TransVault Performance Counters";
        private const string MsgSCounterName = "Some instances counter";
        private const string AverageCounterName = "Avg Counter";
        private const string SpeedCounterName = "Items/s Speed counter";
        private const string SpeedBytesCounterName = "Bytes/s Speed counter";

        private static Random r = new Random(DateTime.Now.Second);

        static void Main(string[] args)
        {
            //IncrementalCounter();
            //SpeedCounter();

            SpeedCounter2();
        }

        private static void SpeedCounter2()
        {
            SetupCategory();
            CountersContainer container = new CountersContainer()
                                          {
                                              BytesPerSecCounter = SetupBytesCounter(),
                                              ItemsPerSecCounter = SetupItemsCounter()
                                          };
            new Thread(DoProcessing).Start(container);
            new Thread(DoProcessing).Start(container);
            new Thread(DoProcessing).Start(container);
            new Thread(DoProcessing).Start(container);
            DoProcessing(container);
        }

        private static PerformanceCounter SetupBytesCounter()
        {
            return new PerformanceCounter(CategoryName, SpeedBytesCounterName, "Instance1", false) { RawValue = 0 };
        }

        private static PerformanceCounter SetupItemsCounter()
        {
            return new PerformanceCounter(CategoryName, SpeedCounterName, "Instance1", false) {RawValue = 0};
        }

        private static void SetupCategory()
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
                    "Sample TransVault category",
                    PerformanceCounterCategoryType.MultiInstance,
                    creationDataCollection);
            }
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
                int messageSize = r.Next(512, 1024*500);
                ctr.ItemsPerSecCounter.Increment();
                ctr.BytesPerSecCounter.IncrementBy(messageSize);
            }
        }
    }
}
