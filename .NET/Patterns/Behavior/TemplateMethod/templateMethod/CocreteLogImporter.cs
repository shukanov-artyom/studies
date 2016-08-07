using System;

namespace templateMethod
{
    public class CocreteLogImporter : LogImporter
    {
        protected override object AlgorythmStep1()
        {
            Console.WriteLine("Part 1 exec.");
            return new Object();
        }

        protected override void AlgorythmStep2(object o)
        {
            Console.WriteLine("Part 2 exec.");
        }
    }
}
