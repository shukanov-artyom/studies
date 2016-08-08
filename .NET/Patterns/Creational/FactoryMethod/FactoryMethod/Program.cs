using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = GenericFactoryMethodClass.Create<ConcreteProduct>();
            Console.WriteLine(p.GetType().Name);
            Console.Read();
        }
    }
}
