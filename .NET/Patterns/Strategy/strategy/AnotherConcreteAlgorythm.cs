using System;

namespace strategy
{
    public class AnotherConcreteAlgorythm : IIncapsulatedAlgorythm
    {
        public void Do()
        {
            Console.WriteLine("Strategy Another 1");
        }

        public void Do2()
        {
            Console.WriteLine("Strategy Another 2");
        }
    }
}
