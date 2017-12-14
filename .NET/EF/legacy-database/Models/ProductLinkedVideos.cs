using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductLinkedVideos
    {
        public int LinkId { get; set; }
        public int StudyPlanId { get; set; }
        public int VideoId { get; set; }
        public int Order { get; set; }
        public DateTime RecommendedDate { get; set; }
        public int? Day { get; set; }

        public StudyPlan StudyPlan { get; set; }
        public StudyPlanDay StudyPlanDay { get; set; }
        public Video Video { get; set; }
    }
}
