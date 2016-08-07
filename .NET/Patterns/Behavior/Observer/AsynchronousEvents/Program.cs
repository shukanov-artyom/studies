using System;
using System.Threading;

namespace AsynchronousEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            EventSource source = new EventSource();
            source.MyEvent += EventTarget;
            IAsyncResult ar = source.TriggerEvent();
            Console.WriteLine("Original thread reports: event triggered!");
            Console.Read();
            if (ar.CompletedSynchronously)
            {
                Console.WriteLine("Async call completed synchronously!");
            }
            source.EndInvoke(ar);
            Console.WriteLine("Finished!");
        }

        private static void EventTarget(object sender, EventArgs e)
        {
            Thread.Sleep(1500);
            Console.WriteLine("Background reports: Event target initiated!");
        }
    }
}
