using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PaymentItems
    {
        public PaymentItems()
        {
            PaymentPrice = new HashSet<PaymentPrice>();
        }

        public string IdName { get; set; }
        public string DisplayName { get; set; }

        public ICollection<PaymentPrice> PaymentPrice { get; set; }
    }
}
