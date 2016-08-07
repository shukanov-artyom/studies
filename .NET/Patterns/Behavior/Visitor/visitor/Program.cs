using System;

namespace visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteClassA a = new ConcreteClassA();
            ConcreteClassB b = new ConcreteClassB();

            IVisitor visitor = new VisitorImpl();

            a.Accept(visitor);
            b.Accept(visitor);

            Console.Read();
        }
    }
}
