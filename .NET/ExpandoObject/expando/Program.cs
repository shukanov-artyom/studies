using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace expando
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExpandoObject obj = new ExpandoObject();

            Fill(obj);
            ICollectionTest(obj);
        }

        private static void Fill(dynamic eo)
        {
            eo.City = "Mozyr";
            eo.Religion = "Christianity";
        }

        /// <summary>
        /// Working like with a usual collection, IEnumerable
        /// </summary>
        /// <param name="coll"></param>
        private static void ICollectionTest(ICollection<KeyValuePair<string, object>> coll)
        {
            coll.Add(new KeyValuePair<string, object>("Age", 23));
            int num = 0;
            var array = coll.Select(s => new
                {
                    NewKey = s.Key,
                    NewValue = s.Value,
                    Num = num++
                }).ToArray();
        }
    }
}
