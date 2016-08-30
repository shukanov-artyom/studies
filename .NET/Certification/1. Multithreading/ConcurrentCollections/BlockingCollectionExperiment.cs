using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollections
{
    public class BlockingCollectionExperiment
    {
        private readonly BlockingCollection<string> coll
            = new BlockingCollection<string>(100);

        private readonly TaskCompletionSource<int> tcs = 
            new TaskCompletionSource<int>();

        private const int SupplierThreadsCount = 4;
        private const int ConsumerThreadsCount = 2;

        public Task TestBlockingCollection()
        {
            // Создаём потоки-потребители
            TaskFactory tf = new TaskFactory(CancellationToken.None,
                    TaskCreationOptions.DenyChildAttach,
                    TaskContinuationOptions.None,
                    TaskScheduler.Default);
            for (int i = 0; i < ConsumerThreadsCount; i++)
            {
                tf.StartNew(() =>
                {
                    while (!coll.IsCompleted)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"processed: {coll.Take()}.");
                    }
                });
            }

            // создаём потоки-поставщики
            for (int i = 0; i < SupplierThreadsCount; i++)
            {
                Task.Factory.StartNew(
                () =>
                {
                    while (true)
                    {
                        string command = Console.ReadLine();
                        if (String.IsNullOrEmpty(command))
                        {
                            coll.CompleteAdding();
                            tcs.SetResult(0);
                            break;
                        }
                        foreach (char c in command)
                        {
                            string cmd = $"{c}{c}{c}{c}{c}{c}";
                            coll.Add(cmd);
                        }
                        coll.Add(command);
                    }
                }
                , CancellationToken.None,
                TaskCreationOptions.LongRunning,
                TaskScheduler.Default);
            }

            // оборачиваем всё в таску, чотб ждать окончания банкета
            return tcs.Task;
        }
    }
}
