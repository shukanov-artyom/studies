using System;
using System.Threading;

namespace System.ThreadingTimer.Study
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // создаём потоковый таймер
            TimerCallback cb = state => { Console.WriteLine("Timer called."); };
            Timer timer = new Timer(cb, null, 1000, 1000);
            // отдельно запускать таймер не требуется
            GC.Collect();
            Thread.Sleep(10000);

            /* если собрать этот пример в релизе, то дебагер не будет держать 
            локальные ссылки до выхода из блока, и таймер не выполнится ни разу.*/
        }

        /*
         * второй пример использует Using, и юзинг держит ссылку на таймер до конца, 
         * чтобы в конце вызвать Dispose()
         */
    }
}
