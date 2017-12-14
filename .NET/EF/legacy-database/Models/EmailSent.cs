using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class EmailSent
    {
        public EmailSent()
        {
            UserProductSentEmails = new HashSet<UserProductSentEmails>();
        }

        public int EmailSentId { get; set; }
        public string MessageType { get; set; }
        public DateTime Timestamp { get; set; }
        public int? GroupId { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }

        public Group Group { get; set; }
        public ICollection<UserProductSentEmails> UserProductSentEmails { get; set; }
    }
}
