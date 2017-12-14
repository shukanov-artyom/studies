using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PracticeSubscription
    {
        public int PracticeSubscriptionId { get; set; }
        public int PracticeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BillingUserId { get; set; }
        public int BillingContactDetailId { get; set; }
        public int BillingPhoneId { get; set; }
        public bool? PriceCharged { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public decimal? PaidAmmount { get; set; }

        public ContactDetail BillingContactDetail { get; set; }
        public Phone BillingPhone { get; set; }
        public Users BillingUser { get; set; }
        public Practice Practice { get; set; }
    }
}
