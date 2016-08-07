using System;

namespace visitor
{
    internal class VisitorImpl : IVisitor
    {
        public void Visit(ConcreteClassA instanceA)
        {
            Console.WriteLine(instanceA.GetType().Name);
        }

        public void Visit(ConcreteClassB instanceB)
        {
            Console.WriteLine(instanceB.GetType().Name);
        }
    }
}
