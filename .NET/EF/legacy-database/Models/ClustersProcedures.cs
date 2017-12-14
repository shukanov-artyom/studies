using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ClustersProcedures
    {
        public int ClusterProcedureId { get; set; }
        public int ClusterId { get; set; }
        public int ProcedureId { get; set; }
        public int Order { get; set; }
        public bool Active { get; set; }

        public Clusters Cluster { get; set; }
        public Procedure Procedure { get; set; }
    }
}
