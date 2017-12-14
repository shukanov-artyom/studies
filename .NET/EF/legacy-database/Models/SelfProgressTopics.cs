using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class SelfProgressTopics
    {
        public int UserId { get; set; }
        public int TopicId { get; set; }
        public DateTime Timestamp { get; set; }
        public int Percentage { get; set; }

        public Topic Topic { get; set; }
        public Users User { get; set; }
    }
}
