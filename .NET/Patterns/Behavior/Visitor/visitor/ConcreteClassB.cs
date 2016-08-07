using System;

namespace visitor
{
    internal class ConcreteClassB : HierarchyRoot
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
