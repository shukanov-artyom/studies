using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgorythmClient cl = new AlgorythmClient(true);
            cl.Execute();
            Console.Read();
        }
    }
}
