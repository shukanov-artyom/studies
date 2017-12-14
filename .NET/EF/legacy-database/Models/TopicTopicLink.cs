using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TopicTopicLink
    {
        public int TopicId { get; set; }
        public int LinkToTopicId { get; set; }
        public int Order { get; set; }

        public Topic LinkToTopic { get; set; }
        public Topic Topic { get; set; }
    }
}
