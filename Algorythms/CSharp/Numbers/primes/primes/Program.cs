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
                                                 return Enumerable.Range(2, 10).Count(n =>
                                                     Enumerable.Range(2, (int) Math.Sqrt(n)).All(i => n%i > 0));
                                             });
            Console.WriteLine(primesCount.Result);
            Console.Read();
        }
    }
}
