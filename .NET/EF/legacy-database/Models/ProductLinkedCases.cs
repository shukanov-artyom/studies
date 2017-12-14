using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductLinkedCases
    {
        public int LinkId { get; set; }
        public int StudyPlanId { get; set; }
        public int CaseId { get; set; }
        public int Order { get; set; }
        public DateTime RecommendedDate { get; set; }
        public int? Day { get; set; }

        public Case Case { get; set; }
        public StudyPlan StudyPlan { get; set; }
        public StudyPlanDay StudyPlanDay { get; set; }
    }
}
