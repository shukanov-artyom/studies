using System;

namespace Search.Utils
{
    public class BstItem
    {
        private readonly Item item;

        public BstItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            this.item = item;
        }

        public Item Item
        {
            get
            {
                return item;
            }
        }

        public BstItem Left;

        public BstItem Right;
    }
}
