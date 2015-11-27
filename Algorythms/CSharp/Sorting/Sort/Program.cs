using System;
using System.Collections.Generic;
using System.Linq;
using Item = System.Collections.Generic.KeyValuePair<int, string>;

namespace Sort
{
    internal class Program
    {
        private delegate void Sorter(List<KeyValuePair<int, string>> data, int left, int right);

        private static void Main(string[] args)
        {
            var sorters = new List<Sorter>()
                          {
                              SelectionSort,

                              Insertion.InsertionSortLv1,
                              Insertion.InsertionSortLv2,
                              Insertion.InsertionSortLv3,
                              Insertion.InsertionSortLv4,

                              Bubble.BubbleSort,
                              Bubble.BubbleSortAdvanced,
                              Bubble.BubbleSortAscending,

                              ShakerSort,
                              ShellSort,

                              Quick.QuickSort,
                              Quick.QuickSortStacked,
                              //Quick.QuickSortStackedInsertion,
                              Quick.DepthLimitedQuickSort,

                              MergeSort.Mergesort,
                              //Heap.HeapSort
                          };
            foreach (Sorter sorter in sorters)
            {
                var data = GetData().ToList();
                sorter.Invoke(data, 0, data.Count - 1);
                if (!ValidateSorted(data))
                {
                    throw null;
                }
            }
            new InSituPermutation().Sort();
            //new LinkedListSort().Sort();
            new KeyIndexedCounting().Do();
            //RadixMsdSort.Do();
        }

        private static IEnumerable<Item> Bitonic(IList<Item> a, IList<Item> b)
        {
            foreach (Item pair in a)
            {
                yield return pair;
            }
            foreach (var pair in b)
            {
                yield return pair;
            }
        }
 
        /// <summary>
        /// Compares sorter, retuns the one which is faster.
        /// Tests on random data.
        /// </summary>
        private static Sorter Compare(Sorter a, Sorter b)
        {
            List<Item> data = GetData().ToList();
            List<Item> data1 = new List<Item>(data);
            DateTime startA = DateTime.Now;
            a.Invoke(data, 0, data.Count - 1);
            DateTime stopA = DateTime.Now;
            DateTime startB = DateTime.Now;
            b.Invoke(data1, 0, data.Count - 1);
            DateTime stopB = DateTime.Now;
            TimeSpan spanA = stopA - startA;
            TimeSpan spanB = stopB - startB;
            if (spanA < spanB)
            {
                return a;
            }
            return b;
        }

        private static IEnumerable<KeyValuePair<int, string>> GetData()
        {
            return new List<KeyValuePair<int, string>>()
            {
                new Item(1, ""),
                new Item(2, ""),
                new Item(56, ""),
                new Item(23, ""),
                new Item(34, ""),
                new Item(899, ""),
                new Item(22, ""),
                new Item(17, ""),
                new Item(18, ""),
                new Item(19, ""),
                new Item(21, ""),
                new Item(20, ""),
                new Item(0, "")
            };
            /*int N = 1000;
            Random r = new Random(N);
            for (int i = 0; i < 1000; i++)
            {
                yield return new Item(r.Next(0, N), "A");
            }*/
        }

        private static bool ValidateSorted( List<KeyValuePair<int, string>> data)
        {
            for (int i = 1; i < data.Count; i++)
            {
                if (data[i - 1].Key > data[i].Key)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Сортировка выбором.
        /// </summary>
        private static void SelectionSort(List<KeyValuePair<int, string>> data, int l, int r)
        {
            for (int i = l; i < r; i++) // проходим все позиции слева направо
            {
                int min = i;
                for (int j = i+1; j <=r; j++) // в цикле определяем минимальный элемент диапазона
                {
                    if (data[j].Key < data[min].Key)
                    {
                        min = j;
                    }
                }
                Exch(data, i, min); // меняем местами минимальный и i-й
            }
        }

        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        private static void ShakerSort(List<KeyValuePair<int, string>> data, int l, int r)
        {
            for (int i = l; i < r; i++)
            {
                int beg = l;
                int end = r;
                do
                {
                    if (data[beg].Key > data[beg + 1].Key)
                    {
                        Exch(data, beg, beg+1);
                    }
                    beg++;
                    if (data[end - 1].Key > data[end].Key)
                    {
                        Exch(data, end-1, end);
                    }
                    end--;
                } while (beg <= end);
            }
        }

        /// <summary>
        /// H-sorts a file as one step for ShellSort
        /// </summary>
        private static void HSort(List<KeyValuePair<int, string>> data, int l, int r)
        {
            int h = 7;
            for (int i = l + h; i <= r; i++)
            {
                int j = i;
                var v = data[i];
                // сортируем вставками
                while (j >= l + h && v.Key < data[j - h].Key)
                {
                    data[j] = data[j - h];
                    j -= h;
                }
                data[j] = v;
            }
        }

        /// <summary>
        /// Сортировка Шелла
        /// </summary>
        private static void ShellSort(List<KeyValuePair<int, string>> data, int l, int r)
        {
            int h;
            for (h = 1; h <= (r - l)/9; h = 3*h + 1) ;
            // here we have the first h-step
            for (; h > 0; h /= 3)
            {
                // в этом циклё идёт h-сортировка с шагом h
                for (int i = l + h; i<=r; i++)
                {
                    int j = i;
                    var v = data[i]; // тут начинается сортировка вставками
                    while (j >= l+h && v.Key < data[j-h].Key)
                    {
                        data[j] = data[j - h];
                        j -= h;
                    }
                    data[j] = v;
                }
            }
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
