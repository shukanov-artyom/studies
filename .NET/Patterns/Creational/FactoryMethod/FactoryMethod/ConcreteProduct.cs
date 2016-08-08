using System;

namespace FactoryMethod
{
    public class ConcreteProduct : Product
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Derived class initialization steps performed here!");
        }
    }
}
