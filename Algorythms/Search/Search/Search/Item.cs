using System;

namespace Search
{
    public class Item
    {
        private static readonly Item empty = new Item()
                                    {
                                        Key=-1,
                                        Value = "A"
                                    };

        public static Item Empty
        {
            get
            {
                return empty;
            }
        }

        public int Key
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }

        public static bool operator <(Item a, Item b)
        {
            return a.Key < b.Key;
        }

        public static bool operator >(Item a, Item b)
        {
            return a.Key > b.Key;
        }
    }
}
