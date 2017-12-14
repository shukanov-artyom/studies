using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PaymentPrice
    {
        public string PaymentItemId { get; set; }
        public int UserRoleId { get; set; }
        public int PeriodId { get; set; }
        public double Price { get; set; }

        public PaymentItems PaymentItem { get; set; }
        public PaymentPeriods Period { get; set; }
    }
}
