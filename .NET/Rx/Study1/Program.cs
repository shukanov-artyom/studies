using System;
using System.Linq;

namespace Study1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //IxDoDemo();
            IxDoWhileDemo();
        }

        private static void IxDoDemo()
        {
            var nums = new int[] {1, 2, 3, 4};
            var modified = nums.Do(item => Console.WriteLine($"I have {item}"));
            foreach (var v in modified)
            {
                Console.WriteLine($"Hello from {v} inside loop");
            }
        }

        private static void IxDoWhileDemo()
        {
            var nums = new int[] {1, 2, 3, 4};
            var then = DateTimeOffset.Now + new TimeSpan(0, 0, 10); // 10 sec from now
            var modified = nums.DoWhile(() => DateTimeOffset.Now < then);
            foreach (var v in modified)
            {
                Console.WriteLine($"Hello from loop from {v}!");
            }
        }
    }
}
