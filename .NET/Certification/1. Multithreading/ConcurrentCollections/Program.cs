using System;

namespace ConcurrentCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            new BlockingCollectionExperiment().TestBlockingCollection().Wait();

        }
    }
}
