using System;

namespace templateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            LogImporter li = new CocreteLogImporter();
            li.MainAlgorythm();
        }
    }
}
