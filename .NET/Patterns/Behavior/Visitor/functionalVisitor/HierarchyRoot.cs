using System;

namespace functionalVisitor
{
    public class HierarchyRoot
    {
        public void Match(Action<HierarchyLeafA> leafAMatch, 
            Action<HierarchyLeafB> leafBMatch)
        {
            HierarchyLeafA aInstance = this as HierarchyLeafA;
            if (aInstance != null)
            {
                leafAMatch(aInstance);
                return;
            }
            HierarchyLeafB bInstance = this as HierarchyLeafB;
            if (bInstance != null)
            {
                leafBMatch(bInstance);
                return;
            }
            throw new NotSupportedException();
        }
    }
}
