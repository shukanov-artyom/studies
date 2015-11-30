using System;
using System.Collections.Generic;
using Item = System.Collections.Generic.KeyValuePair<int, string>;

namespace Sort
{
    public static class Bubble
    {
        /// <summary>
        /// Сортировка пузырьком.
        /// </summary>
        public static void BubbleSort(List<Item> data, int l, int r)
        {
            for (int i = l; i < r; i++) // идём слева направо
            {
                for (int j = r; j > i; j--) // идём справа налево, поднимая пузырёк
                {
                    CompareExchange(data, j - 1, j);
                }
            }
        }

        /// <summary>
        /// Сортировка пузырьком.
        /// </summary>
        public static void BubbleSortAscending(List<Item> data, int l, int r)
        {
            for (int i = l; i < r; i++) // идём слева направо
            {
                for (int j = l; j < r - i; j++) // идём слева направо, опуская пузырёк
                {
                    CompareExchange(data, j, j + 1);
                }
            }
        }

        /// <summary>
        /// Сортировка пузырьком.
        /// </summary>
        public static void BubbleSortAdvanced(List<Item> data, int l, int r)
        {
            for (int i = l; i < r; i++) // идём слева направо
            {
                bool hasBeenMoved = false;
                for (int j = r; j > i; j--) // идём справа налево, поднимая пузырёк
                {
                    if (data[j].Key < data[j - 1].Key)
                    {
                        Exch(data, j - 1, j);
                        hasBeenMoved = true;
                    }
                }
                if (!hasBeenMoved)
                {
                    break; // already sorted!
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
