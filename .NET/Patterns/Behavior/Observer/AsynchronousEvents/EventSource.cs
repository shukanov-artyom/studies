using System;
using System.Threading;

namespace AsynchronousEvents
{
    internal class EventSource
    {
        public event EventHandler MyEvent;


        public IAsyncResult TriggerEvent()
        {
            Thread.Sleep(1000);
            if (MyEvent != null)
            {
                return MyEvent.BeginInvoke(this, EventArgs.Empty, null, null);
            }
            return null;
        }

        public void EndInvoke(IAsyncResult ar)
        {
            if (MyEvent != null)
            {
                MyEvent.EndInvoke(ar);
            }
        }
    }
}
