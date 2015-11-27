using System;
using System.Threading;
using Search.Utils;

namespace Search
{
    /// <summary>
    /// в TST-дереве в каждом узле есть три ссылки: в одной дерево с ключами, где текущая цифра меньше, чем у текущего, в одной равна, в другой больше
    /// </summary>
    internal class TstSymbolTable : ISymbolTable
    {
        private TstItem root;

        public void Insert(Item item)
        {
            
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Item Search(int key)
        {
            throw new NotImplementedException();
        }

        public void Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public Item Select(int key)
        {
            throw new NotImplementedException();
        }

        private void InsertR(ref TstItem tree, int key, int d)
        {
            throw new NotImplementedException();
        }

        private Item SearchR(ref TstItem tree, int key, int d)
        {
            throw new NotImplementedException();
        }

        private class TstItem
        {
            public Item Item;

            public int d;

            public TstItem Left;

            public TstItem Center;

            public TstItem Right;
        }
    }
}
