using System;

namespace Singleton
{
    public class DoubleCheckedLockSingleton
    {
        private static volatile DoubleCheckedLockSingleton instance;
        private static readonly object syncRoot = new Object();

        private DoubleCheckedLockSingleton()
        {
        }

        public static DoubleCheckedLockSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckedLockSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        public void Do()
        {
            Console.WriteLine("Double-checked lock singleton does its work!");
        }
    }
}
