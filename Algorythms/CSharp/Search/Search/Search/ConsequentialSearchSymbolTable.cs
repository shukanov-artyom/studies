using System;

namespace Search
{
    public class ConsequentialSearchSymbolTable : ISymbolTable
    {
        private readonly Item[] data;
        private int count;

        public ConsequentialSearchSymbolTable(int maxN)
        {
            data = new Item[maxN];
            count = 0;
        }

        public void Insert(Item item)
        {
            if (count == data.Length)
            {
                throw new Exception("overflow");
            }
            int i = count++;
            while (i > 0 && item < data[i - 1]) // проход сортировки вставками
            {
                data[i] = data[i - 1];
                i--;
            }
            data[i] = item;
        }

        public int Count()
        {
            return count;
        }

        public Item Search(int key)
        {
            foreach (Item item in data)
            {
                if (item.Key > key)
                {
                    return null; // не нашли, уже пошли большие, дальше искомого точно не будет
                }
                if (item.Key == key)
                {
                    return item;
                }
            }
            return null;
        }

        public void Remove(Item item)
        {
            for (int i = 0; i< data.Length; i++)
            {
                if (data[i].Key == item.Key)
                {
                    data[i] = Item.Empty;
                    return;
                }
            }
        }

        public Item Select(int key)
        {
            return data[key];
        }
    }
}
