using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Userandproduct
    {
        public Userandproduct()
        {
            UserProductSentEmails = new HashSet<UserProductSentEmails>();
            UserProductSentMessages = new HashSet<UserProductSentMessages>();
        }

        public int Userandproductid { get; set; }
        public int? Productid { get; set; }
        public int Userid { get; set; }
        public DateTime? Invoicedate { get; set; }
        public DateTime? Paymentdate { get; set; }
        public string Paymentmethod { get; set; }
        public decimal? Paymentgross { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Comment { get; set; }
        public string TxnId { get; set; }
        public decimal? Paymentfee { get; set; }
        public string PayerEmail { get; set; }
        public string ParentTxnId { get; set; }

        public Product Product { get; set; }
        public Users User { get; set; }
        public ICollection<UserProductSentEmails> UserProductSentEmails { get; set; }
        public ICollection<UserProductSentMessages> UserProductSentMessages { get; set; }
    }
}
