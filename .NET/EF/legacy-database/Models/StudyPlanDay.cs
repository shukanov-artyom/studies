using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class StudyPlanDay
    {
        public StudyPlanDay()
        {
            ProductLinkedArticles = new HashSet<ProductLinkedArticles>();
            ProductLinkedCases = new HashSet<ProductLinkedCases>();
            ProductLinkedTests = new HashSet<ProductLinkedTests>();
            ProductLinkedTopics = new HashSet<ProductLinkedTopics>();
            ProductLinkedVideos = new HashSet<ProductLinkedVideos>();
        }

        public int StudyPlanId { get; set; }
        public int Day { get; set; }
        public int PrimarySpecialtyId { get; set; }
        public int? SecondarySpecialtyId { get; set; }
        public string IntroComment { get; set; }
        public string ClosingComment { get; set; }

        public Subspecialty PrimarySpecialty { get; set; }
        public Subspecialty SecondarySpecialty { get; set; }
        public StudyPlan StudyPlan { get; set; }
        public ICollection<ProductLinkedArticles> ProductLinkedArticles { get; set; }
        public ICollection<ProductLinkedCases> ProductLinkedCases { get; set; }
        public ICollection<ProductLinkedTests> ProductLinkedTests { get; set; }
        public ICollection<ProductLinkedTopics> ProductLinkedTopics { get; set; }
        public ICollection<ProductLinkedVideos> ProductLinkedVideos { get; set; }
    }
}
