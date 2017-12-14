using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductLinkedArticles
    {
        public int LinkId { get; set; }
        public int StudyPlanId { get; set; }
        public int Pmid { get; set; }
        public int Order { get; set; }
        public DateTime RecommendedDate { get; set; }
        public int? Day { get; set; }

        public StudyPlan StudyPlan { get; set; }
        public StudyPlanDay StudyPlanDay { get; set; }
    }
}
