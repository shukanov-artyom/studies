using System;
using System.Collections.Generic;

namespace Search
{
    internal class DotNetDictionarySymbolTable : ISymbolTable
    {
        private readonly Dictionary<int, Item> dict = new Dictionary<int, Item>();

        public void Insert(Item item)
        {
            dict[item.Key] = item;
        }

        public int Count()
        {
            return dict.Count;
        }

        public Item Search(int key)
        {
            return dict[key];
        }

        public void Remove(Item item)
        {
            dict[item.Key] = null;
        }

        public Item Select(int key)
        {
            throw new NotSupportedException();
        }
    }
}
