using System;

namespace csharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            switch (a)
            {
                case int g:
                    Console.WriteLine($"We have an ing {g}");
                    break;
                default: 
                    throw null;
                    break;
                // case string p:
                //     Console.WriteLine($"We have a string {p}");
            }
        }
    }
}
