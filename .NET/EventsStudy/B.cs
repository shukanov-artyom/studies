using System;
using System.Threading;

namespace Richter.EventsStudy
{
    internal class B
    {
        public void CallbackB(object sender, EventArgs e)
        {
            Console.WriteLine("Callback B called in thread {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
