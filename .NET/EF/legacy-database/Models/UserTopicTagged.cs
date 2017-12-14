using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserTopicTagged
    {
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }

        public Topic Topic { get; set; }
        public Users User { get; set; }
    }
}
