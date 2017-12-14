using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Producttype
    {
        public Producttype()
        {
            Product = new HashSet<Product>();
        }

        public int Producttypeid { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
