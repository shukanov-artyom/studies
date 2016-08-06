using System;
using System.Collections;
using System.Collections.Generic;

namespace iterator
{
    public class IteratorBlockMethod
    {
        public IEnumerable EmptyIterator()
        {
            yield break;
        }

        public IEnumerable<int> SimpleIteratorBlock()
        {
            yield return 1;
            yield return 2;
            yield return 10;
        }
    }
}
