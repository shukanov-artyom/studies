using System;
using System.Collections.Generic;

namespace iterator
{
    internal class EnumeratorProvider
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 123;
        }

        public IEnumerator<int> GetAnotherEnumerator()
        {
            yield return 1;
            yield return 2;
            yield return 4;
        }
    }
}
