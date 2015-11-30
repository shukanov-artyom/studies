using System;

namespace Search
{
    internal class ExtendibleHashingSymbolTable : ISymbolTable
    {
        private const int M = 20;

        private int n;
        private int d;
        private int D;

        private EhItem[] dir;

        public ExtendibleHashingSymbolTable()
        {
            D = 1;
            n = 0;
            d = 0;

            dir = new EhItem[D];
            dir[0] = new EhItem();
        }

        public void Insert(Item item)
        {
            throw new NotImplementedException();
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
            int dirIndex = Bits(key, d);
            foreach (Item item in dir[dirIndex].B)
            {
                if (item.Key == key)
                {
                    return item;
                }
            }
            return null;
        }

        private void Insert(EhItem h, Item x)
        {
            int j;
            int v = x.Key;
            for (j = 0; j < h.m; j++)
            {
                
            }
        }

        private class EhItem
        {
            public EhItem()
            {
                m = 0;
                k = 0;
                B = new Item[M];
            }

            public int m;

            public int k;

            public Item[] B;
        }

        private static int Bits(int key, int bits)
        {
            return key >> (32 - bits);
        }
    }
}
