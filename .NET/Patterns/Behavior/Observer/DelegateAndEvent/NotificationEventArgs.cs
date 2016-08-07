using System;

namespace DelegateAndEvent
{
    public class NotificationEventArgs : EventArgs
    {
        public NotificationEventArgs(string notification)
        {
            this.Notification = notification;
        }

        public string Notification { get; private set; }
    }
}
