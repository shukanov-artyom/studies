using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserProductSentEmails
    {
        public int UserProductSentEmailId { get; set; }
        public int EmailSentId { get; set; }
        public int UserAndProductId { get; set; }

        public EmailSent EmailSent { get; set; }
        public Userandproduct UserAndProduct { get; set; }
    }
}
