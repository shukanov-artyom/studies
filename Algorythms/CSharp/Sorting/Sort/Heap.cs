using System;
using System.Collections.Generic;
using Item = System.Collections.Generic.KeyValuePair<int, string>;

namespace Sort
{
    /// <summary>
    /// ПИрамидальные алгоритмы
    /// </summary>
    public class Heap
    {
        public static void HeapSort(List<Item> data, int l, int r)
        {
            int k;
            int N = r - l + 1; // количество элементов в массиве, представляющем дерево
            // первый цикл строит пирамидальное дерево для первой половины массива, так как вторая половина это листья
            for (k = N/2; k >=1 ; k--)
            {
                PriorityQueue.FixDown(data, k, N);
            }
            while (N > 1)
            {
                PriorityQueue.Exch(data, 1, N);
                PriorityQueue.FixDown(data, 1, --N);
            }
        }

        public void Do()
        {
            var q = new PriorityQueueL<string>();
            //var q = new PriorityQueue(22);
            q.Insert(new Item(1, "A"));
            q.Insert(new Item(19, "S"));
            q.Insert(new Item(15, "O"));
            q.Insert(new Item(18, "R"));
            q.Insert(new Item(20, "T"));
            q.Insert(new Item(9, "I"));
            q.Insert(new Item(14, "N"));
            q.Insert(new Item(7, "G"));
            q.Insert(new Item(5, "E"));
            q.Insert(new Item(24, "X"));
            q.Insert(new Item(1, "A"));
            q.Insert(new Item(13, "M"));
            q.Insert(new Item(16, "P"));
            q.Insert(new Item(12, "L"));
            q.Insert(new Item(5, "E"));

            string s;
            while (!q.IsEmpty())
            {
                s = q.GetMax();
            }

            List<Item> arr = new List<Item>(new[]
                         {
                                        new Item(1, "A"),
                                        new Item(19, "S"),
                                        new Item(15, "O"),
                                        new Item(18, "R"),
                                        new Item(20, "T"),
                                        new Item(9, "I"),
                                        new Item(14, "N"),
                                        new Item(7, "G"),
                                        new Item(5, "E"),
                                        new Item(24, "X"),
                                        new Item(1, "A"),
                                        new Item(13, "M"),
                                        new Item(16, "P"),
                                        new Item(12, "L"),
                                        new Item(5, "E")
                         });
            HeapSort(arr, 0, 13);
        }

        private class PriorityQueue
        {
            private int N;
            private List<Item> q;

            public PriorityQueue(int maxN)
            {
                q = new List<Item>(new Item[maxN + 1]);
                N = 0;
            }

            public bool IsEmpty()
            {
                return N == 0;
            }

            public void Insert(Item item)
            {
                q[++N] = item;
                FixUp(q, N);
            }

            public Item GetMax()
            {
                Exch(q, 1, N); // меняем первый с последним
                FixDown(q, 1, N-1); // восстанавливаем дерево от первого до предпоследнего. Тут последний - бывший максимальный.
                return q[N--]; // возвращаем бывший первый элемент
            }

            // Восходящее восстановление пирамидальности дерева.
            private void FixUp(List<Item> a, int k)
            {
                while (k > 1 && a[k/2].Key < a[k].Key) // закон действует от k=2 до N, см стр 341 Седжвика
                {
                    Exch(a, k/2, k); // обмениваем элементы
                    k = k/2; // переходим выше
                }
            }

            // Нисходящее восстановление пирамидальности дерева.
            public static void FixDown(List<Item> a, int k, int N)
            {
                while (2 * k <=N)
                {
                    int j = 2*k; // сдвигаемся к подэлементам элемента k
                    if (j < N && a[j].Key < a[j + 1].Key) // если подэлементы не за границей массива и j-й не больший из подэлементов
                    {
                        j++; // переходим к большему из подэлементов
                    }
                    if (!(a[k].Key < a[j].Key)) // если отец не меньше наибольшего из детей
                    {
                        break; // то никакого действия больше не требуется, дерево пирамидально упорядочено
                    }
                    Exch(a, k, j); // иначе меняем местами элементы, опуская вниз меньший
                    k = j; // и опускаемся на уровень ниже
                }
            }

            public static void Exch(List<Item> data, int a, int b)
            {
                Item c = data[a];
                data[a] = data[b];
                data[b] = c;
            }
        }
    }
}
