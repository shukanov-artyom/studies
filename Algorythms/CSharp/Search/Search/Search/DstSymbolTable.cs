using System;
using Search.Utils;

namespace Search
{
    internal class DstSymbolTable : ISymbolTable
    {
        private BstItem root;
        private int N = 0;

        public void Insert(Item item)
        {
            InsertRecursive(ref root, item, 0);
            N++;
        }

        public int Count()
        {
            return N;
        }

        public Item Search(int key)
        {
            return SearchDstRecursive(root, key, 0);
        }

        public void Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public Item Select(int key)
        {
            throw new NotSupportedException();
        }

        private Item SearchDstRecursive(BstItem tree, int key, int digit)
        {
            // следуем по дереву, заданному битами ИСКОМОГО/ВСТАВЛЯЕМОГО ключа
            if (tree == null)
            {
                return null;
            }
            if (tree.Item.Key == key)
            {
                return tree.Item;
            }
            if (BstTreeUtils.DigitBit(key, digit)) // current bit is 1
            {
                return SearchDstRecursive(tree.Right, key, digit + 1);
            }
            else // current bit is 0
            {
                return SearchDstRecursive(tree.Left, key, digit + 1);
            }
        }

        private static void InsertRecursive(ref BstItem tree, Item item, int digit)
        {
            if (tree == null)
            {
                tree = new BstItem(item);
                return;
            }
            if (BstTreeUtils.DigitBit(item.Key, digit)) // текущий бит ключа 1
            {
                InsertRecursive(ref tree.Right, item, digit+1);
            }
            else // текущий бит ключа 0
            {
                InsertRecursive(ref tree.Left, item, digit + 1);
            }
        }
    }
}
