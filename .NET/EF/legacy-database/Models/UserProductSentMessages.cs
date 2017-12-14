using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserProductSentMessages
    {
        public int UserProductSentMessageId { get; set; }
        public int MessageSentId { get; set; }
        public int UserAndProductId { get; set; }

        public Message MessageSent { get; set; }
        public Userandproduct UserAndProduct { get; set; }
    }
}
