using System;
using System.Linq;
using System.Threading;

namespace ThreadTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thr = new Thread(new ThreadStart(ThreadMethod));
            thr.Start();
            Thread.Sleep(120);
            thr.Abort();
            Console.Read();
        }

        private static void ThreadMethod()
        {
            try
            {
                foreach (var k in Enumerable.Range(0, 20))
                {
                    Thread.Sleep(20);
                }
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine("Thread aborted!");
            }
        }
    }
}
