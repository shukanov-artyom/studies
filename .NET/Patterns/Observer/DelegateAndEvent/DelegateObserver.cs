using System;

namespace DelegateAndEvent
{
    public class DelegateObserver
    {
        public void CallbackMethod(string notification)
        {
            Console.WriteLine(notification);
        }
    }
}
