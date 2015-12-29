using System;
using shared;

namespace nodeadlock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var demo = new DeadlockDemo();
            demo.Test();
            Console.WriteLine("No deadlock!");
        }
    }
}
