using System;
using System.Collections.Generic;
using System.Linq;

namespace Search
{
    public class IndexedKeySymbolTable : ISymbolTable
    {
        // use List instead of raw array here.
        private readonly List<Item> data = new List<Item>();

        public IndexedKeySymbolTable(int maxN)
        {
            if (maxN < 1)
            {
                throw new Exception();
            }
            for (int i = 0; i < maxN+1; i++)
            {
                data.Add(Item.Empty);
            }
        }

        public void Insert(Item item)
        {
            data[item.Key] = item;
        }

        public int Count()
        {
            return data.Count(d => d != Item.Empty);
        }

        public Item Search(int key)
        {
            return data[key];
        }

        public void Remove(Item item)
        {
            data[item.Key] = Item.Empty;
        }

        public Item Select(int position)
        {
            return data[position];
        }
    }
}
