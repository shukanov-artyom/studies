using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Group
    {
        public Group()
        {
            BiannualReport = new HashSet<BiannualReport>();
            CaseShareGroup = new HashSet<CaseShareGroup>();
            CategoryAttributes = new HashSet<CategoryAttributes>();
            CmeGroup = new HashSet<Cme>();
            CmeStudyPlanGroup = new HashSet<Cme>();
            Comment = new HashSet<Comment>();
            EmailSent = new HashSet<EmailSent>();
            GroupAndRole = new HashSet<GroupAndRole>();
            GroupAssociativityAssociatedGroup = new HashSet<GroupAssociativity>();
            GroupAssociativityGroup = new HashSet<GroupAssociativity>();
            GroupLocation = new HashSet<GroupLocation>();
            GroupSettingsAssigned = new HashSet<GroupSettingsAssigned>();
            GroupUserTestExamTypeSetting = new HashSet<GroupUserTestExamTypeSetting>();
            GroupsUserTests = new HashSet<GroupsUserTests>();
            MilestoneReports = new HashSet<MilestoneReports>();
            MyGroups = new HashSet<MyGroups>();
            MyGroupsAndCategories = new HashSet<MyGroupsAndCategories>();
            PassFacultyAndGroupLocations = new HashSet<PassFacultyAndGroupLocations>();
            PassNotification = new HashSet<PassNotification>();
            PassUserScores = new HashSet<PassUserScores>();
            PassuserAndCompetencyLevel = new HashSet<PassuserAndCompetencyLevel>();
            Post = new HashSet<Post>();
            PrimarySecondaryGroupPrimaryGroup = new HashSet<PrimarySecondaryGroup>();
            PrimarySecondaryGroupSecondaryGroup = new HashSet<PrimarySecondaryGroup>();
            ProcedureSkillActionHistory = new HashSet<ProcedureSkillActionHistory>();
            ProductAndGroupPermission = new HashSet<ProductAndGroupPermission>();
            StudyPlan = new HashSet<StudyPlan>();
            Video = new HashSet<Video>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? GroupType { get; set; }
        public string Guid { get; set; }
        public bool? PictureUploaded { get; set; }
        public int? GroupStatus { get; set; }
        public bool? IsDeleted { get; set; }
        public int? TopicId { get; set; }
        public string Products { get; set; }
        public int ModeratorId { get; set; }
        public int? ViewMembersStatus { get; set; }
        public int SkillUnlockingMode { get; set; }
        public int PassversionMode { get; set; }
        public int ChiefResidentAccessMode { get; set; }
        public int RoleBucketAndPgySchemeId { get; set; }
        public int QuestionsToCountOnReport { get; set; }
        public int EvalMasterStartEvaluationPeriod { get; set; }
        public int EvalMasterSubmitPeriod { get; set; }
        public int EvalMasterGradePeriod { get; set; }
        public int CalculationPriorLevelCriteria { get; set; }
        public int CalculationAchievedMinimumScore { get; set; }
        public int CalculationPartiallyAchievedMinScore { get; set; }
        public int CalculationCountLevelWithoutQuestions { get; set; }
        public int MilestoneDomainId { get; set; }
        public DateTime? OfficialStartDate { get; set; }
        public string GroupShortName { get; set; }
        public int? CountryNumericCode { get; set; }
        public int? CountryStateId { get; set; }
        public bool CheckExpireOn { get; set; }
        public int? CategoryTypeId { get; set; }
        public int GroupPassMseGradingSetting { get; set; }
        public int SubspecialtyId { get; set; }

        public CategoryType CategoryType { get; set; }
        public Country CountryNumericCodeNavigation { get; set; }
        public CountryState CountryState { get; set; }
        public RoleBucketAndPgyScheme RoleBucketAndPgyScheme { get; set; }
        public Subspecialty Subspecialty { get; set; }
        public ICollection<BiannualReport> BiannualReport { get; set; }
        public ICollection<CaseShareGroup> CaseShareGroup { get; set; }
        public ICollection<CategoryAttributes> CategoryAttributes { get; set; }
        public ICollection<Cme> CmeGroup { get; set; }
        public ICollection<Cme> CmeStudyPlanGroup { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<EmailSent> EmailSent { get; set; }
        public ICollection<GroupAndRole> GroupAndRole { get; set; }
        public ICollection<GroupAssociativity> GroupAssociativityAssociatedGroup { get; set; }
        public ICollection<GroupAssociativity> GroupAssociativityGroup { get; set; }
        public ICollection<GroupLocation> GroupLocation { get; set; }
        public ICollection<GroupSettingsAssigned> GroupSettingsAssigned { get; set; }
        public ICollection<GroupUserTestExamTypeSetting> GroupUserTestExamTypeSetting { get; set; }
        public ICollection<GroupsUserTests> GroupsUserTests { get; set; }
        public ICollection<MilestoneReports> MilestoneReports { get; set; }
        public ICollection<MyGroups> MyGroups { get; set; }
        public ICollection<MyGroupsAndCategories> MyGroupsAndCategories { get; set; }
        public ICollection<PassFacultyAndGroupLocations> PassFacultyAndGroupLocations { get; set; }
        public ICollection<PassNotification> PassNotification { get; set; }
        public ICollection<PassUserScores> PassUserScores { get; set; }
        public ICollection<PassuserAndCompetencyLevel> PassuserAndCompetencyLevel { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<PrimarySecondaryGroup> PrimarySecondaryGroupPrimaryGroup { get; set; }
        public ICollection<PrimarySecondaryGroup> PrimarySecondaryGroupSecondaryGroup { get; set; }
        public ICollection<ProcedureSkillActionHistory> ProcedureSkillActionHistory { get; set; }
        public ICollection<ProductAndGroupPermission> ProductAndGroupPermission { get; set; }
        public ICollection<StudyPlan> StudyPlan { get; set; }
        public ICollection<Video> Video { get; set; }
    }
}
