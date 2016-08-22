using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    static class Program
    {
        static void Main(string[] args)
        {
            CancellationWithThreadPool();
            CancellationWithTask();
        }

        private static void CancellationWithThreadPool()
        {
            var cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem((state =>
            {
                Thread.Sleep(300);
                Console.WriteLine(cts.IsCancellationRequested ? "Canceled!" : "Finished!");
            }));
            cts.CancelAfter(100); // нет возвращаемого значения
            // не могу узнать о завершении операции
            Console.Read();
        }

        // Простая конфигурация таски для возможности отмены.
        private static void CancellationWithTask()
        {
            var cts = new CancellationTokenSource();
            Task<int> task = new Task<int>(() => Sum(cts.Token, 100000), cts.Token);
            // передали токен в констурктор таска, чтоб отменить ещё до начала выполнения тела
            // если тело начало выполняться, то отмена на нас - мы явно должны написать код, отменяющий задачу (ThrowIfCancellationRequested)
            task.Start();
            cts.Cancel();
            try
            {
                int res = task.Result;
            }
            catch (AggregateException x)
            {
                x.Handle(e => e is OperationCanceledException);
            }
        }

        private static int Sum(CancellationToken ct, int n)
        {
            Int32 sum = 0;
            for (; n > 0; n--)
            {
                ct.ThrowIfCancellationRequested();
                checked
                {
                    sum += n;
                }
            }
            return sum;
        }
    }
}
