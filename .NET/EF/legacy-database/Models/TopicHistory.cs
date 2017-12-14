using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TopicHistory
    {
        public int TopicHistoryId { get; set; }
        public int TopicId { get; set; }
        public string Text { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
