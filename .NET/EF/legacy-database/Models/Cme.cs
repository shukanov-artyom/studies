using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Cme
    {
        public Cme()
        {
            CmeCertificate = new HashSet<CmeCertificate>();
            CmePostSurveyResults = new HashSet<CmePostSurveyResults>();
            ProductLinkedTests = new HashSet<ProductLinkedTests>();
        }

        public int CmeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? GroupId { get; set; }
        public double? Credits { get; set; }
        public int CmeCategoryId { get; set; }
        public string PostSurveyQuestion3Text { get; set; }
        public string PostSurveyQuestion9Text { get; set; }
        public string CmeProvider { get; set; }
        public string CmeProviderContactEmail { get; set; }
        public string PostTestCode { get; set; }
        public int? PostTestMinScorePercent { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? DependentTestsCountRequired { get; set; }
        public bool IsPostTestObligatory { get; set; }
        public double? MinHours { get; set; }
        public double? MaxHours { get; set; }
        public double? SaeCredits { get; set; }
        public int? VideoId { get; set; }
        public bool? IsSurveyObligatory { get; set; }
        public int? StudyPlanGroupId { get; set; }
        public int? EvidenceArticlesCount { get; set; }

        public CmeCategory CmeCategory { get; set; }
        public Group Group { get; set; }
        public UserTest PostTestCodeNavigation { get; set; }
        public Group StudyPlanGroup { get; set; }
        public Video Video { get; set; }
        public ICollection<CmeCertificate> CmeCertificate { get; set; }
        public ICollection<CmePostSurveyResults> CmePostSurveyResults { get; set; }
        public ICollection<ProductLinkedTests> ProductLinkedTests { get; set; }
    }
}
