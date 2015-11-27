using System;
using System.Threading;

namespace Richter.EventsStudy
{
    internal class A
    {
        public void CallbackA(object sender, EventArgs e)
        {
            Console.WriteLine("Callback A called in thread {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
