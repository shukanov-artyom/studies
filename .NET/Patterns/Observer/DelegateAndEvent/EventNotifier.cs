using System;
using System.Threading;

namespace DelegateAndEvent
{
    public class EventNotifier
    {
        private object locker = new object();

        // delegate backing custom-assignment event
        // EventHandler sets up a delegate type which backs this property.
        // The same is for autoproperty.
        private EventHandler<NotificationEventArgs> eventBackingDelegate;

        // custom assignment event. Implemented thread-safe!
        public event EventHandler<NotificationEventArgs> MyEvent
        {
            // потокобезопансое исполнение: кастомный локер, недоступный никому извне
            add
            {
                lock (locker)
                {
                    eventBackingDelegate += value;
                }
            }
            remove
            {
                lock (locker) // in case of implicit implementation this would be lock(this)
                {
                    eventBackingDelegate -= value;
                }
            }
        }

        // implicit event declaration: property-like event
        // не потокобезопасное исполнение: неявно лочится на this.
        public event EventHandler<NotificationEventArgs> MyAutoPopertyEvent;

        private void OnMyEvent()
        {
            // потокобезопасное исполнение
            EventHandler<NotificationEventArgs> delegateInstance;
            lock (locker)
            {
                delegateInstance = eventBackingDelegate; // Copy semantics. Delegates are immutable like strings!
            }
            if (delegateInstance != null)
            {
                delegateInstance.Invoke(this, new NotificationEventArgs("Custom delegate called!"));
            }
        }

        private void OnMyAutodelegateEvent()
        {
            // непотокобезопасное исполнение
            if (MyAutoPopertyEvent != null)
            {
                MyAutoPopertyEvent.Invoke(this, new NotificationEventArgs("Autoproperty event called!"));
            }
        }

        public void NotifyAfterTimeout(int timeoutMillisec)
        {
            Thread.Sleep(timeoutMillisec);
            OnMyEvent();
            OnMyAutodelegateEvent();
        }
    }
}
