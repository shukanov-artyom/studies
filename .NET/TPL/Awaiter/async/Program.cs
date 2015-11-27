using System;
using System.Linq;
using System.Threading.Tasks;

namespace async
{
    class Program
    {
        static void Main(string[] args)
        {
            // вместо создания конечного автомата вручную полагаемся на async / await
            Task t = DisplayPrimesCounts();
            try
            {
                t.Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
            }
        }

        private static async Task DisplayPrimesCounts()
        {
            for (int i = 0; i < 10; i++)
            {
                int t = await GetPrimesCountAsync(i*1000+2, 1000);
                Console.WriteLine("{0} primes found between {1} and {2}", t, i * 1000, (i+1) * 1000 -1);
            }
            Console.WriteLine("Done.");
        }

        // ключевой метод, выполняющий основную работу.
        private static Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() => Enumerable.Range(start, count).
                Count(r => Enumerable.Range(2, (int)Math.Sqrt(r) - 1).All(p => r % p == 0)));
        }
    }
}
