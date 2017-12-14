using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class StudyPlan
    {
        public StudyPlan()
        {
            ProductLinkedArticles = new HashSet<ProductLinkedArticles>();
            ProductLinkedCases = new HashSet<ProductLinkedCases>();
            ProductLinkedTests = new HashSet<ProductLinkedTests>();
            ProductLinkedTopics = new HashSet<ProductLinkedTopics>();
            ProductLinkedVideos = new HashSet<ProductLinkedVideos>();
            StudyPlanDay = new HashSet<StudyPlanDay>();
        }

        public int StudyPlanId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public int? GroupId { get; set; }
        public int? DependentTestsCountRequired { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? VideoId { get; set; }
        public int LengthInDays { get; set; }
        public int StudyPlanTypeId { get; set; }
        public int? StudyPlanSubTypeId { get; set; }
        public bool IsActiveStudyPlan { get; set; }

        public Group Group { get; set; }
        public StudyPlanSubTypes StudyPlanSubType { get; set; }
        public StudyPlanTypes StudyPlanType { get; set; }
        public Video Video { get; set; }
        public ICollection<ProductLinkedArticles> ProductLinkedArticles { get; set; }
        public ICollection<ProductLinkedCases> ProductLinkedCases { get; set; }
        public ICollection<ProductLinkedTests> ProductLinkedTests { get; set; }
        public ICollection<ProductLinkedTopics> ProductLinkedTopics { get; set; }
        public ICollection<ProductLinkedVideos> ProductLinkedVideos { get; set; }
        public ICollection<StudyPlanDay> StudyPlanDay { get; set; }
    }
}
