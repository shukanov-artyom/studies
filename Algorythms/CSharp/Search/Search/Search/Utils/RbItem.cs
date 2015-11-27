using System;

namespace Search.Utils
{
    public class RbItem
    {
        private readonly Item item;

        public RbItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            this.item = item;
        }

        public RbItem Left;

        public RbItem Right;

        public Item Item {
            get
            {
                return item;
            }
        }

        public bool IsRed
        {
            get;
            set;
        }
    }
}
