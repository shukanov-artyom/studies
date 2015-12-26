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
            Int32 v = 5;
            Object o = v;
            v = 123;
        }

        private static int D(string m)
        {
            return 0;
        }
    }
}
