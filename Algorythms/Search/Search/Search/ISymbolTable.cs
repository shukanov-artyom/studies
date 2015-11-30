using System;

namespace Search
{
    public interface ISymbolTable
    {
        void Insert(Item item);

        int Count();

        Item Search(int key);

        void Remove(Item item);

        Item Select(int key);
    }
}
