using System;
using System.Threading;

namespace DelegateAndEvent
{
    public delegate void NotifierDelegate(string ntificationLine);

    public class DelegateNotifier
    {
        private NotifierDelegate notifier;

        public DelegateNotifier(NotifierDelegate notifier)
        {
            this.notifier = notifier;
        }

        public void NotifyAfterTimeout(int timeoutMillisec)
        {
            Thread.Sleep(timeoutMillisec);
            notifier.Invoke("Notifier invoked!");
        }
    }
}
