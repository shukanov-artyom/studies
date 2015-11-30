using System;
using System.Collections.Generic;

namespace Search
{
    public class DotNetSortedDictionarySymbolTable : ISymbolTable
    {
        private readonly SortedDictionary<int, Item> dict =
            new SortedDictionary<int, Item>();

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
            dict.Remove(item.Key);
        }

        public Item Select(int key)
        {
            throw new Exception();
        }
    }
}
