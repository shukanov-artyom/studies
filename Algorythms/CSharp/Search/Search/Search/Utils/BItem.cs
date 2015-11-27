using System;

namespace Search.Utils
{
    internal class BItem
    {
        private const int Mmax = 20;

        public BItem()
        {
            B = new BNode[Mmax];
            M = 0;
        }

        /// <summary>
        /// Счётчик активных 
        /// </summary>
        public int M
        {
            get;
            set;
        }

        public BNode[] B
        {
            get;
            set;
        }
    }

    internal class BNode
    {
        public int Key 
        {
            get;
            set;
        }

        public Item Item
        {
            get;
            set;
        }

        public BItem Next
        {
            get;
            set;
        }
    }
}
