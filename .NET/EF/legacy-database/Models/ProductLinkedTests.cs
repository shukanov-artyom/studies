using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductLinkedTests
    {
        public int LinkId { get; set; }
        public int? CmeId { get; set; }
        public int? StudyPlanId { get; set; }
        public string TestCode { get; set; }
        public int TestOrder { get; set; }
        public bool IsRequired { get; set; }
        public int MinScore { get; set; }
        public DateTime? RecommendedDate { get; set; }
        public int? VideoId { get; set; }
        public int? Day { get; set; }

        public Cme Cme { get; set; }
        public StudyPlan StudyPlan { get; set; }
        public StudyPlanDay StudyPlanDay { get; set; }
        public UserTest TestCodeNavigation { get; set; }
        public Video Video { get; set; }
    }
}
