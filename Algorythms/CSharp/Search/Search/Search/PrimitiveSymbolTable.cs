using System;
using System.Collections.Generic;

namespace Search
{
    public class PrimitiveSymbolTable : ISymbolTable
    {
        private readonly List<Item> data = new List<Item>();

        public void Insert(Item item)
        {
            Item existing = Search(item.Key);
            if (existing != null)
            {
                data.Remove(existing);
            }
            data.Add(item);
        }

        public int Count()
        {
            return data.Count;
        }

        public Item Search(int key)
        {
            foreach (Item item in data)
            {
                if (item.Key == key)
                {
                    return item;
                }
            }
            return null;
        }

        public void Remove(Item item)
        {
            data.Remove(item);
        }

        public Item Select(int position)
        {
            return data[position];
        }
    }
}
