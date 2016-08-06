using System;

namespace DelegateAndEvent
{
    internal class EventObserver
    {
        public void ObservingMethod(object sender, NotificationEventArgs ea)
        {
            Console.WriteLine(String.Format("Event has come from {0} and it says {1}",
                sender.GetType().Name,
                ea.Notification));
        }
    }
}
