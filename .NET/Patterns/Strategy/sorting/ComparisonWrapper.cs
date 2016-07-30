using System;
using System.Collections.Generic;

namespace sorting
{
    /// <summary>
    /// полезный адаптерный фабричный класс, превращающий делегат Comparison<T> в IComparable<T>.
    /// </summary>
    public class ComparisonWrapperFactory
    {
        public static IComparer<T> Create<T>(Comparison<T> comparisonCode)
        {
            return new DelegateComparer<T>(comparisonCode);
        }

        private class DelegateComparer<T> : IComparer<T>
        {
            private readonly Comparison<T> cmpDelegate;

            public DelegateComparer(Comparison<T> cmpDelegate)
            {
                this.cmpDelegate = cmpDelegate;
            }

            public int Compare(T x, T y)
            {
                return cmpDelegate(x, y);
            }
        }
    }
}
