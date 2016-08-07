using System;

namespace visitor
{
    internal class ConcreteClassA : HierarchyRoot
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
}
}
