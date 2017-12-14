using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductLinkedTopics
    {
        public int LinkId { get; set; }
        public int StudyPlanId { get; set; }
        public int TopicId { get; set; }
        public int Order { get; set; }
        public DateTime RecommendedDate { get; set; }
        public int? Day { get; set; }

        public StudyPlan StudyPlan { get; set; }
        public StudyPlanDay StudyPlanDay { get; set; }
        public Topic Topic { get; set; }
    }
}
