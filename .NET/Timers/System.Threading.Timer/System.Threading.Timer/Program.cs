using System;
using System.Threading;

namespace System.ThreadingTimer.Study
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // создаём потоковый таймер
            // делегат будет выполнен на потоке из пула!
            TimerCallback cb = state =>
            {
                Console.WriteLine("Timer called.");
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}.");
                Console.WriteLine($"Is from pool: {Thread.CurrentThread.IsThreadPoolThread}.");
            };
            Timer timer = new Timer(cb, null, 1000, 1000);
            // отдельно запускать таймер не требуется
            GC.Collect();
            Thread.Sleep(10000);

            /* если собрать этот пример в релизе, то дебагер не будет держать 
            локальные ссылки до выхода из блока, и таймер не выполнится ни разу.*/

            // второй пример - с юзингом таймер отрабатывает как надо
            Main2();
        }

        /*
         * второй пример использует Using, и юзинг держит ссылку на таймер до конца, 
         * чтобы в конце вызвать Dispose()
         */

        public static void Main2()
        {
            TimerCallback cb = state =>
            {
                Console.WriteLine("Timer called.");
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}.");
                Console.WriteLine($"Is from pool: {Thread.CurrentThread.IsThreadPoolThread}.");
            };
            using (Timer timer = new Timer(cb, null, 1000, 1000))
            {
                // отдельно запускать таймер не требуется
                GC.Collect();
                Thread.Sleep(10000);
            }
        }
    }
}
