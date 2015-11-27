using System;
using System.Threading.Tasks;

namespace Delay
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                int a = i;
                Task.Delay(i).GetAwaiter().OnCompleted(() => Console.WriteLine("Waited {0} and alive again", a));
            }
            Console.Read();
        }
    }
}
