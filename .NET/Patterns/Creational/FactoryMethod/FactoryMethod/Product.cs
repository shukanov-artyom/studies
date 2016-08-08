using System;

namespace FactoryMethod
{
    public class Product
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Product Initialization steps taken.");
        }
    }
}
