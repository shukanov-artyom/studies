using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LazySingleton.Instance.Do();
            DoubleCheckedLockSingleton.Instance.Do();
            FieldInitSingleton.Instance.Do();

            Console.Read();
        }
    }
}
