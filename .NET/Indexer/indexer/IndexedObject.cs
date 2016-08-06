using System;
using System.Collections;
using System.Collections.Generic;

namespace indexer
{
    public class IndexedObject
    {
        private IDictionary<Index, int> map = 
            new Dictionary<Index, int>();

        public int this[Index index]
        {
            get
            {
                return map[index];
            }
            set
            {
                map[index] = value;
            }
        }
    }

    public class Index
    {
        protected string Name { get; private set; }

        public Index(string name)
        {
            Name = name;
        }

        public static Index PropertyOne = new Index("PropertyOne");

        public static Index PropertyTwo = new Index("PropertyTwo");

        public static Index PropertyThree = new Index("PropertyThree");

        public static Index PropertyFour = new Index("PropertyFour");
    }
}
