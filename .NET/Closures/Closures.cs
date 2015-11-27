using System;

namespace Richter.Closures
{
    public class Closures
    {
        private readonly Func<int> function;

        public Closures()
        {
            int a = 0;
            function = () => a++;
        }

        public void Do()
        {
            Console.WriteLine(function());
            Console.WriteLine(function());
            Console.WriteLine(function());
            Console.WriteLine(function());
        }
    }
}
