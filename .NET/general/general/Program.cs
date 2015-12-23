using System;

namespace general
{ 
    class Program
    {
        class A
        {
        }

        class B : A
        {
        }

        static void Main(string[] args)
        {
            String name = "Joe";
            String additional;
            D(name);

            return;
        }

        private static int D(string m)
        {
            Int32 length = m.Length;
            return length;
        }
    }
}
