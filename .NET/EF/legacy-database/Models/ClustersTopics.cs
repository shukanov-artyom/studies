using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ClustersTopics
    {
        public int ClustersTopicId { get; set; }
        public int ClusterId { get; set; }
        public int TopicId { get; set; }
        public int Order { get; set; }
        public bool? Active { get; set; }

        public Clusters Cluster { get; set; }
        public Topic Topic { get; set; }
    }
}
