using System;
using System.Collections.Generic;

namespace iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empty iterator:");
            foreach (object v in new IteratorBlockMethod().EmptyIterator())
            {
                Console.WriteLine(v);
            }

            Console.WriteLine();
            Console.WriteLine("Simple iterator:");
            foreach (int t in new IteratorBlockMethod().SimpleIteratorBlock())
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();
            Console.WriteLine("Foreaching not IEnumerable!:");
            foreach (object o in new EnumeratorProvider()) 
            {
                Console.WriteLine(o);
            }


            Console.WriteLine();
            Console.WriteLine("Enumerating manually:");
            using (IEnumerator<int> e = new EnumeratorProvider().GetEnumerator())
            {
                while (e.MoveNext())
                {
                    Console.WriteLine(e.Current);
                }
            }

            Console.Read();
        }
    }
}
