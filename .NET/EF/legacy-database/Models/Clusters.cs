using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Clusters
    {
        public Clusters()
        {
            BiannualReportKnowledgeRecord = new HashSet<BiannualReportKnowledgeRecord>();
            BiannualReportPatientCareRecord = new HashSet<BiannualReportPatientCareRecord>();
            ClustersProcedures = new HashSet<ClustersProcedures>();
            ClustersTopics = new HashSet<ClustersTopics>();
        }

        public int ClusterId { get; set; }
        public int DomainId { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }
        public bool? IsMilestone { get; set; }
        public int? CategoryId { get; set; }

        public Subspecialty Category { get; set; }
        public Domains Domain { get; set; }
        public ICollection<BiannualReportKnowledgeRecord> BiannualReportKnowledgeRecord { get; set; }
        public ICollection<BiannualReportPatientCareRecord> BiannualReportPatientCareRecord { get; set; }
        public ICollection<ClustersProcedures> ClustersProcedures { get; set; }
        public ICollection<ClustersTopics> ClustersTopics { get; set; }
    }
}
