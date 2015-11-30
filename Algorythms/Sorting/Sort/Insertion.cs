using System;
using System.Collections.Generic;
using Item = System.Collections.Generic.KeyValuePair<int, string>;

namespace Sort
{
    /// <summary>
    /// Различные сортировки вставками.
    /// </summary>
    public class Insertion
    {
        /// <summary>
        /// Сортировка вставками - примитивная реализация.
        /// стр 248, это неадаптивная реализация, использует только Compexch.
        /// </summary>
        public static void InsertionSortLv1(List<Item> data, int l, int r)
        {
            for (int i = l + 1; i <= r; i++) // внешний цикл 
            {
                for (int j = i; j > l; j--)
                {
                    CompareExchange(data, j - 1, j);
                }
            }
        }

        /// <summary>
        /// Сортировка вставками - улучшенная реализация.
        /// Адаптивная - прекращает выполнение, если левее элемента нет меньших.
        /// </summary>
        public static void InsertionSortLv2(List<Item> data, int l, int r)
        {
            for (int i = l; i <= r; i++) // внешний цикл 
            {
                for (int j = i; j > l; j--)
                {
                    if (data[j].Key < data[j - 1].Key) // если слева всё ещё есть меньший, то меняем
                    {
                        Exch(data, j - 1, j);
                    }
                    else // слева уже нет меньшего элемента, прерываем работу.
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Сортировка вставками с циклом while вместо if
        /// </summary>
        public static void InsertionSortLv3(List<KeyValuePair<int, string>> data, int l, int r)
        {
            for (int i = l; i <= r; i++) // внешний цикл 
            {
                int j = i;
                while (j > 0 && data[j].Key < data[j - 1].Key)
                {
                    Exch(data, j - 1, j);
                    j--;
                }
            }
        }

        /// <summary>
        /// Сортировка вставками c использованием наименьшего элемента в качестве сигнального и без лишних действий во внутреннем цикле.
        /// </summary>
        public static void InsertionSortLv4(List<KeyValuePair<int, string>> data, int l, int r)
        {
            // устанавливаем нулевым наименьший в качестве сигнального элемента.
            for (int i = r; i > l; i--)
            {
                CompareExchange(data, i - 1, i);
            }
            for (int i = l + 2; i <= r; i++) // внешний цикл начиная с третьего элемента
            {
                int j = i;
                KeyValuePair<int, string> v = data[i]; // запоминаем текущий элемент
                while (v.Key < data[j - 1].Key) // пока не достигаем нужной позиции (не более текущего элемента) ...
                {
                    data[j] = data[j - 1]; // ... перемещаем элементы вправо 
                    j--;
                }
                data[j] = v; // вставляем текущий элемент в найденную позицию j
            }
        }

        private static void CompareExchange(List<Item> data, int a, int b)
        {
            if (data[b].Key < data[a].Key)
            {
                Exch(data, a, b);
            }
        }

        private static void Exch(List<Item> data, int a, int b)
        {
            Item c = data[a];
            data[a] = data[b];
            data[b] = c;
        }
    }
}
