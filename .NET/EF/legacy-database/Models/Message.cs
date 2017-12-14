using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Message
    {
        public Message()
        {
            UserProductSentMessages = new HashSet<UserProductSentMessages>();
        }

        public int MessageId { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public int? FromUserId { get; set; }
        public int? ToUserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsRead { get; set; }
        public int? OriginalMessageId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? RemovedForFrom { get; set; }
        public bool? RemovedForTo { get; set; }

        public ICollection<UserProductSentMessages> UserProductSentMessages { get; set; }
    }
}
