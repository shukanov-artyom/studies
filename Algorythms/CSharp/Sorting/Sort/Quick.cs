using System;
using System.Collections;
using System.Collections.Generic;
using Item= System.Collections.Generic.KeyValuePair<int, string>;

namespace Sort
{
    public class Quick
    {
        /// <summary>
        /// Быстрая сортировка - рекурсивная реализация
        /// </summary>
        public static void QuickSort(List<Item> data, int l, int r)
        {
            if (r <= l)
            {
                return;
            }
            int i = Partition(data, l, r);
            QuickSort(data, l, i - 1);
            QuickSort(data, i + 1, r);
        }

        /// <summary>
        /// Быстрая сортировка - нерекурсивная реализация
        /// </summary>
        public static void QuickSortStacked(List<Item> data, int l, int r)
        {
            Stack<int> s = new Stack<int>();
            s.Push(r);
            s.Push(l);
            while (s.Count != 0)
            {
                l = s.Pop();
                r = s.Pop();
                if (r <= l)
                {
                    continue;
                }
                int i = Partition(data, l, r);
                if (i - 1 < r - i && r > l)
                {
                    s.Push(i - 1);
                    s.Push(l);
                    s.Push(r);
                    s.Push(i + 1);
                }
                else if (r > l)
                {
                    s.Push(r);
                    s.Push(i + 1);
                    s.Push(i - 1);
                    s.Push(l);
                }
            }
        }

        /// <summary>
        /// Быстрая сортировка - нерекурсивная реализация со вспомогательной сортировкой вставками
        /// </summary>
        public static void QuickSortStackedInsertion(List<Item> data, int l, int r)
        {
            Stack<int> s = new Stack<int>();
            s.Push(r);
            s.Push(l);
            int M = 9;
            while (s.Count != 0)
            {
                l = s.Pop();
                r = s.Pop();
                if (r - 1 < M)
                {
                    continue;
                }
                int i = Partition(data, l, r);
                if (i - 1 < r - i && r > l)
                {
                    s.Push(i - 1);
                    s.Push(l);
                    s.Push(r);
                    s.Push(i + 1);
                }
                else if (r > l)
                {
                    s.Push(r);
                    s.Push(i + 1);
                    s.Push(i - 1);
                    s.Push(l);
                }
            }
            Insertion.InsertionSortLv3(data, l, r);
        }

        public static int Partition(List<Item> data, int l, int r)
        {
            int i = l - 1;
            int j = r;
            Item v = data[r];
            for (; ; )
            {
                while (data[++i].Key < v.Key) ;
                while (v.Key < data[--j].Key)
                {
                    if (j == l)
                    {
                        break;
                    }
                }
                if (i >= j)
                {
                    break;
                }
                Exch(data, i, j);
            }
            Exch(data, i, r);
            return i;
        }

        /// <summary>
        /// .NET sort based on QuickSort and HeapSort
        /// </summary>
        public static void DepthLimitedQuickSort(List<Item> data, int l, int r)
        {
            do
            {
                int low = l;
                int hi = r;
                int median = (low + hi)/2;
                try
                {
                    CompareExchange(data, low, median);
                    CompareExchange(data, low, hi);
                    CompareExchange(data, median, hi);
                }
                catch (Exception exception2)
                {
                    throw new InvalidOperationException();
                }

                Item y = data[median];
                do
                {
                    try
                    {
                        while (data[low].Key < y.Key)
                        {
                            low++;
                        }
                        while (y.Key < data[hi].Key)
                        {
                            hi--;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new ArgumentException();
                    }
                    catch (Exception exception3)
                    {
                        throw new InvalidOperationException();
                    }
                    if (low > hi)
                    {
                        break;
                    }
                    if (low < hi)
                    {
                        Exch(data, low, hi);
                    }
                    if (low != 0x7fffffff)
                    {
                        low++;
                    }
                    if (hi != -2147483648)
                    {
                        hi--;
                    }
                }
                while (low <= hi);

                if ((hi - l) <= (r - low))
                {
                    if (l < hi)
                    {
                        DepthLimitedQuickSort(data, l, hi);
                    }
                    l = low;
                }
                else
                {
                    if (low < r)
                    {
                        DepthLimitedQuickSort(data, low, r);
                    }
                    r = hi;
                }
            }
            while (l < r);
        }

        private static void Exch(List<KeyValuePair<int, string>> data, int a, int b)
        {
            KeyValuePair<int, string> c = data[a];
            data[a] = data[b];
            data[b] = c;
        }

        private static void CompareExchange(List<KeyValuePair<int, string>> data, int a, int b)
        {
            if (data[b].Key < data[a].Key)
            {
                Exch(data, a, b);
            }
        }
    }
}
