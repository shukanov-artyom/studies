using System;

namespace _1A_TheaterSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] spl = input.Split(' ');
            int m = Int32.Parse(spl[0]);
            int n = Int32.Parse(spl[1]);
            int a = Int32.Parse(spl[2]);
            int ms = m % a == 0 ? m / a : m / a + 1;
            int ns = n % a == 0 ? n / a : n / a + 1;
            int result = ms * ns;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
