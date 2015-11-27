using System;
using System.Collections.Generic;
using Item = System.Collections.Generic.KeyValuePair<int, string>;

namespace Sort
{
    /// <summary>
    /// Сортировка слиянием 
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Двухпутёвое слияние.
        /// </summary>
        private static void TwoWayMerging(Item[] c, Item[] a, int N, Item[] b, int M)
        {
            for (int i = 0, j = 0, k = 0; k < M + N; k++)
            {
                if (i == N)
                {
                    c[k] = b[j++];
                    continue;
                }
                if (j == M)
                {
                    c[k] = a[i++];
                    continue;
                }
                c[k] = a[i].Key < b[j].Key ? a[i++] : b[j++];
            }
        }

        /// <summary>
        /// Абстрактное обменное слияние, стр 315
        /// </summary>
        private static void AbstractExchangeMerging(List<Item> a, int l, int m, int r)
        {
            int i; // переменная цикла левой части массива
            int j; // переменная цикла правой части массива
            Item[] aux = new Item[a.Count];
            // копируем первую часть массива
            for (i = m + 1; i > l; i--)
            {
                aux[i - 1] = a[i - 1];
            }
            // копируем вторую часть массива в обратном порядке
            for (j = m; j < r; j++)
            {
                aux[r + m - j] = a[j + 1];
            }
            for (int k = l; k <= r; k++)
            {
                if (aux[j].Key < aux[i].Key)
                {
                    a[k] = aux[j--];
                }
                else
                {
                    a[k] = aux[i++];
                }
            }
        }

        /// <summary>
        /// Сортировка слиянием.
        /// </summary>
        public static void Mergesort(List<Item> a, int l, int r)
        {
            if (r <= l)
            {
                return;
            }
            int m = (r + l) / 2; // находим середину
            Mergesort(a, m + 1, r);
            Mergesort(a, l, m);
            AbstractExchangeMerging(a, l, m, r);
        }
    }
}
