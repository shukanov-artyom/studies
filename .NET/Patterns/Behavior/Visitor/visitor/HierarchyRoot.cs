using System;

namespace visitor
{
    internal abstract class HierarchyRoot
    {
        public abstract void Accept(IVisitor visitor);
    }
}
