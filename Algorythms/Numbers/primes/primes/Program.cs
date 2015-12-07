using System;
using System.Linq;
using System.Threading.Tasks;

namespace primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> primesCount = Task.Run(() =>
                                             {
                                                 return Enumerable.Range(2, 10).Count(n => IsPrime(n));
                                             });
            Console.WriteLine(primesCount.Result);
            Console.Read();
        }

        private static bool IsPrime(int num)
        {
            Console.WriteLine("Testing {0}", num);
            int sq = (int)Math.Sqrt(num);
            // minus one here is for we start from 2
            return Enumerable.Range(2, sq-1).All(i => num % i > 0);

            // just for a case here is a for loop unwrap
            /*for (int i = 2; i < sq+1; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not a prime", num);
                    return false;
                }
            }
            Console.WriteLine("{0} is prime", num);
            return true;*/
        }
    }
}
