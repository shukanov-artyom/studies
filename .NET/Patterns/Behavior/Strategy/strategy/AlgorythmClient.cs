using System;
using System.Runtime.Remoting.Messaging;

namespace strategy
{
    public class AlgorythmClient
    {
        // Using interface as it contains two methods.
        private readonly IIncapsulatedAlgorythm algo;

        private readonly Action<bool> functionalStrategy;

        public AlgorythmClient(bool another)
        {
            if (another)
            {
                algo = new AnotherConcreteAlgorythm();
                functionalStrategy = b =>
                {
                    Console.WriteLine("Functional strategy A");
                };
            }
            else
            {
                algo = new ConcreteAlgorythm();
                functionalStrategy = b =>
                {
                    Console.WriteLine("Functional strategy B");
                };
            }
        }

        public void Execute()
        {
            algo.Do();
            algo.Do2();
            functionalStrategy(false);
        }
    }
}
