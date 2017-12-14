using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class RoleBucketAndPgy
    {
        public int PgyId { get; set; }
        public int RoleBucketId { get; set; }
        public double CompetencyStartLevel { get; set; }
        public string PgyYear { get; set; }
        public double? TclInitialIncrement { get; set; }
        public double? TclMidYearIncrement { get; set; }
        public int RoleBucketAndPgySchemeId { get; set; }
        public int? KnowledgeInitialLevel { get; set; }
        public int? KnowledgeMidYearLevel { get; set; }
        public int? PatientCareInitialLevel { get; set; }
        public int? PatientCareMidYearLevel { get; set; }

        public RoleBuckets RoleBucket { get; set; }
        public RoleBucketAndPgyScheme RoleBucketAndPgyScheme { get; set; }
    }
}
