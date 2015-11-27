using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace thr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            Test2();
            //Test3();
            Console.Read();
        }

        private static void Test1()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(400);
                    Console.WriteLine("woohoo");
                }
            });
            Console.Read();
        }

        private static void Test2()
        {
            Task<int> tsk = Task.Run(() => Enumerable.Range(2, 8).Count(IsPrime));
            Console.WriteLine(tsk.Result);
            Console.Read();
        }

        private static void Test3()
        {
            foreach (int i in Enumerable.Range(2, 8))
            {
                Console.WriteLine(i);
            }
        }

        private static bool IsPrime(int n)
        {
            return Enumerable.Range(2, (int) Math.Sqrt(n)).All(m => n%m > 0);
        }
    }
}
