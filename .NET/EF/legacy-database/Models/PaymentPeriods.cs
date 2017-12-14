using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PaymentPeriods
    {
        public PaymentPeriods()
        {
            PaymentPrice = new HashSet<PaymentPrice>();
        }

        public int Id { get; set; }
        public DateTime? ValidSince { get; set; }
        public DateTime? ValidTo { get; set; }
        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; }
        public ICollection<PaymentPrice> PaymentPrice { get; set; }
    }
}
