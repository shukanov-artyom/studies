using System;

namespace dlrstudy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //dynamic d = new MyClass();
            //Process(d); // Dynamic binding takes place

            /*
            Object o = new MyClass();
            Process((dynamic)o);
            Console.Read();*/
        }

        private static void Process(Object a)
        {
            Console.WriteLine("Process(Object)");
        }

        private static void Process(MyClass a)
        {
            Console.WriteLine("Process(MyClass)");
        }

        private static dynamic ProcessDynamic(dynamic a)
        {
            return a;
        }
    }
}
