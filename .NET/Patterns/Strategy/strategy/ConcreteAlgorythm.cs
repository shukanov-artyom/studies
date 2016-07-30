using System;

namespace strategy
{
    public class ConcreteAlgorythm : IIncapsulatedAlgorythm
    {
        public void Do()
        {
            Console.WriteLine("Strategy 1");
        }

        public void Do2()
        {
            Console.WriteLine("Strategy 1");
        }
    }
}
