using System;
using System.Globalization;
using Search.Utils;

namespace Search
{
    internal class BTreeSymbolTable : ISymbolTable
    {
        private const int Mmax = 20;

        private BItem root= new BItem();
        private int Ht;
        private int n = 0;

        public void Insert(Item item)
        {
            BItem u = InsertR(root, item, Ht);
            n++; // увеличиваем счётчик узлов
            if (u == null) // разбиение корня не требуется 
            {
                return;
            }
            // разбиваем корень
            BItem t = new BItem();
            t.M = 2; // это будет новый корень, и у него будет только две активных ссылки
            // заполняем активные ссылки
            t.B[0] = new BNode {Next = root, Key = root.B[0].Key}; // берём первые ключи из поддеревьев чтоб указать на эти поддеревья
            t.B[1] = new BNode {Next = u, Key = u.B[0].Key};
            root = t;
            Ht++; // увеличиваем счётчик высоты дерева
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Item Search(int key)
        {
            return SearchR(root, key, Ht);
        }

        public void Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public Item Select(int key)
        {
            throw new NotImplementedException();
        }

        private static void InsertIntoExternal(BItem h, Item item)
        {
            int j;
            BNode t = new BNode() { Item = item, Key = item.Key };
            for (j = 0; j < h.M; j++)
            {
                if (item.Key < h.B[j].Key)
                {
                    break;
                }
            }
            int i = h.M;
            while (i > j)
            {
                h.B[i] = h.B[i - 1];
                i--;
            }
            h.B[j] = t;
            h.M++;
        }

        private static void InsertIntoInternal(BItem h, Item item, int ht)
        {
            int j;
            // we have to find a B element to insert item to
            for (j = 0; j < h.M; j++)
            {
                if (h.B[0].Key > item.Key)
                {
                    h.B[0].Key = item.Key;
                    j = 0;
                    break;
                }
                if (h.B[j].Key > item.Key)
                {
                    j--;
                    break;
                }
                if (j == h.M-1)
                {
                    break;
                }
                // j=M-1 here
            }
            // j is what we need
            BItem u = InsertR(h.B[j].Next, item, ht - 1);
            if (u == null)
            {
                return;
            }
            BNode t = new BNode() {Key=u.B[0].Key, Next = u};
            j++;
            int i = h.M;
            while (i > j && i-1 > 0)
            {
                h.B[i] = h.B[i - 1];
                i--;
            }
            h.B[j] = t;
            h.M++;
        }

        private static BItem InsertR(BItem h, Item item, int ht)
        {
            if (ht == 0) // вставляем во внешний узел
            {
                InsertIntoExternal(h, item);
            }
            else // вставляем во внутренний узел
            {
                InsertIntoInternal(h, item, ht);
            }
            if (h.M < Mmax)
            {
                return null;
            }
            return Split(h);
        }

        /// <summary>
        /// Ищем элемент в B-дереве
        /// </summary>
        /// <param name="tree">обыскиваемое дерево</param>
        /// <param name="key">искомый ключ</param>
        /// <param name="ht">высота обыскиваемого дерева</param>
        private static Item SearchR(BItem tree, int key, int ht)
        {
            if (ht == 0) // обыскиваемое дерево - внешнее, ожидаем ссылок на элементы
            {
                // ищем прямым перебором
                for (int i = 0; i < tree.M; i++)
                {
                    if (tree.B[i].Key == key)
                    {
                        return tree.B[i].Item;
                    }
                }
                // ищем бинарным поиском
                //return BinarySearch(tree, key, 0, tree.M-1);
            }
            else // обыскиваемое дерево - внутреннее, ожидаем ссылки на другие деревья в детях
            {
                for (int i = 0; i < tree.M; i++)
                {
                    if (i + 1 == tree.M || // it's last subtree
                        tree.B[i + 1].Key > key) // следующая секция содержит ключи больше искомого
                    {
                        return SearchR(tree.B[i].Next, key, ht - 1);
                    }
                }
            }
            return null;
        }

        private static Item BinarySearch(BItem tree, int key, int start, int end)
        {
            int km = (end + start)/2;
            if (tree.B[km].Key == key)
            {
                return tree.B[km].Item;
            }
            if (tree.B[km].Key > key)
            {
                return BinarySearch(tree, key, start, km-1);
            }
            return BinarySearch(tree, key, km+1, end);
        }

        private static BItem Split(BItem h)
        {
            BItem t = new BItem();
            for (int i = 0; i < Mmax/2; i++)
            {
                t.B[i] = h.B[Mmax/2 + i];
                h.B[Mmax / 2 + i] = null;
            }
            h.M = Mmax/2;
            t.M = Mmax/2;
            return t;
        }
    }
}
