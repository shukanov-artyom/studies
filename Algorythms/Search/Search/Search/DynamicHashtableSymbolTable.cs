using System;

namespace Search
{
    public class DynamicHashtableSymbolTable : ISymbolTable
    {
        private Item[] items;
        private int N = 0;
        private int M;
        private int maxN;

        public DynamicHashtableSymbolTable(int maxN)
        {
            M = 4;
            this.maxN = maxN;
            items = new Item[M];
        }

        public void Insert(Item item)
        {
            int position = Hash(item.Key);
            while (items[position] != null)
            {
                position = (position + 1)%M;
            }
            items[position] = item;
            if (N++ > M/2)
            {
                Expand();
            }
        }

        public Item Search(int key)
        {
            int position = Hash(key);
            while (items[position] != null)
            {
                if (items[position].Key == key)
                {
                    return items[position];
                }
                position = (position + 1) % M;
            }
            return null;
        }

        private void Expand()
        {
            Item[] oldArray = items;
            int oldM = M;
            M *= 2;
            N = 0;
            items = new Item[M];
            for (int i = 0; i < oldM; i++)
            {
                if (oldArray[i] != null)
                {
                    Insert(oldArray[i]);
                }
            }
        }

        private int Hash(int key)
        {
            return (int)(((double)key / (maxN + 1)) * M);
        }

        public int Count()
        {
            return N;
        }

        public void Remove(Item item)
        {
            int position = Hash(item.Key);
            while (items[position] != null)
            {
                if (items[position].Key == item.Key)
                {
                    while (items[position++] != null)
                    {
                        items[position - 1] = items[position];
                    }
                    items[position] = null;
                    N--;
                    break;
                }
                position = (position + 1) % M;
            }
            if (N < M/8)
            {
                Shrink();
            }
        }

        private void Shrink()
        {
            int oldN = N;
            N = 0;
            Item[] old = items;
            items = new Item[M / 2];
            M = M / 2;
            for (int i = 0; i < oldN; i++)
            {
                if (old[i] != null)
                {
                    Insert(old[i]);
                }
            }
        }

        public Item Select(int key)
        {
            throw new NotImplementedException();
        }
    }
}
