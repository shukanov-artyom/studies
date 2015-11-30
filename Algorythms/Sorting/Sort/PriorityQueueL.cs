using System;
using System.Collections.Generic;

namespace Sort
{
    /// <summary>
    /// Priority queue based on .NET List class instead of array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PriorityQueueL<T> where T : class
    {
        private List<KeyValuePair<int, T>> q;

        public PriorityQueueL()
        {
            q = new List<KeyValuePair<int, T>>();
            q.Add(new KeyValuePair<int, T>(0, default(T)));
        }

        public PriorityQueueL(IEnumerable<KeyValuePair<int, T>> initial)
        {
            foreach (KeyValuePair<int, T> pair in initial)
            {
                Insert(pair);
            }
        }

        public bool IsEmpty()
        {
            return q.Count == 1;
        }

        public void Insert(T item, int priority)
        {
            q.Add(new KeyValuePair<int, T>(priority, item));
            FixUp(q, q.Count-1);
        }

        public void Insert(KeyValuePair<int, T> pair)
        {
            Insert(pair.Value, pair.Key);
        }

        public T GetMax()
        {
            Exch(q, 1, q.Count - 1); // меняем первый с последним
            FixDown(q, 1, q.Count - 2);
            // восстанавливаем дерево от первого до предпоследнего. Тут последний - бывший максимальный.
            T result = q[q.Count - 1].Value;
            q.RemoveAt(q.Count -1);
            return result; // возвращаем бывший первый элемент
        }

        // Восходящее восстановление пирамидальности дерева.
        private static void FixUp(List<KeyValuePair<int, T>> a, int k)
        {
            while (k > 1 && a[k/2].Key < a[k].Key) 
            {
                Exch(a, k/2, k); // обмениваем элементы
                k = k/2; // переходим выше на уровень дерева
            }
        }

        // Нисходящее восстановление пирамидальности дерева.
        private static void FixDown(List<KeyValuePair<int, T>> a, int k, int N)
        {
            while (2*k <= N)
            {
                int j = 2*k; // сдвигаемся к подэлементам элемента k
                if (j < N && a[j].Key < a[j + 1].Key)
                    // если подэлементы не за границей массива и j-й не больший из подэлементов
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

        private static void Exch(List<KeyValuePair<int, T>> data, int a, int b)
        {
            KeyValuePair<int, T> t = data[a];
            data[a] = data[b];
            data[b] = t;
        }
    }
}
