using System;

namespace DelegateAndEvent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DelegateSample();

            Console.Read();

            EventSample();

            Console.Read();
        }

        private static void DelegateSample()
        {
            DelegateObserver observer = new DelegateObserver();

            // задаём коллбэк одновременно специфицируя и объект, на котором вызывать, и метод, который вызывать.
            // всё это хранится в инстансе MulticastDelegate
            DelegateNotifier notifier = new DelegateNotifier(observer.CallbackMethod);

            // сейчас нотификатор уведомит наблюдателя, вызывая коллбэк.
            notifier.NotifyAfterTimeout(2000);
            Console.Read();

            // нотификатор ничего не знает о наблюдателе. Мы используем посредника (класс Program), чтобы организовать взаимодействие 
            // наблюдаемого объекта и наблюдателя.
        }

        private static void EventSample()
        {
            EventNotifier notifier = new EventNotifier();
            EventObserver eventObserver = new EventObserver();

            notifier.MyAutoPopertyEvent += eventObserver.ObservingMethod;
            notifier.MyEvent += eventObserver.ObservingMethod;

            notifier.NotifyAfterTimeout(2000);
        }
    }
}
