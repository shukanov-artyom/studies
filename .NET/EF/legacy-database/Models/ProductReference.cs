using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductReference
    {
        public int ProductId { get; set; }
        public int ReferencedProductId { get; set; }

        public Product Product { get; set; }
        public Product ReferencedProduct { get; set; }
    }
}
