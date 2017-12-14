using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Legacy.Models
{
    public partial class orthobulletsContext : DbContext
    {
        public virtual DbSet<AuthorsTeam> AuthorsTeam { get; set; }
        public virtual DbSet<BiannualReport> BiannualReport { get; set; }
        public virtual DbSet<BiannualReportData> BiannualReportData { get; set; }
        public virtual DbSet<BiannualReportKnowledgeRecord> BiannualReportKnowledgeRecord { get; set; }
        public virtual DbSet<BiannualReportPatientCareRecord> BiannualReportPatientCareRecord { get; set; }
        public virtual DbSet<BiannualReportPeriod> BiannualReportPeriod { get; set; }
        public virtual DbSet<BiannualReportPracticeRecord> BiannualReportPracticeRecord { get; set; }
        public virtual DbSet<BiannualReportUser> BiannualReportUser { get; set; }
        public virtual DbSet<Case> Case { get; set; }
        public virtual DbSet<CaseImage> CaseImage { get; set; }
        public virtual DbSet<CaseProcedure> CaseProcedure { get; set; }
        public virtual DbSet<CaseProcedureItemType> CaseProcedureItemType { get; set; }
        public virtual DbSet<CaseShare> CaseShare { get; set; }
        public virtual DbSet<CaseShareEmail> CaseShareEmail { get; set; }
        public virtual DbSet<CaseShareGroup> CaseShareGroup { get; set; }
        public virtual DbSet<CaseStatus> CaseStatus { get; set; }
        public virtual DbSet<CaseVideos> CaseVideos { get; set; }
        public virtual DbSet<CategoryAttributes> CategoryAttributes { get; set; }
        public virtual DbSet<CategoryType> CategoryType { get; set; }
        public virtual DbSet<Chapter> Chapter { get; set; }
        public virtual DbSet<Clusters> Clusters { get; set; }
        public virtual DbSet<ClustersProcedures> ClustersProcedures { get; set; }
        public virtual DbSet<ClustersTopics> ClustersTopics { get; set; }
        public virtual DbSet<Cme> Cme { get; set; }
        public virtual DbSet<CmeCategory> CmeCategory { get; set; }
        public virtual DbSet<CmeCertificate> CmeCertificate { get; set; }
        public virtual DbSet<CmePostSurveyResults> CmePostSurveyResults { get; set; }
        public virtual DbSet<ColleagueGroup> ColleagueGroup { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<CommentReview> CommentReview { get; set; }
        public virtual DbSet<ContactDetail> ContactDetail { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryState> CountryState { get; set; }
        public virtual DbSet<Domains> Domains { get; set; }
        public virtual DbSet<Efootprint> Efootprint { get; set; }
        public virtual DbSet<EfootprintContent> EfootprintContent { get; set; }
        public virtual DbSet<EfootprintContentType> EfootprintContentType { get; set; }
        public virtual DbSet<EfootprintRefs> EfootprintRefs { get; set; }
        public virtual DbSet<EmailBlackList> EmailBlackList { get; set; }
        public virtual DbSet<EmailNotificationFeature> EmailNotificationFeature { get; set; }
        public virtual DbSet<EmailSent> EmailSent { get; set; }
        public virtual DbSet<EvidenceType> EvidenceType { get; set; }
        public virtual DbSet<ExamAndPermission> ExamAndPermission { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Fellowship> Fellowship { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<Focus> Focus { get; set; }
        public virtual DbSet<Focusheading> Focusheading { get; set; }
        public virtual DbSet<FreePdfStatistics> FreePdfStatistics { get; set; }
        public virtual DbSet<FreePdfStatisticsPrecalculatedByDay> FreePdfStatisticsPrecalculatedByDay { get; set; }
        public virtual DbSet<FreePdfStatisticsPrecalculatedByMonth> FreePdfStatisticsPrecalculatedByMonth { get; set; }
        public virtual DbSet<FreePdfStatisticsPrecalculatedByWeek> FreePdfStatisticsPrecalculatedByWeek { get; set; }
        public virtual DbSet<FreePdfStatisticsPrecalculatedUsersByMonth> FreePdfStatisticsPrecalculatedUsersByMonth { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupAndRole> GroupAndRole { get; set; }
        public virtual DbSet<GroupAssociativity> GroupAssociativity { get; set; }
        public virtual DbSet<GroupFile> GroupFile { get; set; }
        public virtual DbSet<GroupInvite> GroupInvite { get; set; }
        public virtual DbSet<GroupLocation> GroupLocation { get; set; }
        public virtual DbSet<GroupQuestion> GroupQuestion { get; set; }
        public virtual DbSet<GroupSettings> GroupSettings { get; set; }
        public virtual DbSet<GroupSettingsAssigned> GroupSettingsAssigned { get; set; }
        public virtual DbSet<GroupSettingType> GroupSettingType { get; set; }
        public virtual DbSet<GroupsUserTests> GroupsUserTests { get; set; }
        public virtual DbSet<GroupUserTestExamTypeSetting> GroupUserTestExamTypeSetting { get; set; }
        public virtual DbSet<HomepageVideo> HomepageVideo { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<HospitalContactDetail> HospitalContactDetail { get; set; }
        public virtual DbSet<HospitalPhone> HospitalPhone { get; set; }
        public virtual DbSet<HospitalUser> HospitalUser { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Internship> Internship { get; set; }
        public virtual DbSet<ItemsItems> ItemsItems { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<JournalClub> JournalClub { get; set; }
        public virtual DbSet<LegalAgreement> LegalAgreement { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Listings> Listings { get; set; }
        public virtual DbSet<LoginHistory> LoginHistory { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<MedicalSchool> MedicalSchool { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MilestoneReportRecords> MilestoneReportRecords { get; set; }
        public virtual DbSet<MilestoneReports> MilestoneReports { get; set; }
        public virtual DbSet<MinimumRequirements> MinimumRequirements { get; set; }
        public virtual DbSet<MonthlyPattern> MonthlyPattern { get; set; }
        public virtual DbSet<MyGroups> MyGroups { get; set; }
        public virtual DbSet<MyGroupsAndCategories> MyGroupsAndCategories { get; set; }
        public virtual DbSet<NotificationTemplate> NotificationTemplate { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<OfficeContactDetail> OfficeContactDetail { get; set; }
        public virtual DbSet<OfficePhone> OfficePhone { get; set; }
        public virtual DbSet<OfficeUser> OfficeUser { get; set; }
        public virtual DbSet<PartnershipTracks> PartnershipTracks { get; set; }
        public virtual DbSet<PassFacultyAndGroupLocations> PassFacultyAndGroupLocations { get; set; }
        public virtual DbSet<PassGroupDefaultTest> PassGroupDefaultTest { get; set; }
        public virtual DbSet<PassNotification> PassNotification { get; set; }
        public virtual DbSet<PassProfEval> PassProfEval { get; set; }
        public virtual DbSet<PassProfEvalScoreHint> PassProfEvalScoreHint { get; set; }
        public virtual DbSet<PassProfScore> PassProfScore { get; set; }
        public virtual DbSet<PassuserAndCompetencyLevel> PassuserAndCompetencyLevel { get; set; }
        public virtual DbSet<PassUserScores> PassUserScores { get; set; }
        public virtual DbSet<PassUserScoresItems> PassUserScoresItems { get; set; }
        public virtual DbSet<PaymentItems> PaymentItems { get; set; }
        public virtual DbSet<PaymentPeriods> PaymentPeriods { get; set; }
        public virtual DbSet<PaymentPrice> PaymentPrice { get; set; }
        public virtual DbSet<Paymenttransactionlog> Paymenttransactionlog { get; set; }
        public virtual DbSet<PdfLicense> PdfLicense { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionTier> PermissionTier { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<Poll> Poll { get; set; }
        public virtual DbSet<PollResult> PollResult { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostNote> PostNote { get; set; }
        public virtual DbSet<PostNoteFile> PostNoteFile { get; set; }
        public virtual DbSet<Practice> Practice { get; set; }
        public virtual DbSet<PracticeContactDetail> PracticeContactDetail { get; set; }
        public virtual DbSet<PracticeMedia> PracticeMedia { get; set; }
        public virtual DbSet<PracticeOffice> PracticeOffice { get; set; }
        public virtual DbSet<PracticePhone> PracticePhone { get; set; }
        public virtual DbSet<PracticeSubscription> PracticeSubscription { get; set; }
        public virtual DbSet<PracticeSubspecialty> PracticeSubspecialty { get; set; }
        public virtual DbSet<PracticeSubspecialtyUser> PracticeSubspecialtyUser { get; set; }
        public virtual DbSet<PracticeTestmonial> PracticeTestmonial { get; set; }
        public virtual DbSet<PracticeTypes> PracticeTypes { get; set; }
        public virtual DbSet<PreComputedValue> PreComputedValue { get; set; }
        public virtual DbSet<PrimarySecondaryGroup> PrimarySecondaryGroup { get; set; }
        public virtual DbSet<Procedure> Procedure { get; set; }
        public virtual DbSet<ProcedureBullet> ProcedureBullet { get; set; }
        public virtual DbSet<ProcedureComplexity> ProcedureComplexity { get; set; }
        public virtual DbSet<ProcedureSkill> ProcedureSkill { get; set; }
        public virtual DbSet<ProcedureSkillActionHistory> ProcedureSkillActionHistory { get; set; }
        public virtual DbSet<ProcedureSkillApprovalState> ProcedureSkillApprovalState { get; set; }
        public virtual DbSet<ProcedureSkillStep> ProcedureSkillStep { get; set; }
        public virtual DbSet<ProcedureSkillStepChapter> ProcedureSkillStepChapter { get; set; }
        public virtual DbSet<ProcedureSkillStepEvidence> ProcedureSkillStepEvidence { get; set; }
        public virtual DbSet<ProcedureSkillStepNote> ProcedureSkillStepNote { get; set; }
        public virtual DbSet<ProcedureSkillStepNoteFile> ProcedureSkillStepNoteFile { get; set; }
        public virtual DbSet<ProcedureSkillStepPearl> ProcedureSkillStepPearl { get; set; }
        public virtual DbSet<ProcedureSkillStepPitfall> ProcedureSkillStepPitfall { get; set; }
        public virtual DbSet<ProcedureSkillStepProgress> ProcedureSkillStepProgress { get; set; }
        public virtual DbSet<ProcedureSkillStepTagged> ProcedureSkillStepTagged { get; set; }
        public virtual DbSet<ProcedureSkillTest> ProcedureSkillTest { get; set; }
        public virtual DbSet<ProcedureSkillUserAction> ProcedureSkillUserAction { get; set; }
        public virtual DbSet<ProcedureSkillUserActionType> ProcedureSkillUserActionType { get; set; }
        public virtual DbSet<ProcedureSkillVideo> ProcedureSkillVideo { get; set; }
        public virtual DbSet<ProcedureStep> ProcedureStep { get; set; }
        public virtual DbSet<ProcedureStepLevel> ProcedureStepLevel { get; set; }
        public virtual DbSet<ProcedureValidationEvidence> ProcedureValidationEvidence { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAndGroupPermission> ProductAndGroupPermission { get; set; }
        public virtual DbSet<ProductAndRole> ProductAndRole { get; set; }
        public virtual DbSet<ProductAndTestQuestionFlagPermission> ProductAndTestQuestionFlagPermission { get; set; }
        public virtual DbSet<ProductAndUserTestPermission> ProductAndUserTestPermission { get; set; }
        public virtual DbSet<ProductAndVideoCategoryTypePermission> ProductAndVideoCategoryTypePermission { get; set; }
        public virtual DbSet<ProductAndVideoPermission> ProductAndVideoPermission { get; set; }
        public virtual DbSet<ProductLinkedArticles> ProductLinkedArticles { get; set; }
        public virtual DbSet<ProductLinkedCases> ProductLinkedCases { get; set; }
        public virtual DbSet<ProductLinkedTests> ProductLinkedTests { get; set; }
        public virtual DbSet<ProductLinkedTopics> ProductLinkedTopics { get; set; }
        public virtual DbSet<ProductLinkedVideos> ProductLinkedVideos { get; set; }
        public virtual DbSet<ProductReference> ProductReference { get; set; }
        public virtual DbSet<Producttype> Producttype { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<QuestionHistory> QuestionHistory { get; set; }
        public virtual DbSet<QuestionSourceCategory> QuestionSourceCategory { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Residency> Residency { get; set; }
        public virtual DbSet<ReviewModeSlides> ReviewModeSlides { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleAndPermission> RoleAndPermission { get; set; }
        public virtual DbSet<RoleBucketAndPgy> RoleBucketAndPgy { get; set; }
        public virtual DbSet<RoleBucketAndPgyScheme> RoleBucketAndPgyScheme { get; set; }
        public virtual DbSet<RoleBuckets> RoleBuckets { get; set; }
        public virtual DbSet<SelfProgressArticles> SelfProgressArticles { get; set; }
        public virtual DbSet<SelfProgressQuestions> SelfProgressQuestions { get; set; }
        public virtual DbSet<SelfProgressTopics> SelfProgressTopics { get; set; }
        public virtual DbSet<SelfProgressVideo> SelfProgressVideo { get; set; }
        public virtual DbSet<SkippedItems> SkippedItems { get; set; }
        public virtual DbSet<Specialty> Specialty { get; set; }
        public virtual DbSet<StudyPlan> StudyPlan { get; set; }
        public virtual DbSet<StudyPlanDay> StudyPlanDay { get; set; }
        public virtual DbSet<StudyPlanSubTypes> StudyPlanSubTypes { get; set; }
        public virtual DbSet<StudyPlanTypes> StudyPlanTypes { get; set; }
        public virtual DbSet<SubspecialityNeeded> SubspecialityNeeded { get; set; }
        public virtual DbSet<Subspecialty> Subspecialty { get; set; }
        public virtual DbSet<TechniqueMap> TechniqueMap { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Testmonial> Testmonial { get; set; }
        public virtual DbSet<TestQuestion> TestQuestion { get; set; }
        public virtual DbSet<TestQuestionFlag> TestQuestionFlag { get; set; }
        public virtual DbSet<TestQuestionFlagAndPermission> TestQuestionFlagAndPermission { get; set; }
        public virtual DbSet<TestQuestionFlagLog> TestQuestionFlagLog { get; set; }
        public virtual DbSet<TestQuestionLevelHistory> TestQuestionLevelHistory { get; set; }
        public virtual DbSet<TestQuestionNote> TestQuestionNote { get; set; }
        public virtual DbSet<TestQuestionNoteFile> TestQuestionNoteFile { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<TopicHistory> TopicHistory { get; set; }
        public virtual DbSet<TopicNote> TopicNote { get; set; }
        public virtual DbSet<TopicNoteFile> TopicNoteFile { get; set; }
        public virtual DbSet<TopicPassPeakSummary> TopicPassPeakSummary { get; set; }
        public virtual DbSet<TopicSection> TopicSection { get; set; }
        public virtual DbSet<TopicTopicLink> TopicTopicLink { get; set; }
        public virtual DbSet<TraumaLevels> TraumaLevels { get; set; }
        public virtual DbSet<University> University { get; set; }
        public virtual DbSet<UploadFileType> UploadFileType { get; set; }
        public virtual DbSet<UsaState> UsaState { get; set; }
        public virtual DbSet<UserAndDisabledQuestionCriteria> UserAndDisabledQuestionCriteria { get; set; }
        public virtual DbSet<UserAndEliminatedAnswer> UserAndEliminatedAnswer { get; set; }
        public virtual DbSet<Userandproduct> Userandproduct { get; set; }
        public virtual DbSet<UserAndRole> UserAndRole { get; set; }
        public virtual DbSet<UserArticleTagged> UserArticleTagged { get; set; }
        public virtual DbSet<UserCaseTagged> UserCaseTagged { get; set; }
        public virtual DbSet<UserCommentSubscriptions> UserCommentSubscriptions { get; set; }
        public virtual DbSet<UserFeatureEmailNotifications> UserFeatureEmailNotifications { get; set; }
        public virtual DbSet<UserFellowship> UserFellowship { get; set; }
        public virtual DbSet<UserInternship> UserInternship { get; set; }
        public virtual DbSet<UserMedia> UserMedia { get; set; }
        public virtual DbSet<UserMedicalSchool> UserMedicalSchool { get; set; }
        public virtual DbSet<UserNotification> UserNotification { get; set; }
        public virtual DbSet<UserProcedure> UserProcedure { get; set; }
        public virtual DbSet<UserProductSentEmails> UserProductSentEmails { get; set; }
        public virtual DbSet<UserProductSentMessages> UserProductSentMessages { get; set; }
        public virtual DbSet<UserProfileInfo> UserProfileInfo { get; set; }
        public virtual DbSet<UserPublication> UserPublication { get; set; }
        public virtual DbSet<UserResidency> UserResidency { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersAndWebsite> UsersAndWebsite { get; set; }
        public virtual DbSet<UsersInFaculties> UsersInFaculties { get; set; }
        public virtual DbSet<UserSiteSettings> UserSiteSettings { get; set; }
        public virtual DbSet<UserTest> UserTest { get; set; }
        public virtual DbSet<UserTestExamType> UserTestExamType { get; set; }
        public virtual DbSet<UserTestmonial> UserTestmonial { get; set; }
        public virtual DbSet<UserTestQuestion> UserTestQuestion { get; set; }
        public virtual DbSet<UserTestQuestionTagged> UserTestQuestionTagged { get; set; }
        public virtual DbSet<UserTestQuestionTaken> UserTestQuestionTaken { get; set; }
        public virtual DbSet<UserTestQuestionTakenCalculated> UserTestQuestionTakenCalculated { get; set; }
        public virtual DbSet<UserTestResults> UserTestResults { get; set; }
        public virtual DbSet<UserTopicTagged> UserTopicTagged { get; set; }
        public virtual DbSet<UserUniversity> UserUniversity { get; set; }
        public virtual DbSet<UserVideoTagged> UserVideoTagged { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<VideoPresenter> VideoPresenter { get; set; }
        public virtual DbSet<VideoQuestionTimeStamp> VideoQuestionTimeStamp { get; set; }
        public virtual DbSet<VideoTestSection> VideoTestSection { get; set; }
        public virtual DbSet<Website> Website { get; set; }
        public virtual DbSet<WeeklyPattern> WeeklyPattern { get; set; }

        // Unable to generate entity type for table 'orthobullets.Comment_01_22_2016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction05192017'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transactions10262016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.paypal_match'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserLocation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.paypal_match2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.paypal_match3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MyColleages'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductAndFeaturePermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction11012016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pp_match'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pp_match2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pp_match3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sjctmp1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WhiteEmailList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pp_match4'. Please see the warning messages.
        // Unable to generate entity type for table 'orthobullets.CommentInboxDeleted'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PaymentCaptureLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction11042016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LegalAgreementAcceptance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction11072016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mygroups_deleted_20161107'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mygroups_history'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.users_bak_20160407'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UserCommentSubscription_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction03302017'. Please see the warning messages.
        // Unable to generate entity type for table 'orthobullets.QuestionsToInsert'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProcedureSkillActionHistory_09_15_2015'. Please see the warning messages.
        // Unable to generate entity type for table 'orthobullets.Payment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CmeDependentTests'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CmePostSurveyResults_user_18863'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProcedureEvidenceType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.selectedgroups2015_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.selectedgroups2015_tmp_b'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.groupandprice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.expired_10172016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.expiredanddeleted_10172016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.userandproduct_history'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mygroups_bak_20161017'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction12212016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction02132017'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.presult_sjc_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.expired_10172016_a_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.expired_10172016_a'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UsersInBuckets'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mygroups_deleted_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PassUserScores_01052016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AssignedGroupRoles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_970'. Please see the warning messages.
        // Unable to generate entity type for table 'pass.BiannualReport_01_12_2016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_970_3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction10262016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ProductAndGroupCategoryTypePermission'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SubCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.transaction04102017'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=orthobullets;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorsTeam>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SpecialtyId });

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.AuthorsTeam)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorsTeam_Subspecialty");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthorsTeam)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorsTeam_Users");
            });

            modelBuilder.Entity<BiannualReport>(entity =>
            {
                entity.ToTable("BiannualReport", "pass");

                entity.Property(e => e.ReportTitle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.BiannualReport)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReport_Group");
            });

            modelBuilder.Entity<BiannualReportData>(entity =>
            {
                entity.ToTable("BiannualReportData", "pass");

                entity.HasIndex(e => new { e.BiannualReportId, e.UserId })
                    .HasName("IX_BiannualReportData")
                    .IsUnique();

                entity.Property(e => e.MedicalKnowledgeDomainModelJsonVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.MilestoneCommentsModelJsonVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.MilestoneMedicalKnowlengeDomainModelJson).IsRequired();

                entity.Property(e => e.MilestonePatientCareDomainModelJson).IsRequired();

                entity.Property(e => e.MilestonePatientCareDomainModelJsonVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.MilestoneProfessionalismModelJson).IsRequired();

                entity.Property(e => e.MilestoneProfessionalismModelJsonVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportUserBoxJson).IsRequired();

                entity.Property(e => e.ReportUserBoxJsonVersion).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.BiannualReport)
                    .WithMany(p => p.BiannualReportData)
                    .HasForeignKey(d => d.BiannualReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportData_BiannualReport");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BiannualReportData)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportData_Users");
            });

            modelBuilder.Entity<BiannualReportKnowledgeRecord>(entity =>
            {
                entity.ToTable("BiannualReportKnowledgeRecord", "pass");

                entity.HasIndex(e => new { e.BiannualReportId, e.UserId, e.ClusterId })
                    .HasName("IX_BiannualReportKnowledgeRecord")
                    .IsUnique();

                entity.Property(e => e.AcceptedLevel).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.OverriddenLevel).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.BiannualReport)
                    .WithMany(p => p.BiannualReportKnowledgeRecord)
                    .HasForeignKey(d => d.BiannualReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportKnowledgeRecord_BiannualReport");

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.BiannualReportKnowledgeRecord)
                    .HasForeignKey(d => d.ClusterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportKnowledgeRecord_Clusters");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BiannualReportKnowledgeRecord)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportKnowledgeRecord_Users");
            });

            modelBuilder.Entity<BiannualReportPatientCareRecord>(entity =>
            {
                entity.ToTable("BiannualReportPatientCareRecord", "pass");

                entity.HasIndex(e => new { e.BiannualReportId, e.UserId, e.ClusterId })
                    .HasName("IX_BiannualReportPatientCareRecord")
                    .IsUnique();

                entity.Property(e => e.AcceptedLevel).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.OverriddenLevel).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.BiannualReport)
                    .WithMany(p => p.BiannualReportPatientCareRecord)
                    .HasForeignKey(d => d.BiannualReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportPatientCareRecord_BiannualReport");

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.BiannualReportPatientCareRecord)
                    .HasForeignKey(d => d.ClusterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportPatientCareRecord_Clusters");
            });

            modelBuilder.Entity<BiannualReportPeriod>(entity =>
            {
                entity.ToTable("BiannualReportPeriod", "pass");

                entity.Property(e => e.PeriodTitle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BiannualReportPracticeRecord>(entity =>
            {
                entity.ToTable("BiannualReportPracticeRecord", "pass");

                entity.HasIndex(e => new { e.BiannualReportId, e.UserId, e.PassProfEvalId })
                    .HasName("IX_BiannualReportPracticeRecord")
                    .IsUnique();

                entity.Property(e => e.AcceptedLevel).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.OverriddenLevel).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.BiannualReport)
                    .WithMany(p => p.BiannualReportPracticeRecord)
                    .HasForeignKey(d => d.BiannualReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportPracticeRecord_BiannualReport");

                entity.HasOne(d => d.PassProfEval)
                    .WithMany(p => p.BiannualReportPracticeRecord)
                    .HasForeignKey(d => d.PassProfEvalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportPracticeRecord_PassProfEval");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BiannualReportPracticeRecord)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportPracticeRecord_Users");
            });

            modelBuilder.Entity<BiannualReportUser>(entity =>
            {
                entity.ToTable("BiannualReportUser", "pass");

                entity.HasIndex(e => new { e.BiannualReportId, e.UserId })
                    .HasName("IX_BiannualReportUser")
                    .IsUnique();

                entity.Property(e => e.GradeLevel).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.BiannualReport)
                    .WithMany(p => p.BiannualReportUser)
                    .HasForeignKey(d => d.BiannualReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportUser_BiannualReport");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BiannualReportUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiannualReportUser_Users");
            });

            modelBuilder.Entity<Case>(entity =>
            {
                entity.ToTable("Case", "orthobullets");

                entity.HasIndex(e => e.CaseGuid)
                    .HasName("IX_CaseGUID")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ShareWith);

                entity.HasIndex(e => e.SurgeryPending);

                entity.HasIndex(e => e.TopicId);

                entity.HasIndex(e => new { e.CreatedOn, e.CaseStatusId, e.IsDeleted, e.CaseId, e.TopicId })
                    .HasName("_dta_index_Case_CreatedOn_CaseStatusId_IsDeleted_CaseID_TopicID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseGuid)
                    .IsRequired()
                    .HasColumnName("CaseGUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseStatusDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CaseStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ChiefComplaint).HasMaxLength(250);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfSurgery).HasColumnType("smalldatetime");

                entity.Property(e => e.DateOfSurgery2).HasColumnType("smalldatetime");

                entity.Property(e => e.DateOfSurgery3).HasColumnType("smalldatetime");

                entity.Property(e => e.Diagnosis).HasMaxLength(2500);

                entity.Property(e => e.Hpi)
                    .HasColumnName("HPI")
                    .HasMaxLength(2500);

                entity.Property(e => e.MedicalHistory).HasMaxLength(2500);

                entity.Property(e => e.OperationPerformed).HasMaxLength(500);

                entity.Property(e => e.OperationPerformed2).HasMaxLength(500);

                entity.Property(e => e.OperationPerformed3).HasMaxLength(500);

                entity.Property(e => e.Outcome).HasMaxLength(500);

                entity.Property(e => e.PatientId)
                    .HasColumnName("PatientID")
                    .HasMaxLength(50);

                entity.Property(e => e.PhysicalExam).HasMaxLength(2500);

                entity.Property(e => e.Question).HasMaxLength(2500);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SharedOn).HasColumnType("datetime");

                entity.Property(e => e.SurgeryPending).HasDefaultValueSql("((1))");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.HasOne(d => d.CaseStatus)
                    .WithMany(p => p.Case)
                    .HasForeignKey(d => d.CaseStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Case_CaseStatus");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CaseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Case_Users");

                entity.HasOne(d => d.Proctor)
                    .WithMany(p => p.CaseProctor)
                    .HasForeignKey(d => d.ProctorId)
                    .HasConstraintName("FK_Case_Users1");

                entity.HasOne(d => d.QuestionNavigation)
                    .WithMany(p => p.Case)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Case_TestQuestion");

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.Case)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Case_Subspecialty");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Case)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_Case_Topic");
            });

            modelBuilder.Entity<CaseImage>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.HasIndex(e => e.CaseId);

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CaseProcedureItemTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageDate).HasColumnType("datetime");

                entity.Property(e => e.ImageType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseImage)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_CaseImage_Case");

                entity.HasOne(d => d.CaseProcedure)
                    .WithMany(p => p.CaseImage)
                    .HasForeignKey(d => d.CaseProcedureId)
                    .HasConstraintName("FK_CaseImage_CaseProcedure");

                entity.HasOne(d => d.CaseProcedureItemType)
                    .WithMany(p => p.CaseImage)
                    .HasForeignKey(d => d.CaseProcedureItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseImage_CaseProcedureItemType");
            });

            modelBuilder.Entity<CaseProcedure>(entity =>
            {
                entity.ToTable("CaseProcedure", "orthobullets");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfSurgery).HasColumnType("date");

                entity.Property(e => e.OperationPerformed)
                    .IsRequired()
                    .HasMaxLength(2500);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseProcedure)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseProcedure_Case");
            });

            modelBuilder.Entity<CaseProcedureItemType>(entity =>
            {
                entity.ToTable("CaseProcedureItemType", "orthobullets");

                entity.Property(e => e.CaseProcedureItemTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CaseShare>(entity =>
            {
                entity.ToTable("CaseShare", "orthobullets");

                entity.HasIndex(e => new { e.CaseGuid, e.ToUserId })
                    .HasName("IX_CaseShare")
                    .IsUnique();

                entity.Property(e => e.CaseShareId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CaseGuid)
                    .IsRequired()
                    .HasColumnName("CaseGUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SharedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.HasOne(d => d.CaseGu)
                    .WithMany(p => p.CaseShare)
                    .HasPrincipalKey(p => p.CaseGuid)
                    .HasForeignKey(d => d.CaseGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseShare_Case");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.CaseShare)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseShare_Users");
            });

            modelBuilder.Entity<CaseShareEmail>(entity =>
            {
                entity.ToTable("CaseShareEmail", "orthobullets");

                entity.HasIndex(e => e.CaseGuid)
                    .HasName("IX_CaseShareEmail");

                entity.Property(e => e.CaseShareEmailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CaseGuid)
                    .HasColumnName("CaseGUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SharedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CaseGu)
                    .WithMany(p => p.CaseShareEmail)
                    .HasPrincipalKey(p => p.CaseGuid)
                    .HasForeignKey(d => d.CaseGuid)
                    .HasConstraintName("FK_CaseShareEmail_Case");
            });

            modelBuilder.Entity<CaseShareGroup>(entity =>
            {
                entity.HasIndex(e => e.GroupId);

                entity.Property(e => e.CaseGuid)
                    .HasColumnName("CaseGUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.SharedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CaseGu)
                    .WithMany(p => p.CaseShareGroup)
                    .HasPrincipalKey(p => p.CaseGuid)
                    .HasForeignKey(d => d.CaseGuid)
                    .HasConstraintName("FK_CaseShareGroup_Case");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CaseShareGroup)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_CaseShareGroup_Group");
            });

            modelBuilder.Entity<CaseStatus>(entity =>
            {
                entity.ToTable("CaseStatus", "orthobullets");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CaseVideos>(entity =>
            {
                entity.HasKey(e => e.CaseVideoId);

                entity.ToTable("CaseVideos", "orthobullets");

                entity.Property(e => e.CaseProcedureItemTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Comments).HasMaxLength(4000);

                entity.Property(e => e.ConvertedFilename)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertedVideoThumbUrl)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Operation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalFilename)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.VideoDate).HasColumnType("datetime");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.CaseVideos)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseVideos_Case");

                entity.HasOne(d => d.CaseProcedure)
                    .WithMany(p => p.CaseVideos)
                    .HasForeignKey(d => d.CaseProcedureId)
                    .HasConstraintName("FK_CaseVideos_CaseProcedure");

                entity.HasOne(d => d.CaseProcedureItemType)
                    .WithMany(p => p.CaseVideos)
                    .HasForeignKey(d => d.CaseProcedureItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseVideos_CaseProcedureItemType");
            });

            modelBuilder.Entity<CategoryAttributes>(entity =>
            {
                entity.HasKey(e => e.CategoryAttributeId);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Position).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResidencyCompletionTargetDate).HasColumnType("date");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CategoryAttributes)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryAttributes_Group");
            });

            modelBuilder.Entity<CategoryType>(entity =>
            {
                entity.Property(e => e.CategoryTypeName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.IsForCase).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsForGroup).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsForPost).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsForVideo).HasDefaultValueSql("((1))");

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.CategoryType)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryType_Specialty");
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sortorder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Chapter)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chapter_Field");
            });

            modelBuilder.Entity<Clusters>(entity =>
            {
                entity.HasKey(e => e.ClusterId);

                entity.ToTable("Clusters", "pass");

                entity.Property(e => e.IsMilestone).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Clusters)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Clusters_Subspecialty");

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.Clusters)
                    .HasForeignKey(d => d.DomainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clusters_Domains");
            });

            modelBuilder.Entity<ClustersProcedures>(entity =>
            {
                entity.HasKey(e => new { e.ClusterId, e.ProcedureId });

                entity.ToTable("ClustersProcedures", "pass");

                entity.Property(e => e.ClusterProcedureId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.ClustersProcedures)
                    .HasForeignKey(d => d.ClusterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClustersProcedures_Clusters");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ClustersProcedures)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClustersProcedures_Procedure");
            });

            modelBuilder.Entity<ClustersTopics>(entity =>
            {
                entity.HasKey(e => new { e.ClusterId, e.TopicId });

                entity.ToTable("ClustersTopics", "pass");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClustersTopicId).ValueGeneratedOnAdd();

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Cluster)
                    .WithMany(p => p.ClustersTopics)
                    .HasForeignKey(d => d.ClusterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClustersTopics_Clusters");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.ClustersTopics)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClustersTopics_Topic");
            });

            modelBuilder.Entity<Cme>(entity =>
            {
                entity.Property(e => e.CmeProvider).HasMaxLength(100);

                entity.Property(e => e.CmeProviderContactEmail).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsSurveyObligatory).HasDefaultValueSql("((1))");

                entity.Property(e => e.PostSurveyQuestion3Text).HasMaxLength(2000);

                entity.Property(e => e.PostSurveyQuestion9Text).HasMaxLength(2000);

                entity.Property(e => e.PostTestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.CmeCategory)
                    .WithMany(p => p.Cme)
                    .HasForeignKey(d => d.CmeCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cme_CmeCategory");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CmeGroup)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Cme_Group");

                entity.HasOne(d => d.PostTestCodeNavigation)
                    .WithMany(p => p.Cme)
                    .HasForeignKey(d => d.PostTestCode)
                    .HasConstraintName("FK_Cme_UserTest");

                entity.HasOne(d => d.StudyPlanGroup)
                    .WithMany(p => p.CmeStudyPlanGroup)
                    .HasForeignKey(d => d.StudyPlanGroupId)
                    .HasConstraintName("FK_Cme_Group2");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.Cme)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_Cme_Video");
            });

            modelBuilder.Entity<CmeCategory>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<CmeCertificate>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Filename).HasMaxLength(500);

                entity.HasOne(d => d.Cme)
                    .WithMany(p => p.CmeCertificate)
                    .HasForeignKey(d => d.CmeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CmeCertificate_Cme");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmeCertificate)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CmeCertificate_User");
            });

            modelBuilder.Entity<CmePostSurveyResults>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CmeId });

                entity.Property(e => e.ChangePracticeComment).HasMaxLength(300);

                entity.Property(e => e.CommercialBiasComment).HasMaxLength(300);

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.ContactDegree).HasMaxLength(200);

                entity.Property(e => e.ContactName).HasMaxLength(200);

                entity.Property(e => e.ObjectiveComment).HasMaxLength(300);

                entity.Property(e => e.PersonalGoalComment).HasMaxLength(300);

                entity.Property(e => e.SatisfactionComment).HasMaxLength(300);

                entity.HasOne(d => d.Cme)
                    .WithMany(p => p.CmePostSurveyResults)
                    .HasForeignKey(d => d.CmeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CmePostSurveyResults_Cme");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmePostSurveyResults)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CmePostSurveyResults_Users");
            });

            modelBuilder.Entity<ColleagueGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ColleagueGroup1 });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ColleagueGroup1)
                    .HasColumnName("ColleagueGroup")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ColleagueGroup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ColleagueGroup_Users");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment", "orthobullets");

                entity.HasIndex(e => e.CaseId);

                entity.HasIndex(e => e.GroupId);

                entity.HasIndex(e => e.PostId);

                entity.HasIndex(e => e.UpdatedBy)
                    .HasName("comment_updatedby_idx");

                entity.HasIndex(e => e.UpdatedOn)
                    .HasName("ix_Comment_UpdatedOn");

                entity.HasIndex(e => new { e.ItemId, e.ItemType })
                    .HasName("ix_Comment_ItemType");

                entity.HasIndex(e => new { e.PublicComment, e.QuestionId })
                    .HasName("Comment_PublicComment_QuestionID_Index");

                entity.HasIndex(e => new { e.QuestionId, e.PublicComment })
                    .HasName("ix_Comment_QuestionID_PublicComment");

                entity.HasIndex(e => new { e.Type, e.QuestionId })
                    .HasName("Comment_Type_QuestionID_Index");

                entity.HasIndex(e => new { e.QuestionId, e.Type, e.Level })
                    .HasName("ix_Comment_QuestionID_Type_Level");

                entity.HasIndex(e => new { e.TopicId, e.Type, e.Level })
                    .HasName("ix_Comment_TopicID_Type_Level");

                entity.HasIndex(e => new { e.Text, e.TopicId, e.PublicComment, e.CommentId })
                    .HasName("_dta_index_Comment_TopicID_PublicComment_CommentID_incl_Text");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ParentItemId).HasColumnName("ParentItemID");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Text).HasColumnType("nvarchar(max)");

                entity.Property(e => e.TopicHistoryId).HasColumnName("TopicHistoryID");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_Comment_Case");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Comment_Group");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_Comment_Post");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Comment_ProcedureSkill");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Comment_TestQuestion");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_Comment_Topic");
            });

            modelBuilder.Entity<CommentReview>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("CommentReview", "orthobullets");

                entity.Property(e => e.CommentId).ValueGeneratedNever();

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.HasOne(d => d.Comment)
                    .WithOne(p => p.CommentReview)
                    .HasForeignKey<CommentReview>(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentReview_Comment");

                entity.HasOne(d => d.Reviewer)
                    .WithMany(p => p.CommentReview)
                    .HasForeignKey(d => d.ReviewerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentReview_Users");
            });

            modelBuilder.Entity<ContactDetail>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Zip).HasMaxLength(10);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.NumericCode);

                entity.Property(e => e.NumericCode).ValueGeneratedNever();

                entity.Property(e => e.Alpha2Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Alpha3Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.EnglishSortName)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<CountryState>(entity =>
            {
                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.NumericCode).HasDefaultValueSql("((840))");

                entity.HasOne(d => d.NumericCodeNavigation)
                    .WithMany(p => p.CountryState)
                    .HasForeignKey(d => d.NumericCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryState_Country");
            });

            modelBuilder.Entity<Domains>(entity =>
            {
                entity.HasKey(e => e.DomainId);

                entity.ToTable("Domains", "pass");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Efootprint>(entity =>
            {
                entity.ToTable("EFootprint");

                entity.Property(e => e.BlockedFromRelease).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsEbattle).HasColumnName("IsEBattle");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.PollOption).HasMaxLength(250);

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Author2)
                    .WithMany(p => p.EfootprintAuthor2)
                    .HasForeignKey(d => d.Author2Id)
                    .HasConstraintName("FK_EFootprint_Users1");

                entity.HasOne(d => d.Author3)
                    .WithMany(p => p.EfootprintAuthor3)
                    .HasForeignKey(d => d.Author3Id)
                    .HasConstraintName("FK_EFootprint_Users2");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.EfootprintAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFootprint_Users");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.Efootprint)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("FK_EFootprint_Poll");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Efootprint)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFootprint_Specialty");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Efootprint)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_EFootprint_Topic");
            });

            modelBuilder.Entity<EfootprintContent>(entity =>
            {
                entity.ToTable("EFootprintContent");

                entity.Property(e => e.EfootprintId).HasColumnName("EFootprintId");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.EfootprintContent)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFootprintContent_EFootprint");

                entity.HasOne(d => d.Efootprint)
                    .WithMany(p => p.EfootprintContent)
                    .HasForeignKey(d => d.EfootprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFootprintContent_EFootprint1");
            });

            modelBuilder.Entity<EfootprintContentType>(entity =>
            {
                entity.ToTable("EFootprintContentType");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<EfootprintRefs>(entity =>
            {
                entity.ToTable("EFootprintRefs");

                entity.Property(e => e.ActionGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EfootprintId).HasColumnName("EFootprintId");

                entity.Property(e => e.RefId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EfootprintRefs)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_EFootprintRefs_Users");

                entity.HasOne(d => d.Efootprint)
                    .WithMany(p => p.EfootprintRefs)
                    .HasForeignKey(d => d.EfootprintId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFootprintRefs_EFootprint");
            });

            modelBuilder.Entity<EmailBlackList>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.AddedByUser)
                    .WithMany(p => p.EmailBlackList)
                    .HasForeignKey(d => d.AddedByUserId)
                    .HasConstraintName("FK_EmailBlackList_Users");
            });

            modelBuilder.Entity<EmailNotificationFeature>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.Property(e => e.FeatureId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailSent>(entity =>
            {
                entity.Property(e => e.MessageType).HasMaxLength(50);

                entity.Property(e => e.Recipient).HasMaxLength(70);

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.EmailSent)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_EmailSent_Group");
            });

            modelBuilder.Entity<EvidenceType>(entity =>
            {
                entity.Property(e => e.EvidenceTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExamAndPermission>(entity =>
            {
                entity.HasKey(e => new { e.TestCode, e.PermissionId });

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ExamAndPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamAndPermission_Permission");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.Property(e => e.FeatureId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fellowship>(entity =>
            {
                entity.Property(e => e.Acgmecode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.FellowshipName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LoadedBy)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Logourl).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Programdirector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Subspecialty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(200);

                entity.Property(e => e.Zipcode).HasMaxLength(10);
            });

            modelBuilder.Entity<Field>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sortorder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.Field)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Field_Subspecialty");
            });

            modelBuilder.Entity<Focus>(entity =>
            {
                entity.Property(e => e.Focus1)
                    .IsRequired()
                    .HasColumnName("Focus")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.DefaultLevel)
                    .WithMany(p => p.Focus)
                    .HasForeignKey(d => d.DefaultLevelId)
                    .HasConstraintName("FK_Focus_Level");

                entity.HasOne(d => d.Focusheading)
                    .WithMany(p => p.Focus)
                    .HasForeignKey(d => d.FocusheadingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Focus_Focusheading");
            });

            modelBuilder.Entity<Focusheading>(entity =>
            {
                entity.Property(e => e.Focusheading1)
                    .IsRequired()
                    .HasColumnName("Focusheading")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Focusheading)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Focushead__Speci__29A20B3F");
            });

            modelBuilder.Entity<FreePdfStatistics>(entity =>
            {
                entity.HasKey(e => e.FreePdfStatisticId);

                entity.ToTable("FreePdfStatistics", "stats");

                entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FreePdfUrl)
                    .IsRequired()
                    .HasColumnName("FreePDF_URL")
                    .HasMaxLength(500);

                entity.Property(e => e.Pmid)
                    .IsRequired()
                    .HasColumnName("PMID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.FreePdfStatistics)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FreePdfSt__PostI__0C5BC11B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FreePdfStatistics)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FreePdfSt__UserI__0D4FE554");
            });

            modelBuilder.Entity<FreePdfStatisticsPrecalculatedByDay>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.JournalClubId });

                entity.ToTable("FreePdfStatisticsPrecalculatedByDay", "stats");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.JournalClubName).HasMaxLength(500);
            });

            modelBuilder.Entity<FreePdfStatisticsPrecalculatedByMonth>(entity =>
            {
                entity.HasKey(e => new { e.FirstDayOfMonth, e.JournalClubId });

                entity.ToTable("FreePdfStatisticsPrecalculatedByMonth", "stats");

                entity.Property(e => e.FirstDayOfMonth).HasColumnType("datetime");

                entity.Property(e => e.JournalClubName).HasMaxLength(500);
            });

            modelBuilder.Entity<FreePdfStatisticsPrecalculatedByWeek>(entity =>
            {
                entity.HasKey(e => new { e.FirstDayOfWeek, e.JournalClubId });

                entity.ToTable("FreePdfStatisticsPrecalculatedByWeek", "stats");

                entity.Property(e => e.FirstDayOfWeek).HasColumnType("datetime");

                entity.Property(e => e.JournalClubName).HasMaxLength(500);
            });

            modelBuilder.Entity<FreePdfStatisticsPrecalculatedUsersByMonth>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.JournalClubId });

                entity.ToTable("FreePdfStatisticsPrecalculatedUsersByMonth", "stats");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(e => e.Guid);

                entity.HasIndex(e => e.TopicId);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.CalculationAchievedMinimumScore).HasDefaultValueSql("((75))");

                entity.Property(e => e.CalculationCountLevelWithoutQuestions).HasDefaultValueSql("((0))");

                entity.Property(e => e.CalculationPartiallyAchievedMinScore).HasDefaultValueSql("((50))");

                entity.Property(e => e.CalculationPriorLevelCriteria).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChiefResidentAccessMode).HasDefaultValueSql("((0))");

                entity.Property(e => e.CountryNumericCode).HasDefaultValueSql("((840))");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EvalMasterGradePeriod).HasDefaultValueSql("((10))");

                entity.Property(e => e.EvalMasterStartEvaluationPeriod).HasDefaultValueSql("((28))");

                entity.Property(e => e.EvalMasterSubmitPeriod).HasDefaultValueSql("((4))");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupPassMseGradingSetting).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupShortName).HasMaxLength(100);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MilestoneDomainId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModeratorId).HasDefaultValueSql("((0))");

                entity.Property(e => e.OfficialStartDate).HasColumnType("date");

                entity.Property(e => e.PassversionMode)
                    .HasColumnName("PASSVersionMode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Products).IsUnicode(false);

                entity.Property(e => e.QuestionsToCountOnReport).HasDefaultValueSql("((3))");

                entity.Property(e => e.RoleBucketAndPgySchemeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.SkillUnlockingMode).HasDefaultValueSql("((1))");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.HasOne(d => d.CategoryType)
                    .WithMany(p => p.Group)
                    .HasForeignKey(d => d.CategoryTypeId)
                    .HasConstraintName("FK_Group_CategoryType");

                entity.HasOne(d => d.CountryNumericCodeNavigation)
                    .WithMany(p => p.Group)
                    .HasForeignKey(d => d.CountryNumericCode)
                    .HasConstraintName("FK_Group_Country");

                entity.HasOne(d => d.CountryState)
                    .WithMany(p => p.Group)
                    .HasForeignKey(d => d.CountryStateId)
                    .HasConstraintName("FK_Group_CountryState");

                entity.HasOne(d => d.RoleBucketAndPgyScheme)
                    .WithMany(p => p.Group)
                    .HasForeignKey(d => d.RoleBucketAndPgySchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_RoleBucketAndPgyScheme");

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.Group)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Group_Subspecialty");
            });

            modelBuilder.Entity<GroupAndRole>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.RoleId });

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupAndRole)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAndRole_Group");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.GroupAndRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAndRole_Role");
            });

            modelBuilder.Entity<GroupAssociativity>(entity =>
            {
                entity.HasIndex(e => new { e.GroupId, e.AssociatedGroupId })
                    .HasName("groupactivity_unq")
                    .IsUnique();

                entity.HasOne(d => d.AssociatedGroup)
                    .WithMany(p => p.GroupAssociativityAssociatedGroup)
                    .HasForeignKey(d => d.AssociatedGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAssociativity_Group2");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupAssociativityGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupAssociativity_Group1");
            });

            modelBuilder.Entity<GroupFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.HasIndex(e => e.GroupId);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Pmid)
                    .HasColumnName("PMID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupInvite>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId });

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupLocation>(entity =>
            {
                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupLocation)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupLocation_Group");
            });

            modelBuilder.Entity<GroupQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Discussion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Pmid1)
                    .HasColumnName("PMID1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmid2)
                    .HasColumnName("PMID2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmid3)
                    .HasColumnName("PMID3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Reference1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference3)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupSettings>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.GroupSettingTypeId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.GroupSettingType)
                    .WithMany(p => p.GroupSettings)
                    .HasForeignKey(d => d.GroupSettingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupSettings_GroupSettingType");
            });

            modelBuilder.Entity<GroupSettingsAssigned>(entity =>
            {
                entity.HasOne(d => d.Bucket)
                    .WithMany(p => p.GroupSettingsAssigned)
                    .HasForeignKey(d => d.BucketId)
                    .HasConstraintName("FK_GroupSettingsAssigned_RoleBuckets");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupSettingsAssigned)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupSettingsAssigned_Group");

                entity.HasOne(d => d.GroupSetting)
                    .WithMany(p => p.GroupSettingsAssigned)
                    .HasForeignKey(d => d.GroupSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupSettingsAssigned_GroupSettings");
            });

            modelBuilder.Entity<GroupSettingType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<GroupsUserTests>(entity =>
            {
                entity.ToTable("Groups_UserTests");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.TestCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupsUserTests)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_UserTests_Group");

                entity.HasOne(d => d.TestCodeNavigation)
                    .WithMany(p => p.GroupsUserTests)
                    .HasForeignKey(d => d.TestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_UserTests_UserTest");
            });

            modelBuilder.Entity<GroupUserTestExamTypeSetting>(entity =>
            {
                entity.ToTable("GroupUserTestExamTypeSetting", "pass");

                entity.HasIndex(e => new { e.GroupId, e.UserTestExamTypeId })
                    .HasName("IX_GroupUserTestExamTypeSetting")
                    .IsUnique();

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupUserTestExamTypeSetting)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUserTestExamTypeSetting_Group");

                entity.HasOne(d => d.UserTestExamType)
                    .WithMany(p => p.GroupUserTestExamTypeSetting)
                    .HasForeignKey(d => d.UserTestExamTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUserTestExamTypeSetting_UserTestExamType");
            });

            modelBuilder.Entity<HomepageVideo>(entity =>
            {
                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.HomepageVideo)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HomepageVideo_Users");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.HomepageVideo)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HomepageVideo_Video");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HospitalContactDetail>(entity =>
            {
                entity.HasOne(d => d.ContactDetail)
                    .WithMany(p => p.HospitalContactDetail)
                    .HasForeignKey(d => d.ContactDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalContactDetail_ContactDetail");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalContactDetail)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalContactDetail_Hospital");
            });

            modelBuilder.Entity<HospitalPhone>(entity =>
            {
                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalPhone)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalPhone_Practice");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.HospitalPhone)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalPhone_Phone");
            });

            modelBuilder.Entity<HospitalUser>(entity =>
            {
                entity.Property(e => e.StartedYear).HasColumnType("date");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalUser)
                    .HasForeignKey(d => d.HospitalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalUser_Hospital");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HospitalUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalUser_Users");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image", "orthobullets");

                entity.HasIndex(e => e.PostId)
                    .HasName("ix_Image_PostID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Source)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ImageCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Image_UsersCreatedBy");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_Image_Post");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Image_TestQuestion");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_Image_Topic");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ImageUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Image_Users");
            });

            modelBuilder.Entity<Internship>(entity =>
            {
                entity.Property(e => e.Acgmecode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.InternshipName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.LoadedBy)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Logourl).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Programdirector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Subspecialty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(200);

                entity.Property(e => e.Zipcode).HasMaxLength(10);
            });

            modelBuilder.Entity<ItemsItems>(entity =>
            {
                entity.ToTable("Items_Items");

                entity.Property(e => e.ConnectedItemTypeName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemTypeName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.ConnectedItemType)
                    .WithMany(p => p.ItemsItemsConnectedItemType)
                    .HasForeignKey(d => new { d.ConnectedItemTypeId, d.ConnectedItemTypeName })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Items_ItemType1");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.ItemsItemsItemType)
                    .HasForeignKey(d => new { d.ItemTypeId, d.ItemTypeName })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Items_ItemType");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Name });

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<JournalClub>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsAbstractShown).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsBulletsSummaryShown).HasDefaultValueSql("((1))");

                entity.Property(e => e.JournalCoverUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MedlineTa)
                    .HasColumnName("MedlineTA")
                    .HasColumnType("nchar(250)");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShortTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.JournalClub)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_JournalClub_Publisher");
            });

            modelBuilder.Entity<LegalAgreement>(entity =>
            {
                entity.Property(e => e.LegalAgreementName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.Level1)
                    .IsRequired()
                    .HasColumnName("Level")
                    .HasMaxLength(20);

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Level)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Level__Specialty__27B9C2CD");
            });

            modelBuilder.Entity<Listings>(entity =>
            {
                entity.ToTable("Listings", "jobbank");

                entity.Property(e => e.AdditionalComments)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateAvailable)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumRequirements)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeFax)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationPosting)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PracticeDepartmentName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PartnershipTrackNavigation)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.PartnershipTrack)
                    .HasConstraintName("FK_Listings_PartnershipTracks");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Listings_USA_State");

                entity.HasOne(d => d.TraumaLevelNavigation)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.TraumaLevel)
                    .HasConstraintName("FK_Listings_TraumaLevels");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Listings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Listings_User");
            });

            modelBuilder.Entity<LoginHistory>(entity =>
            {
                entity.Property(e => e.Browser)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RedirectingUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RouteId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserIp)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoginHistory)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LoginHistory_Users");
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.MediaTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Orientation).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MediaType)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.MediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_MediaType");
            });

            modelBuilder.Entity<MediaType>(entity =>
            {
                entity.Property(e => e.MediaTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MedicalSchool>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.LoadedBy)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Logourl).HasMaxLength(200);

                entity.Property(e => e.MedicalSchoolName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Opeid).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Website).HasMaxLength(200);

                entity.Property(e => e.Zipcode).HasMaxLength(10);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasIndex(e => e.ToUserId)
                    .HasName("IX_ToUserID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("FromUserID");

                entity.Property(e => e.MessageSubject).HasMaxLength(250);

                entity.Property(e => e.OriginalMessageId).HasColumnName("OriginalMessageID");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");
            });

            modelBuilder.Entity<MilestoneReportRecords>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ActiveSkillCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthPersentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.PatienCarePersentage).HasDefaultValueSql("((0))");

                entity.Property(e => e.PatienCareSkillGrade)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProfRequestCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProfResultValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserMembership).HasMaxLength(4000);

                entity.Property(e => e.UserName).HasMaxLength(4000);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.MilestoneReportRecords)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MilestoneReportRecords_MilestoneReports2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MilestoneReportRecords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MilestoneReportRecords_Users1");
            });

            modelBuilder.Entity<MilestoneReports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MilestoneReports)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MilestoneReports_Group");
            });

            modelBuilder.Entity<MinimumRequirements>(entity =>
            {
                entity.ToTable("MinimumRequirements", "jobbank");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MyGroups>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GroupId });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpireOn).HasColumnType("date");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MyGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyGroups_Group");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MyGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyGroups_Users");
            });

            modelBuilder.Entity<MyGroupsAndCategories>(entity =>
            {
                entity.Property(e => e.JoinedOn).HasColumnType("date");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MyGroupsAndCategories)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyGroupsAndCategories_Group");

                entity.HasOne(d => d.MembersCategory)
                    .WithMany(p => p.MyGroupsAndCategories)
                    .HasForeignKey(d => d.MembersCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyGroupsAndCategories_CategoryAttributes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MyGroupsAndCategories)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MyGroupsAndCategories_Users");
            });

            modelBuilder.Entity<NotificationTemplate>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FromAddress).HasMaxLength(70);

                entity.Property(e => e.FromLabel).HasMaxLength(70);

                entity.Property(e => e.MessageDescription).HasMaxLength(1000);

                entity.Property(e => e.MessageHtml).HasMaxLength(4000);

                entity.Property(e => e.MessageName).HasMaxLength(100);

                entity.Property(e => e.MessageTxt).HasMaxLength(4000);

                entity.Property(e => e.MessageType).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(200);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeType).HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<OfficeContactDetail>(entity =>
            {
                entity.HasOne(d => d.ContactDetail)
                    .WithMany(p => p.OfficeContactDetail)
                    .HasForeignKey(d => d.ContactDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeContactDetail_ContactDetail");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.OfficeContactDetail)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeContactDetail_Hospital");
            });

            modelBuilder.Entity<OfficePhone>(entity =>
            {
                entity.HasOne(d => d.Office)
                    .WithMany(p => p.OfficePhone)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficePhone_Office");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.OfficePhone)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficePhone_Phone");
            });

            modelBuilder.Entity<OfficeUser>(entity =>
            {
                entity.Property(e => e.StartedYear).HasColumnType("date");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.OfficeUser)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeUser_Office");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OfficeUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfficeUser_Users");
            });

            modelBuilder.Entity<PartnershipTracks>(entity =>
            {
                entity.ToTable("PartnershipTracks", "jobbank");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassFacultyAndGroupLocations>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId, e.GroupLocationId });

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PassFacultyAndGroupLocations)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassFacultyAndGroupLocations_Group");

                entity.HasOne(d => d.GroupLocation)
                    .WithMany(p => p.PassFacultyAndGroupLocations)
                    .HasForeignKey(d => d.GroupLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassFacultyAndGroupLocations_GroupLocation");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PassFacultyAndGroupLocations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassFacultyAndGroupLocations_Users");
            });

            modelBuilder.Entity<PassGroupDefaultTest>(entity =>
            {
                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.Property(e => e.TestCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TestCodeNavigation)
                    .WithMany(p => p.PassGroupDefaultTest)
                    .HasForeignKey(d => d.TestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassGroupDefaultTest_UserTest");
            });

            modelBuilder.Entity<PassNotification>(entity =>
            {
                entity.HasOne(d => d.Bucket)
                    .WithMany(p => p.PassNotification)
                    .HasForeignKey(d => d.BucketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassNotification_RoleBuckets");

                entity.HasOne(d => d.CustomNotificationTemplate)
                    .WithMany(p => p.PassNotificationCustomNotificationTemplate)
                    .HasForeignKey(d => d.CustomNotificationTemplateId)
                    .HasConstraintName("FK_PassNotification_NotificationTemplate_Custom");

                entity.HasOne(d => d.DefaultNotificationTemplate)
                    .WithMany(p => p.PassNotificationDefaultNotificationTemplate)
                    .HasForeignKey(d => d.DefaultNotificationTemplateId)
                    .HasConstraintName("FK_PassNotification_NotificationTemplate_Default");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PassNotification)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassNotification_Group");

                entity.HasOne(d => d.MonthlyPattern)
                    .WithMany(p => p.PassNotification)
                    .HasForeignKey(d => d.MonthlyPatternId)
                    .HasConstraintName("FK_PassNotification_MonthlyPattern");

                entity.HasOne(d => d.WeeklyPattern)
                    .WithMany(p => p.PassNotification)
                    .HasForeignKey(d => d.WeeklyPatternId)
                    .HasConstraintName("FK_PassNotification_WeeklyPattern");
            });

            modelBuilder.Entity<PassProfEval>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkToPdfInformation).HasMaxLength(100);

                entity.Property(e => e.LongDescirption).HasMaxLength(2000);

                entity.Property(e => e.PassEvalType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShortDescirption).HasMaxLength(1000);

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.PassProfEval)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specialty_PassProfEval");
            });

            modelBuilder.Entity<PassProfEvalScoreHint>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.PassProfEval)
                    .WithMany(p => p.PassProfEvalScoreHint)
                    .HasForeignKey(d => d.PassProfEvalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassProfEvalScoreHint_PassProfEval");

                entity.HasOne(d => d.PassProfScore)
                    .WithMany(p => p.PassProfEvalScoreHint)
                    .HasForeignKey(d => d.PassProfScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassProfEvalScoreHint_PassProfScore");
            });

            modelBuilder.Entity<PassProfScore>(entity =>
            {
                entity.Property(e => e.LongDescription).HasMaxLength(2000);

                entity.Property(e => e.PassEvalType).HasDefaultValueSql("((1))");

                entity.Property(e => e.PassProfScore1).HasColumnName("PassProfScore");

                entity.Property(e => e.ShortDescription).HasMaxLength(250);

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.PassProfScore)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specialty_PassProfScore");
            });

            modelBuilder.Entity<PassuserAndCompetencyLevel>(entity =>
            {
                entity.Property(e => e.PassuserAndCompetencyLevelId).ValueGeneratedOnAdd();

                entity.Property(e => e.GradeDate).HasColumnType("date");

                entity.Property(e => e.SystemDefault).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BiannualReport)
                    .WithMany(p => p.PassuserAndCompetencyLevel)
                    .HasForeignKey(d => d.BiannualReportId)
                    .HasConstraintName("FK_PassuserAndCompetencyLevel_BiannualReport");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PassuserAndCompetencyLevel)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassuserAndCompetencyLevel_Users");

                entity.HasOne(d => d.PassuserAndCompetencyLevelNavigation)
                    .WithOne(p => p.InversePassuserAndCompetencyLevelNavigation)
                    .HasForeignKey<PassuserAndCompetencyLevel>(d => d.PassuserAndCompetencyLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassuserAndCompetencyLevel_PassuserAndCompetencyLevel2");

                entity.HasOne(d => d.PassuserAndCompetencyLevel1)
                    .WithOne(p => p.PassuserAndCompetencyLevel)
                    .HasForeignKey<PassuserAndCompetencyLevel>(d => d.PassuserAndCompetencyLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassuserAndCompetencyLevel_User");
            });

            modelBuilder.Entity<PassUserScores>(entity =>
            {
                entity.HasKey(e => e.UserScoreId);

                entity.Property(e => e.StafType).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.PassUserScoresFaculty)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassUserScores_UserFaculty");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PassUserScores)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassUserScores_Groups");

                entity.HasOne(d => d.Resident)
                    .WithMany(p => p.PassUserScoresResident)
                    .HasForeignKey(d => d.ResidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassUserScores_UserResident");
            });

            modelBuilder.Entity<PassUserScoresItems>(entity =>
            {
                entity.HasKey(e => e.PassUserScoreItemId);

                entity.HasOne(d => d.PassProfEval)
                    .WithMany(p => p.PassUserScoresItems)
                    .HasForeignKey(d => d.PassProfEvalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassUserScoresItems_PassProfEval");

                entity.HasOne(d => d.PassProffScore)
                    .WithMany(p => p.PassUserScoresItems)
                    .HasForeignKey(d => d.PassProffScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassUserScoresItems_PassProfScore");

                entity.HasOne(d => d.PassUserScore)
                    .WithMany(p => p.PassUserScoresItems)
                    .HasForeignKey(d => d.PassUserScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PassUserScoresItems_PassUserScores");
            });

            modelBuilder.Entity<PaymentItems>(entity =>
            {
                entity.HasKey(e => e.IdName);

                entity.Property(e => e.IdName)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName).HasColumnType("nchar(150)");
            });

            modelBuilder.Entity<PaymentPeriods>(entity =>
            {
                entity.Property(e => e.ValidSince).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.PaymentPeriods)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentPeriods_Specialty");
            });

            modelBuilder.Entity<PaymentPrice>(entity =>
            {
                entity.HasKey(e => new { e.PaymentItemId, e.UserRoleId, e.PeriodId });

                entity.Property(e => e.PaymentItemId).HasMaxLength(50);

                entity.HasOne(d => d.PaymentItem)
                    .WithMany(p => p.PaymentPrice)
                    .HasForeignKey(d => d.PaymentItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentPrice_PaymentItems");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.PaymentPrice)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentPrice_PaymentPeriods");
            });

            modelBuilder.Entity<Paymenttransactionlog>(entity =>
            {
                entity.ToTable("paymenttransactionlog");

                entity.Property(e => e.Paymenttransactionlogid).HasColumnName("paymenttransactionlogid");

                entity.Property(e => e.AddressCity)
                    .HasColumnName("address_city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCountry)
                    .HasColumnName("address_country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCountryCode)
                    .HasColumnName("address_country_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AddressName)
                    .HasColumnName("address_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasColumnName("address_state")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AddressStatus)
                    .HasColumnName("address_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddressStreet)
                    .HasColumnName("address_street")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AddressZip)
                    .HasColumnName("address_zip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BtnId).HasColumnName("btn_id");

                entity.Property(e => e.Business)
                    .HasColumnName("business")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Charset)
                    .HasColumnName("charset")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Custom)
                    .HasColumnName("custom")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HandlingAmount).HasColumnName("handling_amount");

                entity.Property(e => e.InsuranceAmount).HasColumnName("insurance_amount");

                entity.Property(e => e.IpnTrackId)
                    .HasColumnName("ipn_track_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber).HasColumnName("item_number");

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.McCurrency)
                    .HasColumnName("mc_currency")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.McFee).HasColumnName("mc_fee");

                entity.Property(e => e.McGross).HasColumnName("mc_gross");

                entity.Property(e => e.NotifyVersion)
                    .HasColumnName("notify_version")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OptionName1)
                    .HasColumnName("option_name1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionSelection1)
                    .HasColumnName("option_selection1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ParentTxnId)
                    .HasColumnName("parent_txn_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayerEmail)
                    .HasColumnName("payer_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayerId)
                    .HasColumnName("payer_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayerStatus)
                    .HasColumnName("payer_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentFee).HasColumnName("payment_fee");

                entity.Property(e => e.PaymentGross).HasColumnName("payment_gross");

                entity.Property(e => e.PaymentStatus)
                    .HasColumnName("payment_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("payment_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.ProtectionEligibility)
                    .HasColumnName("protection_eligibility")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Purchasedate)
                    .HasColumnName("purchasedate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReceiverEmail)
                    .HasColumnName("receiver_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId)
                    .HasColumnName("receiver_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResidenceCountry)
                    .HasColumnName("residence_country")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shipping).HasColumnName("shipping");

                entity.Property(e => e.ShippingDiscount).HasColumnName("shipping_discount");

                entity.Property(e => e.ShippingMethod)
                    .HasColumnName("shipping_method")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shippingaddress)
                    .HasColumnName("shippingaddress")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.TestIpn)
                    .HasColumnName("test_ipn")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionSubject)
                    .HasColumnName("transaction_subject")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxnId)
                    .HasColumnName("txn_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasColumnName("txn_type")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.VerifySign)
                    .HasColumnName("verify_sign")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PdfLicense>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(dateadd(day,(365),getdate()))");

                entity.Property(e => e.PdfLicenseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.PermissionName).HasMaxLength(200);
            });

            modelBuilder.Entity<PermissionTier>(entity =>
            {
                entity.Property(e => e.PermissionTierName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.PhoneMessage).HasMaxLength(500);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.PhoneType).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.HasIndex(e => e.PostId);

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Option1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option10)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option11).HasMaxLength(250);

                entity.Property(e => e.Option12).HasMaxLength(250);

                entity.Property(e => e.Option13).HasMaxLength(250);

                entity.Property(e => e.Option2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option3)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option4)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option5)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option6)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option7)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option8)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Option9)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PollType).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Poll)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poll_Users");
            });

            modelBuilder.Entity<PollResult>(entity =>
            {
                entity.HasIndex(e => e.PollId);

                entity.HasIndex(e => new { e.PollId, e.Option })
                    .HasName("pollresult_pollidoption_idx");

                entity.HasIndex(e => new { e.PollId, e.PollResultId, e.Option })
                    .HasName("index_PollResult_PollID_PollResultId_Option");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Option)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PollResult)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PollResult_Users");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollResult)
                    .HasForeignKey(d => d.PollId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PollResult_Poll");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => e.GroupId);

                entity.HasIndex(e => e.Pmid)
                    .HasName("_dta_index_Post_PMID");

                entity.HasIndex(e => new { e.PostId, e.PostType, e.TopicId, e.PubDate, e.CreatedOn })
                    .HasName("_dta_index_Post_PostType_TopicID_PubDate_CreatedOn");

                entity.Property(e => e.PostId)
                    .HasColumnName("PostID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Doi)
                    .HasColumnName("DOI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FreePdfUrl)
                    .HasColumnName("FreePDF_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FullTextUrl)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JournalName).HasMaxLength(500);

                entity.Property(e => e.JournalPostAutors).HasMaxLength(2500);

                entity.Property(e => e.MedlineTa)
                    .HasColumnName("MedlineTA")
                    .HasMaxLength(250);

                entity.Property(e => e.Pmid)
                    .HasColumnName("PMID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PostType).HasDefaultValueSql("((0))");

                entity.Property(e => e.PubDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Title).HasMaxLength(2000);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.HasOne(d => d.CategoryType)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.CategoryTypeId)
                    .HasConstraintName("FK_Post_CategoryType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Post_Users");

                entity.HasOne(d => d.EvidenceType)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.EvidenceTypeId)
                    .HasConstraintName("FK_Post_EvidenceType");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Post_Group");

                entity.HasOne(d => d.JournalClub)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.JournalClubId)
                    .HasConstraintName("FK_Post_JournalClub");

                entity.HasOne(d => d.PdfLicense)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.PdfLicenseId)
                    .HasConstraintName("FK_Post_PdfLicense");

                entity.HasOne(d => d.PostNavigation)
                    .WithOne(p => p.InversePostNavigation)
                    .HasForeignKey<Post>(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Poll_Post");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Post_TestQuestion");

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Post_Subspecialty");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_Post_Topic");
            });

            modelBuilder.Entity<PostNote>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsHighlight).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (1) else (0) end,(0)))");

                entity.Property(e => e.IsNote).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (0) else (1) end,(0)))");

                entity.Property(e => e.OriginalMd5)
                    .IsRequired()
                    .HasColumnType("binary(16)");

                entity.Property(e => e.RangySelection).IsRequired();

                entity.Property(e => e.Style).HasMaxLength(250);

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostNote)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_PostNote_Post");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.PostNote)
                    .HasForeignKey(d => d.SpecialtyId)
                    .HasConstraintName("FK_PostNote_Specialty");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostNote)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PostNote_Users");
            });

            modelBuilder.Entity<PostNoteFile>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BacketPath)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.PostNote)
                    .WithMany(p => p.PostNoteFile)
                    .HasForeignKey(d => d.PostNoteId)
                    .HasConstraintName("FK_PostNoteFile_PostNote");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostNoteFile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostNoteFile_Users");
            });

            modelBuilder.Entity<Practice>(entity =>
            {
                entity.ToTable("Practice", "mdx");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Domain).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Slogan1).HasMaxLength(50);

                entity.Property(e => e.Slogan2).HasMaxLength(50);

                entity.Property(e => e.Slogan3).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<PracticeContactDetail>(entity =>
            {
                entity.ToTable("PracticeContactDetail", "mdx");

                entity.HasOne(d => d.ContactDetail)
                    .WithMany(p => p.PracticeContactDetail)
                    .HasForeignKey(d => d.ContactDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeContactDetail_ContactDetail");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticeContactDetail)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeContactDetail_Practice");
            });

            modelBuilder.Entity<PracticeMedia>(entity =>
            {
                entity.ToTable("PracticeMedia", "mdx");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.PracticeMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeMedia_Media");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticeMedia)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeMedia_Practice");
            });

            modelBuilder.Entity<PracticeOffice>(entity =>
            {
                entity.ToTable("PracticeOffice", "mdx");

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.PracticeOffice)
                    .HasForeignKey(d => d.OfficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeOffice_Office");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticeOffice)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeOffice_Practice");
            });

            modelBuilder.Entity<PracticePhone>(entity =>
            {
                entity.ToTable("PracticePhone", "mdx");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.PracticePhone)
                    .HasForeignKey(d => d.PhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticePhone_Phone");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticePhone)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticePhone_Practice");
            });

            modelBuilder.Entity<PracticeSubscription>(entity =>
            {
                entity.ToTable("PracticeSubscription", "mdx");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.PaidAmmount).HasColumnType("money");

                entity.Property(e => e.PaidDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.BillingContactDetail)
                    .WithMany(p => p.PracticeSubscription)
                    .HasForeignKey(d => d.BillingContactDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeSubscription_ContactDetail");

                entity.HasOne(d => d.BillingPhone)
                    .WithMany(p => p.PracticeSubscription)
                    .HasForeignKey(d => d.BillingPhoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeSubscription_Phone");

                entity.HasOne(d => d.BillingUser)
                    .WithMany(p => p.PracticeSubscription)
                    .HasForeignKey(d => d.BillingUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeSubscription_Users");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticeSubscription)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeSubscription_Practice");
            });

            modelBuilder.Entity<PracticeSubspecialty>(entity =>
            {
                entity.ToTable("PracticeSubspecialty", "mdx");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.PracticeSubspecialty)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("FK_PracticeSubspecialty_Media");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticeSubspecialty)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeSubspecialty_Practice");
            });

            modelBuilder.Entity<PracticeSubspecialtyUser>(entity =>
            {
                entity.ToTable("PracticeSubspecialtyUser", "mdx");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.Started).HasColumnType("date");

                entity.HasOne(d => d.PracticeSubspecialty)
                    .WithMany(p => p.PracticeSubspecialtyUser)
                    .HasForeignKey(d => d.PracticeSubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeSubspecialtyUser_PracticeSubspecialty");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PracticeSubspecialtyUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeSubspecialtyUser_Users");
            });

            modelBuilder.Entity<PracticeTestmonial>(entity =>
            {
                entity.ToTable("PracticeTestmonial", "mdx");

                entity.HasOne(d => d.Practice)
                    .WithMany(p => p.PracticeTestmonial)
                    .HasForeignKey(d => d.PracticeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeTestmonial_Practice");

                entity.HasOne(d => d.Testmonial)
                    .WithMany(p => p.PracticeTestmonial)
                    .HasForeignKey(d => d.TestmonialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PracticeTestmonial_Testmonial");
            });

            modelBuilder.Entity<PracticeTypes>(entity =>
            {
                entity.ToTable("PracticeTypes", "jobbank");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreComputedValue>(entity =>
            {
                entity.HasIndex(e => new { e.ItemType, e.ItemId });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");
            });

            modelBuilder.Entity<PrimarySecondaryGroup>(entity =>
            {
                entity.HasKey(e => new { e.PrimaryGroupId, e.SecondaryGroupId });

                entity.HasOne(d => d.PrimaryGroup)
                    .WithMany(p => p.PrimarySecondaryGroupPrimaryGroup)
                    .HasForeignKey(d => d.PrimaryGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrimarySecondaryGroup_Group");

                entity.HasOne(d => d.SecondaryGroup)
                    .WithMany(p => p.PrimarySecondaryGroupSecondaryGroup)
                    .HasForeignKey(d => d.SecondaryGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrimarySecondaryGroup_Group1");
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.HasIndex(e => e.ProcedureId)
                    .HasName("_dta_index_Procedure_ProcedureId");

                entity.Property(e => e.BlockedFromRelease).HasDefaultValueSql("((1))");

                entity.Property(e => e.LogoLink).HasMaxLength(1000);

                entity.Property(e => e.LogoUrl).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ProcedureComplexity)
                    .WithMany(p => p.Procedure)
                    .HasForeignKey(d => d.ProcedureComplexityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Procedure_ProcedureComplexity");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Procedure)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specialty_Procedure");

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.Procedure)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .HasConstraintName("FK_Procedure_Subspecialty");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Procedure)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Procedure_Topic");
            });

            modelBuilder.Entity<ProcedureBullet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureBullet)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureBullet_Procedure");
            });

            modelBuilder.Entity<ProcedureComplexity>(entity =>
            {
                entity.Property(e => e.ProcedureComplexityId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProcedureSkill>(entity =>
            {
                entity.HasIndex(e => e.ProcedureId)
                    .HasName("_dta_index_ProcedureSkill_ProcedureId");

                entity.HasIndex(e => new { e.Active, e.ProcedureId, e.ProcedureSkillId })
                    .HasName("_dta_index_ProcedureSkill_Active_ProcedureId_ProcedureSkillId");

                entity.HasIndex(e => new { e.ProcedureId, e.ProcedureStepLevelId, e.Active })
                    .HasName("_dta_index_ProcedureSkill_Active_incl_ProcedureId");

                entity.HasIndex(e => new { e.ProcedureStepLevelId, e.ProcedureSkillId, e.Active, e.ProcedureId })
                    .HasName("_dta_index_ProcedureSkill_ProcedureSkillId_Active_ProcedureId");

                entity.Property(e => e.ProcedureSkillStepName).HasMaxLength(250);

                entity.Property(e => e.TopicAnchor).HasMaxLength(150);

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkill)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkill_Procedure");

                entity.HasOne(d => d.ProcedureStep)
                    .WithMany(p => p.ProcedureSkill)
                    .HasForeignKey(d => d.ProcedureStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkill_ProcedureStep");

                entity.HasOne(d => d.ProcedureStepLevel)
                    .WithMany(p => p.ProcedureSkill)
                    .HasForeignKey(d => d.ProcedureStepLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkill_ProcedureStepLevel");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.ProcedureSkill)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_ProcedureSkill_Topic");
            });

            modelBuilder.Entity<ProcedureSkillActionHistory>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.ProcedureSkillApprovalStateId, e.GradedGrade, e.ProcedureSkillId, e.LastActionDate })
                    .HasName("_dta_index_ProcedureSkillActionHistory_UserId_ProcedureSkillApprovalStateId_GradedGrade_ProcedureSkillId_LastActionDate");

                entity.Property(e => e.ApprovedCccuserId).HasColumnName("ApprovedCCCUserId");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.EnteredLocation).HasMaxLength(250);

                entity.Property(e => e.EnteredVisualSignUrl).HasMaxLength(1000);

                entity.Property(e => e.RealEnteredDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ApprovedCccuser)
                    .WithMany(p => p.ProcedureSkillActionHistoryApprovedCccuser)
                    .HasForeignKey(d => d.ApprovedCccuserId)
                    .HasConstraintName("FK_ProcedureSkillActionHistory_Users3");

                entity.HasOne(d => d.EnteredFacultyToGradeUser)
                    .WithMany(p => p.ProcedureSkillActionHistoryEnteredFacultyToGradeUser)
                    .HasForeignKey(d => d.EnteredFacultyToGradeUserId)
                    .HasConstraintName("FK_ProcedureSkillActionHistory_Users1");

                entity.HasOne(d => d.GradedFacultyUser)
                    .WithMany(p => p.ProcedureSkillActionHistoryGradedFacultyUser)
                    .HasForeignKey(d => d.GradedFacultyUserId)
                    .HasConstraintName("FK_ProcedureSkillActionHistory_Users2");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ProcedureSkillActionHistory)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillActionHistory_Group");

                entity.HasOne(d => d.ProcedureSkillApprovalState)
                    .WithMany(p => p.ProcedureSkillActionHistory)
                    .HasForeignKey(d => d.ProcedureSkillApprovalStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillActionHistory_ProcedureSkillApprovalState");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillActionHistory)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillActionHistory_ProcedureSkill");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcedureSkillActionHistoryUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillActionHistory_Users");
            });

            modelBuilder.Entity<ProcedureSkillApprovalState>(entity =>
            {
                entity.Property(e => e.ProcedureSkillApprovalStateId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<ProcedureSkillStep>(entity =>
            {
                entity.HasIndex(e => e.ProcedureSkillId)
                    .HasName("_dta_index_ProcedureSkillStep_ProcedureSkillId");

                entity.HasIndex(e => new { e.ItemClass, e.ProcedureSkillId })
                    .HasName("_dta_index_ProcedureSkillStep_ItemClass_ProcedureSkillId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillStep)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .HasConstraintName("FK_ProcedureSkillStep_ProcedureSkill");
            });

            modelBuilder.Entity<ProcedureSkillStepChapter>(entity =>
            {
                entity.HasKey(e => new { e.ProcedureId, e.ProcedureSkillId, e.ChapterId });

                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ActionUser)
                    .WithMany(p => p.ProcedureSkillStepChapter)
                    .HasForeignKey(d => d.ActionUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepChapter_Users");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillStepChapter)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepChapter_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillStepChapter)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepChapter_ProcedureSkill");
            });

            modelBuilder.Entity<ProcedureSkillStepEvidence>(entity =>
            {
                entity.HasKey(e => new { e.ProcedureId, e.ProcedureSkillId, e.EvidencePmid });

                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ActionUser)
                    .WithMany(p => p.ProcedureSkillStepEvidence)
                    .HasForeignKey(d => d.ActionUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepEvidence_Users");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillStepEvidence)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepEvidence_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillStepEvidence)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepEvidence_ProcedureSkill");
            });

            modelBuilder.Entity<ProcedureSkillStepNote>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BulletMd5)
                    .IsRequired()
                    .HasColumnType("binary(16)");

                entity.Property(e => e.IsHighlight).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (1) else (0) end,(0)))");

                entity.Property(e => e.IsNote).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (0) else (1) end,(0)))");

                entity.Property(e => e.Style).HasMaxLength(250);

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillStepNote)
                    .HasForeignKey(d => d.ProcedureId)
                    .HasConstraintName("FK_ProcedureSkillStepNote_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillStepNote)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .HasConstraintName("FK_ProcedureSkillStepNote_ProcedureSkill");

                entity.HasOne(d => d.ProcedureSkillStep)
                    .WithMany(p => p.ProcedureSkillStepNote)
                    .HasForeignKey(d => d.ProcedureSkillStepId)
                    .HasConstraintName("FK_ProcedureSkillStepNote_ProcedureSkillStep");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.ProcedureSkillStepNote)
                    .HasForeignKey(d => d.SpecialtyId)
                    .HasConstraintName("FK_ProcedureSkillStepNote_Specialty");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcedureSkillStepNote)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProcedureSkillStepNote_Users");
            });

            modelBuilder.Entity<ProcedureSkillStepNoteFile>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BacketPath)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.ProcedureSkillStepNote)
                    .WithMany(p => p.ProcedureSkillStepNoteFile)
                    .HasForeignKey(d => d.ProcedureSkillStepNoteId)
                    .HasConstraintName("FK_ProcedureSkillStepNoteFile_ProcedureSkillStepNote");

                entity.HasOne(d => d.UploadFileType)
                    .WithMany(p => p.ProcedureSkillStepNoteFile)
                    .HasForeignKey(d => d.UploadFileTypeId)
                    .HasConstraintName("FK_ProcedureSkillStepNoteFile_UploadFileType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcedureSkillStepNoteFile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepNoteFile_Users");
            });

            modelBuilder.Entity<ProcedureSkillStepPearl>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.ProcedureSkillStep)
                    .WithMany(p => p.ProcedureSkillStepPearl)
                    .HasForeignKey(d => d.ProcedureSkillStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepPearl_ProcedureSkillStep");
            });

            modelBuilder.Entity<ProcedureSkillStepPitfall>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.ProcedureSkillStep)
                    .WithMany(p => p.ProcedureSkillStepPitfall)
                    .HasForeignKey(d => d.ProcedureSkillStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepPitfall_ProcedureSkillStep");
            });

            modelBuilder.Entity<ProcedureSkillStepProgress>(entity =>
            {
                entity.HasKey(e => new { e.ProcedureId, e.ProcedureSkillId, e.ProcedureSkillStepId, e.UserId });

                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillStepProgress)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepProgress_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillStepProgress)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepProgress_ProcedureSkill");

                entity.HasOne(d => d.ProcedureSkillStep)
                    .WithMany(p => p.ProcedureSkillStepProgress)
                    .HasForeignKey(d => d.ProcedureSkillStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepProgress_ProcedureSkillStep");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcedureSkillStepProgress)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillStepProgress_Users");
            });

            modelBuilder.Entity<ProcedureSkillStepTagged>(entity =>
            {
                entity.HasKey(e => new { e.ProcedureId, e.ProcedureSkillId, e.ProcedureSkillStepId, e.UserId });

                entity.Property(e => e.Timestamp).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillStepTagged)
                    .HasForeignKey(d => d.ProcedureId)
                    .HasConstraintName("FK_ProcedureSkillStepTagged_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillStepTagged)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .HasConstraintName("FK_ProcedureSkillStepTagged_ProcedureSkill");

                entity.HasOne(d => d.ProcedureSkillStep)
                    .WithMany(p => p.ProcedureSkillStepTagged)
                    .HasForeignKey(d => d.ProcedureSkillStepId)
                    .HasConstraintName("FK_ProcedureSkillStepTagged_ProcedureSkillStep");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcedureSkillStepTagged)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProcedureSkillStepTagged_Users");
            });

            modelBuilder.Entity<ProcedureSkillTest>(entity =>
            {
                entity.HasKey(e => new { e.ProcedureId, e.ProcedureSkillId, e.TestCode });

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ActionUser)
                    .WithMany(p => p.ProcedureSkillTest)
                    .HasForeignKey(d => d.ActionUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillTest_Users");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillTest)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillTest_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillTest)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillTest_ProcedureSkill");

                entity.HasOne(d => d.TestCodeNavigation)
                    .WithMany(p => p.ProcedureSkillTest)
                    .HasForeignKey(d => d.TestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillTest_UserTest");
            });

            modelBuilder.Entity<ProcedureSkillUserAction>(entity =>
            {
                entity.HasKey(e => new { e.ProcedureId, e.ProcedureSkillId, e.UserId, e.ProcedureSkillUserActionTypeId });

                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillUserAction)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillUserAction_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillUserAction)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillUserAction_ProcedureSkill");

                entity.HasOne(d => d.ProcedureSkillUserActionType)
                    .WithMany(p => p.ProcedureSkillUserAction)
                    .HasForeignKey(d => d.ProcedureSkillUserActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillUserAction_ProcedureSkillUserActionType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProcedureSkillUserAction)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillUserAction_Users");
            });

            modelBuilder.Entity<ProcedureSkillUserActionType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProcedureSkillVideo>(entity =>
            {
                entity.HasKey(e => new { e.ProcedureId, e.ProcedureSkillId, e.VideoId });

                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ActionUser)
                    .WithMany(p => p.ProcedureSkillVideo)
                    .HasForeignKey(d => d.ActionUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillVideo_Users");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureSkillVideo)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillVideo_Procedure");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.ProcedureSkillVideo)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillVideo_ProcedureSkill");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.ProcedureSkillVideo)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureSkillVideo_Video");
            });

            modelBuilder.Entity<ProcedureStep>(entity =>
            {
                entity.Property(e => e.ProcedureStepId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ProcedureStepLevel)
                    .WithMany(p => p.ProcedureStep)
                    .HasForeignKey(d => d.ProcedureStepLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcedureStep_ProcedureStepLevel");
            });

            modelBuilder.Entity<ProcedureStepLevel>(entity =>
            {
                entity.Property(e => e.ProcedureStepLevelId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ProcedureValidationEvidence>(entity =>
            {
                entity.Property(e => e.ValidationDescription).IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsPrimaryButtonEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.LengthDays).HasColumnName("length_days");

                entity.Property(e => e.Logolink)
                    .HasColumnName("logolink")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mailchimpid)
                    .HasColumnName("mailchimpid")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Marketingstartdate)
                    .HasColumnName("marketingstartdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Newusersstarttype)
                    .HasColumnName("newusersstarttype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumdaysExpirereminder).HasColumnName("numdays_expirereminder");

                entity.Property(e => e.Paypalbuttonid)
                    .HasColumnName("paypalbuttonid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Paypallink)
                    .HasColumnName("paypallink")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PrimaryButtonLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryButtonTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.Producttypeid).HasColumnName("producttypeid");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SuccessText)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Users");

                entity.HasOne(d => d.PermissionTier)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.PermissionTierId)
                    .HasConstraintName("FK_Product_PermissionTier");

                entity.HasOne(d => d.Producttype)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.Producttypeid)
                    .HasConstraintName("product_producttypeid_fk");

                entity.HasOne(d => d.Website)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.WebsiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Website");
            });

            modelBuilder.Entity<ProductAndGroupPermission>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ProductAndGroupPermission)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndGroupPermission_Group");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAndGroupPermission)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndGroupPermission_Product");
            });

            modelBuilder.Entity<ProductAndRole>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RoleId });

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAndRole)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndRole_Product");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ProductAndRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndRole_Role");
            });

            modelBuilder.Entity<ProductAndTestQuestionFlagPermission>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAndTestQuestionFlagPermission)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndTestQuestionFlagPermission_Product");

                entity.HasOne(d => d.TestQuestionFlag)
                    .WithMany(p => p.ProductAndTestQuestionFlagPermission)
                    .HasForeignKey(d => d.TestQuestionFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndTestQuestionFlagPermission_TestQuestionFlag");
            });

            modelBuilder.Entity<ProductAndUserTestPermission>(entity =>
            {
                entity.Property(e => e.TestCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAndUserTestPermission)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndUserTestPermission_Product");

                entity.HasOne(d => d.TestCodeNavigation)
                    .WithMany(p => p.ProductAndUserTestPermission)
                    .HasForeignKey(d => d.TestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndUserTestPermission_UserTest");
            });

            modelBuilder.Entity<ProductAndVideoCategoryTypePermission>(entity =>
            {
                entity.HasOne(d => d.CategoryType)
                    .WithMany(p => p.ProductAndVideoCategoryTypePermission)
                    .HasForeignKey(d => d.CategoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndVideoCategoryTypePermission_CategoryType");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAndVideoCategoryTypePermission)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndVideoCategoryTypePermission_Product");
            });

            modelBuilder.Entity<ProductAndVideoPermission>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAndVideoPermission)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndVideoPermission_Product");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.ProductAndVideoPermission)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAndVideoPermission_Video");
            });

            modelBuilder.Entity<ProductLinkedArticles>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendedDate).HasColumnType("date");

                entity.HasOne(d => d.StudyPlan)
                    .WithMany(p => p.ProductLinkedArticles)
                    .HasForeignKey(d => d.StudyPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedArticles_StudyPlan");

                entity.HasOne(d => d.StudyPlanDay)
                    .WithMany(p => p.ProductLinkedArticles)
                    .HasForeignKey(d => new { d.StudyPlanId, d.Day })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductLinkedArticles_StudyPlanDay");
            });

            modelBuilder.Entity<ProductLinkedCases>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendedDate).HasColumnType("date");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.ProductLinkedCases)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedCases_Case");

                entity.HasOne(d => d.StudyPlan)
                    .WithMany(p => p.ProductLinkedCases)
                    .HasForeignKey(d => d.StudyPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedCases_StudyPlan");

                entity.HasOne(d => d.StudyPlanDay)
                    .WithMany(p => p.ProductLinkedCases)
                    .HasForeignKey(d => new { d.StudyPlanId, d.Day })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductLinkedCases_StudyPlanDay");
            });

            modelBuilder.Entity<ProductLinkedTests>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.Property(e => e.MinScore).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendedDate).HasColumnType("date");

                entity.Property(e => e.TestCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestOrder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Cme)
                    .WithMany(p => p.ProductLinkedTests)
                    .HasForeignKey(d => d.CmeId)
                    .HasConstraintName("FK_ProductLinkedTests_Cme");

                entity.HasOne(d => d.StudyPlan)
                    .WithMany(p => p.ProductLinkedTests)
                    .HasForeignKey(d => d.StudyPlanId)
                    .HasConstraintName("FK_ProductLinkedTests_StudyPlan");

                entity.HasOne(d => d.TestCodeNavigation)
                    .WithMany(p => p.ProductLinkedTests)
                    .HasForeignKey(d => d.TestCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedTests_UserTest");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.ProductLinkedTests)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_ProductLinkedTests_Video");

                entity.HasOne(d => d.StudyPlanDay)
                    .WithMany(p => p.ProductLinkedTests)
                    .HasForeignKey(d => new { d.StudyPlanId, d.Day })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductLinkedTests_StudyPlanDay");
            });

            modelBuilder.Entity<ProductLinkedTopics>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendedDate).HasColumnType("date");

                entity.HasOne(d => d.StudyPlan)
                    .WithMany(p => p.ProductLinkedTopics)
                    .HasForeignKey(d => d.StudyPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedTopics_StudyPlan");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.ProductLinkedTopics)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedTopics_Topic");

                entity.HasOne(d => d.StudyPlanDay)
                    .WithMany(p => p.ProductLinkedTopics)
                    .HasForeignKey(d => new { d.StudyPlanId, d.Day })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductLinkedTopics_StudyPlanDay");
            });

            modelBuilder.Entity<ProductLinkedVideos>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecommendedDate).HasColumnType("date");

                entity.HasOne(d => d.StudyPlan)
                    .WithMany(p => p.ProductLinkedVideos)
                    .HasForeignKey(d => d.StudyPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedVideos_StudyPlan");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.ProductLinkedVideos)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLinkedVideos_Video");

                entity.HasOne(d => d.StudyPlanDay)
                    .WithMany(p => p.ProductLinkedVideos)
                    .HasForeignKey(d => new { d.StudyPlanId, d.Day })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductLinkedVideos_StudyPlanDay");
            });

            modelBuilder.Entity<ProductReference>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ReferencedProductId });

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReferenceProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductReference_Product");

                entity.HasOne(d => d.ReferencedProduct)
                    .WithMany(p => p.ProductReferenceReferencedProduct)
                    .HasForeignKey(d => d.ReferencedProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductReference_ReferencedProduct");
            });

            modelBuilder.Entity<Producttype>(entity =>
            {
                entity.ToTable("producttype");

                entity.Property(e => e.Producttypeid)
                    .HasColumnName("producttypeid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestionHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("QuestionHistory", "orthobullets");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.Answer1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.QuestionText)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Reference1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionSourceCategory>(entity =>
            {
                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UiFilterApplicable).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating", "orthobullets");

                entity.HasIndex(e => e.QuestionId);

                entity.HasIndex(e => e.TopicId);

                entity.HasIndex(e => new { e.Rating1, e.QuestionId })
                    .HasName("Rating_QuestionID_INCLUDE_Rating_Index");

                entity.HasIndex(e => new { e.Rating1, e.ItemType, e.ItemId })
                    .HasName("Rating_ItemType_ItemID_Index");

                entity.Property(e => e.RatingId).HasColumnName("RatingID");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Rating1).HasColumnName("Rating");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Rating_Users");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Rating_TestQuestion");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Rating_Specialty");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Rating_Topic");
            });

            modelBuilder.Entity<Residency>(entity =>
            {
                entity.Property(e => e.Acgmecode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.LoadedBy)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Logourl).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Programdirector)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResidencyName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Subspecialty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(200);

                entity.Property(e => e.Zipcode).HasMaxLength(10);
            });

            modelBuilder.Entity<ReviewModeSlides>(entity =>
            {
                entity.Property(e => e.FileUrl)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LoadDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.ReviewModeSlides)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewModeSlides_TestQuestion");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReviewModeSlides)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewModeSlides_Users");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.RoleName).HasMaxLength(200);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Users");
            });

            modelBuilder.Entity<RoleAndPermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.RoleId });

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RoleAndPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleAndPermission_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAndPermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleAndPermission_Role");
            });

            modelBuilder.Entity<RoleBucketAndPgy>(entity =>
            {
                entity.HasKey(e => e.PgyId);

                entity.Property(e => e.PgyYear)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.RoleBucketAndPgyScheme)
                    .WithMany(p => p.RoleBucketAndPgy)
                    .HasForeignKey(d => d.RoleBucketAndPgySchemeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleBucketAndPgy_RoleBucketAndPgyScheme");

                entity.HasOne(d => d.RoleBucket)
                    .WithMany(p => p.RoleBucketAndPgy)
                    .HasForeignKey(d => d.RoleBucketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleBucketAndPgy_RoleBuckets");
            });

            modelBuilder.Entity<RoleBucketAndPgyScheme>(entity =>
            {
                entity.HasKey(e => e.SchemeId);

                entity.Property(e => e.SchemeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleBuckets>(entity =>
            {
                entity.HasKey(e => e.BucketId);

                entity.Property(e => e.BucketName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SelfProgressArticles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ArticleId, e.Timestamp });

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.SelfProgressArticles)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelfProgressArticles_Articles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SelfProgressArticles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelfProgressArticles_Users");
            });

            modelBuilder.Entity<SelfProgressQuestions>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.QuestionId, e.Timestamp });

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SelfProgressQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelfProgressQuestions_Questions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SelfProgressQuestions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelfProgressQuestions_Users");
            });

            modelBuilder.Entity<SelfProgressTopics>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TopicId, e.Timestamp });

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Percentage).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.SelfProgressTopics)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReadingProgress_Topics");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SelfProgressTopics)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReadingProgress_Users");
            });

            modelBuilder.Entity<SelfProgressVideo>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.VideoId, e.Timestamp });

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SelfProgressVideo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelfProgressVideo_Users");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.SelfProgressVideo)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SelfProgressVideo_Video");
            });

            modelBuilder.Entity<SkippedItems>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.FeatureId, e.FeatureType })
                    .HasName("IX_SkippedItems")
                    .IsUnique();
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(10);

                entity.Property(e => e.WebsiteId).HasDefaultValueSql("((2))");

                entity.HasOne(d => d.Website)
                    .WithMany(p => p.Specialty)
                    .HasForeignKey(d => d.WebsiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Specialty_Website");
            });

            modelBuilder.Entity<StudyPlan>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.LengthInDays).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StudyPlanTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_StudyPlan_Group");

                entity.HasOne(d => d.StudyPlanSubType)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.StudyPlanSubTypeId)
                    .HasConstraintName("FK_StudyPlan_StudyPlanSubType");

                entity.HasOne(d => d.StudyPlanType)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.StudyPlanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyPlan_StudyPlanType");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.StudyPlan)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_StudyPlan_Video");
            });

            modelBuilder.Entity<StudyPlanDay>(entity =>
            {
                entity.HasKey(e => new { e.StudyPlanId, e.Day });

                entity.HasOne(d => d.PrimarySpecialty)
                    .WithMany(p => p.StudyPlanDayPrimarySpecialty)
                    .HasForeignKey(d => d.PrimarySpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyPlanDay_PrimarySubspecialty");

                entity.HasOne(d => d.SecondarySpecialty)
                    .WithMany(p => p.StudyPlanDaySecondarySpecialty)
                    .HasForeignKey(d => d.SecondarySpecialtyId)
                    .HasConstraintName("FK_StudyPlanDay_SecondarySubspecialty");

                entity.HasOne(d => d.StudyPlan)
                    .WithMany(p => p.StudyPlanDay)
                    .HasForeignKey(d => d.StudyPlanId)
                    .HasConstraintName("FK_StudyPlanDay_StudyPlan");
            });

            modelBuilder.Entity<StudyPlanSubTypes>(entity =>
            {
                entity.HasKey(e => e.StudyPlanSubTypeId);

                entity.Property(e => e.StudyPlanSubTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.StudyPlanSubTypes)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyPlanSubType_StudyPlanType");
            });

            modelBuilder.Entity<StudyPlanTypes>(entity =>
            {
                entity.HasKey(e => e.StudyPlanTypeId);

                entity.Property(e => e.StudyPlanTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubspecialityNeeded>(entity =>
            {
                entity.ToTable("SubspecialityNeeded", "jobbank");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subspecialty>(entity =>
            {
                entity.Property(e => e.GroupingKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(10);

                entity.Property(e => e.Sortorder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.Subspecialty)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subspecialty_Specialty");
            });

            modelBuilder.Entity<TechniqueMap>(entity =>
            {
                entity.ToTable("TechniqueMap", "technique");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.TechniqueMap)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueMap_Subspecialty");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TechniqueMap)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_TechniqueMap_Topic");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.NewTest)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalTest)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.QuestionSourceCategory)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.QuestionSourceCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_QuestionSourceCategory");
            });

            modelBuilder.Entity<Testmonial>(entity =>
            {
                entity.Property(e => e.AuthorName).HasMaxLength(50);

                entity.Property(e => e.AuthorPhotoUrl).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Tag).HasMaxLength(50);

                entity.Property(e => e.TestmonialDate).HasColumnType("date");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Testmonial)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Testmonial_Users");
            });

            modelBuilder.Entity<TestQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.HasIndex(e => e.LockedBy);

                entity.HasIndex(e => e.ReleaseDate)
                    .HasName("ix_TestQuestion_ReleaseDate");

                entity.HasIndex(e => e.TestId)
                    .HasName("IX_TestID");

                entity.HasIndex(e => e.TopicId)
                    .HasName("IX_TopicID");

                entity.HasIndex(e => new { e.QuestionId, e.Answer, e.TopicId })
                    .HasName("_dta_index_TestQuestion_OB_892");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.Answer1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Answer5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BlockedFromRelease).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.Illustration1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Illustration2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Illustration3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Illustration4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Illustration5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Illustration6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId1)
                    .HasColumnName("ImageID1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId2)
                    .HasColumnName("ImageID2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId3)
                    .HasColumnName("ImageID3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId4)
                    .HasColumnName("ImageID4")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId5)
                    .HasColumnName("ImageID5")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId6)
                    .HasColumnName("ImageID6")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsOriginalImagesShow).HasDefaultValueSql("((1))");

                entity.Property(e => e.LockedOn).HasColumnType("datetime");

                entity.Property(e => e.Oanswer).HasColumnName("OAnswer");

                entity.Property(e => e.Oanswer1)
                    .HasColumnName("OAnswer1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oanswer2)
                    .HasColumnName("OAnswer2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oanswer3)
                    .HasColumnName("OAnswer3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oanswer4)
                    .HasColumnName("OAnswer4")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oanswer5)
                    .HasColumnName("OAnswer5")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Odiscussion).HasColumnName("ODiscussion");

                entity.Property(e => e.Oillustration1)
                    .HasColumnName("OIllustration1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oillustration2)
                    .HasColumnName("OIllustration2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oillustration3)
                    .HasColumnName("OIllustration3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OimageUrl1)
                    .HasColumnName("OImageURL1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OimageUrl2)
                    .HasColumnName("OImageURL2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OimageUrl3)
                    .HasColumnName("OImageURL3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OimageUrl4)
                    .HasColumnName("OImageURL4")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OimageUrl5)
                    .HasColumnName("OImageURL5")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OimageUrl6)
                    .HasColumnName("OImageURL6")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OquestionText)
                    .HasColumnName("OQuestionText")
                    .IsUnicode(false);

                entity.Property(e => e.Oreference2)
                    .HasColumnName("OReference2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oreference3)
                    .HasColumnName("OReference3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oreference4)
                    .HasColumnName("OReference4")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalHtml)
                    .HasColumnName("OriginalHTML")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.OwnerUpdated).HasColumnType("datetime");

                entity.Property(e => e.Pmid2)
                    .HasColumnName("PMID2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmid3)
                    .HasColumnName("PMID3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmid4)
                    .HasColumnName("PMID4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmid5)
                    .HasColumnName("PMID5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pmid6)
                    .HasColumnName("PMID6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionText).IsUnicode(false);

                entity.Property(e => e.Reference1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReferencePdf2).HasColumnName("ReferencePDF2");

                entity.Property(e => e.ReferencePdf3).HasColumnName("ReferencePDF3");

                entity.Property(e => e.ReferencePdf4).HasColumnName("ReferencePDF4");

                entity.Property(e => e.ReferencePdf5).HasColumnName("ReferencePDF5");

                entity.Property(e => e.ReferencePdf6).HasColumnName("ReferencePDF6");

                entity.Property(e => e.ReferenceType2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceType3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceType4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceType5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceType6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.TestQuestionFlagId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Video1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Video2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Focus)
                    .WithMany(p => p.TestQuestion)
                    .HasForeignKey(d => d.FocusId)
                    .HasConstraintName("FK_TestQuestion_Focus");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.TestQuestion)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_TestQuestion_Level");

                entity.HasOne(d => d.ReferencedToNavigation)
                    .WithMany(p => p.InverseReferencedToNavigation)
                    .HasForeignKey(d => d.ReferencedTo)
                    .HasConstraintName("FK_ReferencedTo_TestQuestion");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestQuestion)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_TestQuestion_Test");

                entity.HasOne(d => d.TestQuestionFlag)
                    .WithMany(p => p.TestQuestion)
                    .HasForeignKey(d => d.TestQuestionFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestion_TestQuestionFlag");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TestQuestion)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_TestQuestion_Topic");
            });

            modelBuilder.Entity<TestQuestionFlag>(entity =>
            {
                entity.Property(e => e.TestQuestionFlagId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TestQuestionFlagAndPermission>(entity =>
            {
                entity.HasKey(e => new { e.TestQuestionFlagId, e.PermissionId });

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.TestQuestionFlagAndPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionFlagAndPermission_Permission");
            });

            modelBuilder.Entity<TestQuestionFlagLog>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.TestQuestionFlag)
                    .WithMany(p => p.TestQuestionFlagLog)
                    .HasForeignKey(d => d.TestQuestionFlagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionFlagLog_TestQuestionFlag");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TestQuestionFlagLog)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionFlagLog_Users");
            });

            modelBuilder.Entity<TestQuestionLevelHistory>(entity =>
            {
                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.HasOne(d => d.ChangedBy)
                    .WithMany(p => p.TestQuestionLevelHistory)
                    .HasForeignKey(d => d.ChangedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionLevelHistory_User");

                entity.HasOne(d => d.CurentLevel)
                    .WithMany(p => p.TestQuestionLevelHistoryCurentLevel)
                    .HasForeignKey(d => d.CurentLevelId)
                    .HasConstraintName("FK_TestQuestionLevelHistory_CurLevel");

                entity.HasOne(d => d.PrevLevel)
                    .WithMany(p => p.TestQuestionLevelHistoryPrevLevel)
                    .HasForeignKey(d => d.PrevLevelId)
                    .HasConstraintName("FK_TestQuestionLevelHistory_PrevLevel");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TestQuestionLevelHistory)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionLevelHistory_TestQuestion");
            });

            modelBuilder.Entity<TestQuestionNote>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsHighlight).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (1) else (0) end,(0)))");

                entity.Property(e => e.IsNote).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (0) else (1) end,(0)))");

                entity.Property(e => e.IsPreferendSection).HasDefaultValueSql("((1))");

                entity.Property(e => e.OriginalMd5)
                    .IsRequired()
                    .HasColumnType("binary(16)");

                entity.Property(e => e.RangySelection).IsRequired();

                entity.Property(e => e.Style).HasMaxLength(250);

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.TestQuestionNote)
                    .HasForeignKey(d => d.SpecialtyId)
                    .HasConstraintName("FK_TestQuestionNote_Specialty");

                entity.HasOne(d => d.TestQuestion)
                    .WithMany(p => p.TestQuestionNote)
                    .HasForeignKey(d => d.TestQuestionId)
                    .HasConstraintName("FK_TestQuestionNote_TestQuestion");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TestQuestionNote)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TestQuestionNote_Users");
            });

            modelBuilder.Entity<TestQuestionNoteFile>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BacketPath)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.TestQuestionNote)
                    .WithMany(p => p.TestQuestionNoteFile)
                    .HasForeignKey(d => d.TestQuestionNoteId)
                    .HasConstraintName("FK_TestQuestionNoteFile_TestQuestionNote");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TestQuestionNoteFile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionNoteFile_Users");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasIndex(e => new { e.Title, e.TopicId, e.SubspecialtyId })
                    .HasName("Topic_TopicID_SubspecialtyID_INCLUDE_Title_Index");

                entity.HasIndex(e => new { e.TopicId, e.Title, e.SubspecialtyId })
                    .HasName("Topic_SubspecialtyID_INCLUDE_TITLE_Index");

                entity.Property(e => e.TopicId)
                    .HasColumnName("TopicID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CheckAaoscomp).HasColumnName("checkAAOSComp");

                entity.Property(e => e.CheckBoardsWards).HasColumnName("checkBoardsWards");

                entity.Property(e => e.CheckClinMicrobio).HasColumnName("checkClinMicrobio");

                entity.Property(e => e.CheckCrush2).HasColumnName("checkCrush2");

                entity.Property(e => e.CheckFirstAid1).HasColumnName("checkFirstAid1");

                entity.Property(e => e.CheckFirstAid2).HasColumnName("checkFirstAid2");

                entity.Property(e => e.CheckFormatingAndSpellCheck1).HasColumnName("checkFormatingAndSpellCheck1");

                entity.Property(e => e.CheckGoljanRapid).HasColumnName("checkGoljanRapid");

                entity.Property(e => e.CheckGoljanRapid2).HasColumnName("checkGoljanRapid2");

                entity.Property(e => e.CheckKaplanMed1).HasColumnName("checkKaplanMed1");

                entity.Property(e => e.CheckKaplanMed2).HasColumnName("checkKaplanMed2");

                entity.Property(e => e.CheckKatzungPharma).HasColumnName("checkKatzungPharma");

                entity.Property(e => e.CheckKeyImage1).HasColumnName("checkKeyImage1");

                entity.Property(e => e.CheckMiller5).HasColumnName("checkMiller5");

                entity.Property(e => e.CheckOitequestions).HasColumnName("checkOITEQuestions");

                entity.Property(e => e.CheckOku9).HasColumnName("checkOKU9");

                entity.Property(e => e.CheckOther2).HasColumnName("checkOther2");

                entity.Property(e => e.CheckQuestionAndImages).HasColumnName("checkQuestionAndImages");

                entity.Property(e => e.CheckSaquestions).HasColumnName("checkSAQuestions");

                entity.Property(e => e.CheckSpellcheck).HasColumnName("checkSpellcheck");

                entity.Property(e => e.CheckVideo1).HasColumnName("checkVideo1");

                entity.Property(e => e.CheckVideo2).HasColumnName("checkVideo2");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.LockedOn).HasColumnType("datetime");

                entity.Property(e => e.QuestionsLinked).HasColumnName("questionsLinked");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.Topic)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Topic_Subspecialty");
            });

            modelBuilder.Entity<TopicHistory>(entity =>
            {
                entity.ToTable("TopicHistory", "orthobullets");

                entity.Property(e => e.TopicHistoryId).HasColumnName("TopicHistoryID");

                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TopicNote>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsHighlight).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (1) else (0) end,(0)))");

                entity.Property(e => e.IsNote).HasComputedColumnSql("(CONVERT([bit],case when [Text] IS NULL then (0) else (1) end,(0)))");

                entity.Property(e => e.OriginalMd5)
                    .IsRequired()
                    .HasColumnType("binary(16)");

                entity.Property(e => e.RangySelection).IsRequired();

                entity.Property(e => e.Style).HasMaxLength(250);

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.TopicNote)
                    .HasForeignKey(d => d.SpecialtyId)
                    .HasConstraintName("FK_TopicNote_Specialty");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TopicNote)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_TopicNote_Topic");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TopicNote)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TopicNote_Users");
            });

            modelBuilder.Entity<TopicNoteFile>(entity =>
            {
                entity.Property(e => e.ActionDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BacketPath)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.TopicNote)
                    .WithMany(p => p.TopicNoteFile)
                    .HasForeignKey(d => d.TopicNoteId)
                    .HasConstraintName("FK_TopicNoteFile_TopicNote");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TopicNoteFile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicNoteFile_Users");
            });

            modelBuilder.Entity<TopicPassPeakSummary>(entity =>
            {
                entity.HasKey(e => new { e.TopicId, e.UserId });

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnName("row_version")
                    .IsRowVersion();

                entity.Property(e => e.TopicUpdatedAt).HasColumnName("topic_updated_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserUpdatedAt).HasColumnName("user_updated_at");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TopicPassPeakSummary)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicPassPeakSummary_Topic");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TopicPassPeakSummary)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicPassPeakSummary_Users");
            });

            modelBuilder.Entity<TopicSection>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.TopicSection)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicSection_Subspecialty");
            });

            modelBuilder.Entity<TopicTopicLink>(entity =>
            {
                entity.HasKey(e => new { e.TopicId, e.LinkToTopicId });

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LinkToTopic)
                    .WithMany(p => p.TopicTopicLinkLinkToTopic)
                    .HasForeignKey(d => d.LinkToTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicTopicLink_Topic1");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.TopicTopicLinkTopic)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TopicTopicLink_Topic");
            });

            modelBuilder.Entity<TraumaLevels>(entity =>
            {
                entity.ToTable("TraumaLevels", "jobbank");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.LoadedBy)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Logourl).HasMaxLength(200);

                entity.Property(e => e.Opeid).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.UniversityName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Website).HasMaxLength(200);

                entity.Property(e => e.Zipcode).HasMaxLength(10);
            });

            modelBuilder.Entity<UploadFileType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<UsaState>(entity =>
            {
                entity.ToTable("USA_State", "jobbank");

                entity.Property(e => e.Id)
                    .HasColumnType("nchar(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnType("nchar(50)");
            });

            modelBuilder.Entity<UserAndDisabledQuestionCriteria>(entity =>
            {
                entity.Property(e => e.CriteriaType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.UserAndDisabledQuestionCriteria)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAndDisabledQuestionCriteria_Specialty");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAndDisabledQuestionCriteria)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAndDisabledQuestionCriteria_User");
            });

            modelBuilder.Entity<UserAndEliminatedAnswer>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("userandeliminatedanswer_userid_idx");

                entity.Property(e => e.TestId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAndEliminatedAnswer)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAndEliminatedAnswer_Users");
            });

            modelBuilder.Entity<Userandproduct>(entity =>
            {
                entity.ToTable("userandproduct");

                entity.HasIndex(e => e.TxnId)
                    .HasName("userandproduct_txn_id_uniq")
                    .IsUnique();

                entity.Property(e => e.Userandproductid).HasColumnName("userandproductid");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(1000);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Invoicedate)
                    .HasColumnName("invoicedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentTxnId)
                    .HasColumnName("parent_txn_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayerEmail)
                    .HasColumnName("payer_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentdate)
                    .HasColumnName("paymentdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentfee)
                    .HasColumnName("paymentfee")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Paymentgross)
                    .HasColumnName("paymentgross")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Paymentmethod)
                    .HasColumnName("paymentmethod")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TxnId)
                    .HasColumnName("txn_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Userandproduct)
                    .HasForeignKey(d => d.Productid)
                    .HasConstraintName("userandproduct_productid_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userandproduct)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userandproduct_userid_fk");
            });

            modelBuilder.Entity<UserAndRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserAndRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAndRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAndRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAndRole_Users");
            });

            modelBuilder.Entity<UserArticleTagged>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.UserId });

                entity.ToTable("UserArticleTagged", "orthobullets");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01')");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.UserArticleTagged)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserArticleTagged_Article");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserArticleTagged)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserArticleTagged_User");
            });

            modelBuilder.Entity<UserCaseTagged>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.UserId });

                entity.ToTable("UserCaseTagged", "orthobullets");

                entity.Property(e => e.Timestamp).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.UserCaseTagged)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_UserCaseTagged_Case");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCaseTagged)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserCaseTagged_Users");
            });

            modelBuilder.Entity<UserCommentSubscriptions>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.FeatureId, e.FeatureType })
                    .HasName("IX_UserCommentSubscriptions")
                    .IsUnique();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.LastOptOutDate).HasColumnType("datetime");

                entity.HasOne(d => d.FeatureTypeNavigation)
                    .WithMany(p => p.UserCommentSubscriptions)
                    .HasForeignKey(d => d.FeatureType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCommentSubscriptions_EmailNotificationFeature");
            });

            modelBuilder.Entity<UserFellowship>(entity =>
            {
                entity.HasOne(d => d.Fellowship)
                    .WithMany(p => p.UserFellowship)
                    .HasForeignKey(d => d.FellowshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFellowship_Fellowship");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFellowship)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserFellowship_Users");
            });

            modelBuilder.Entity<UserInternship>(entity =>
            {
                entity.HasOne(d => d.Internship)
                    .WithMany(p => p.UserInternship)
                    .HasForeignKey(d => d.InternshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInternship_Internship");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserInternship)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInternship_Users");
            });

            modelBuilder.Entity<UserMedia>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.UserMedia)
                    .HasForeignKey(d => d.MediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedia_Media");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMedia)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedia_Users");
            });

            modelBuilder.Entity<UserMedicalSchool>(entity =>
            {
                entity.Property(e => e.Degree).HasMaxLength(50);

                entity.Property(e => e.Details).HasMaxLength(50);

                entity.Property(e => e.YearOfGraduation).HasColumnType("date");

                entity.HasOne(d => d.MedicalSchool)
                    .WithMany(p => p.UserMedicalSchool)
                    .HasForeignKey(d => d.MedicalSchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalSchool_Education");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMedicalSchool)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMedicalSchool_Users");
            });

            modelBuilder.Entity<UserNotification>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserNotification", "orthobullets");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvalRequest).HasDefaultValueSql("((1))");

                entity.Property(e => e.SkillRequest).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UserProcedure>(entity =>
            {
                entity.ToTable("UserProcedure", "mdx");

                entity.Property(e => e.Started).HasColumnType("date");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.UserProcedure)
                    .HasForeignKey(d => d.ProcedureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProcedure_Procedure");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProcedure)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProcedure_Users");
            });

            modelBuilder.Entity<UserProductSentEmails>(entity =>
            {
                entity.HasKey(e => e.UserProductSentEmailId);

                entity.HasOne(d => d.EmailSent)
                    .WithMany(p => p.UserProductSentEmails)
                    .HasForeignKey(d => d.EmailSentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductSentEmails_EmailSent");

                entity.HasOne(d => d.UserAndProduct)
                    .WithMany(p => p.UserProductSentEmails)
                    .HasForeignKey(d => d.UserAndProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductSentEmails_UserAndProduct");
            });

            modelBuilder.Entity<UserProductSentMessages>(entity =>
            {
                entity.HasKey(e => e.UserProductSentMessageId);

                entity.HasOne(d => d.MessageSent)
                    .WithMany(p => p.UserProductSentMessages)
                    .HasForeignKey(d => d.MessageSentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductSentMessages_Message");

                entity.HasOne(d => d.UserAndProduct)
                    .WithMany(p => p.UserProductSentMessages)
                    .HasForeignKey(d => d.UserAndProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProductSentMessages_UserAndProduct");
            });

            modelBuilder.Entity<UserProfileInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserProfileInfo", "orthobullets");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Biography).IsUnicode(false);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PracticeEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PrivAddress).HasColumnName("privAddress");

                entity.Property(e => e.PrivCellPhone).HasColumnName("privCellPhone");

                entity.Property(e => e.PrivOfficePhone).HasColumnName("privOfficePhone");

                entity.Property(e => e.PrivPersonalEmail).HasColumnName("privPersonalEmail");

                entity.Property(e => e.PrivPracticeEmail).HasColumnName("privPracticeEmail");

                entity.Property(e => e.PrivResearch).HasColumnName("privResearch");

                entity.Property(e => e.PrivVolunteer).HasColumnName("privVolunteer");

                entity.Property(e => e.PrivWebsite).HasColumnName("privWebsite");

                entity.Property(e => e.Research)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Volunteer)
                    .HasMaxLength(2500)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserPublication>(entity =>
            {
                entity.HasOne(d => d.Post)
                    .WithMany(p => p.UserPublication)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPublication_Post");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPublication)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPublication_Users");
            });

            modelBuilder.Entity<UserResidency>(entity =>
            {
                entity.HasOne(d => d.Residency)
                    .WithMany(p => p.UserResidency)
                    .HasForeignKey(d => d.ResidencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserResidency_Residency");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserResidency)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserResidency_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.UserId)
                    .HasName("_dta_index_Users_OB_892");

                entity.HasIndex(e => new { e.Firstname, e.Lastname, e.UserId })
                    .HasName("Users_UserID_INCLUDE_Firstname_Lastname_Index");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fellowship)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GraduationYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Internship).HasMaxLength(200);

                entity.Property(e => e.LandingPage)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalSchool)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrivFellowship).HasColumnName("privFellowship");

                entity.Property(e => e.PrivFirstname).HasColumnName("privFirstname");

                entity.Property(e => e.PrivInternship).HasColumnName("privInternship");

                entity.Property(e => e.PrivLastname).HasColumnName("privLastname");

                entity.Property(e => e.PrivLocation).HasColumnName("privLocation");

                entity.Property(e => e.PrivPhoto).HasColumnName("privPhoto");

                entity.Property(e => e.PrivPosition).HasColumnName("privPosition");

                entity.Property(e => e.PrivResidency).HasColumnName("privResidency");

                entity.Property(e => e.PrivSchool).HasColumnName("privSchool");

                entity.Property(e => e.PrivSpecialty).HasColumnName("privSpecialty");

                entity.Property(e => e.PrivTitle).HasColumnName("privTitle");

                entity.Property(e => e.PrivUndergrad).HasColumnName("privUndergrad");

                entity.Property(e => e.ProfilePicture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerUrl)
                    .HasColumnName("ReferrerURL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerUrlsession)
                    .HasColumnName("ReferrerURLSession")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Residency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .HasColumnName("row_version")
                    .IsRowVersion();

                entity.Property(e => e.Specialty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Undergrad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsernameDisplay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SignupWebsite)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SignupWebsiteid)
                    .HasConstraintName("FK_Users_Website");
            });

            modelBuilder.Entity<UsersAndWebsite>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.WebsiteId })
                    .HasName("UsersAndWebsite_Unq")
                    .IsUnique();

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersAndWebsite)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersAndWebsite_Users");

                entity.HasOne(d => d.Website)
                    .WithMany(p => p.UsersAndWebsite)
                    .HasForeignKey(d => d.WebsiteId)
                    .HasConstraintName("FK_UsersAndWebsite_Website");
            });

            modelBuilder.Entity<UsersInFaculties>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GroupId });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersInFaculties)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersInFaculties_Users");
            });

            modelBuilder.Entity<UserSiteSettings>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserSiteSettings)
                    .HasForeignKey<UserSiteSettings>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSiteSettings_Users");
            });

            modelBuilder.Entity<UserTest>(entity =>
            {
                entity.HasKey(e => e.TestCode);

                entity.ToTable("UserTest", "orthobullets");

                entity.HasIndex(e => e.TestCodeId)
                    .HasName("IX_UserTest")
                    .IsUnique();

                entity.HasIndex(e => e.TestType)
                    .HasName("UserTest_TestType_Index");

                entity.HasIndex(e => new { e.TestCode, e.TimeAllowed, e.TestName, e.CreatedBy, e.TestType, e.CreatedOn })
                    .HasName("_dta_index_UserTest_OB_892");

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DiscardedByOwnerOn).HasColumnType("datetime");

                entity.Property(e => e.SpecialtyId).HasDefaultValueSql("((1))");

                entity.Property(e => e.TestCodeId).ValueGeneratedOnAdd();

                entity.Property(e => e.TestName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Specialty)
                    .WithMany(p => p.UserTest)
                    .HasForeignKey(d => d.SpecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserTest__Specia__31432D07");

                entity.HasOne(d => d.UserTestExamType)
                    .WithMany(p => p.UserTest)
                    .HasForeignKey(d => d.UserTestExamTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTest_UserTestExamType");
            });

            modelBuilder.Entity<UserTestExamType>(entity =>
            {
                entity.ToTable("UserTestExamType", "orthobullets");

                entity.Property(e => e.UserTestExamTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UserTestExamTypeEnum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserTestmonial>(entity =>
            {
                entity.HasOne(d => d.Testmonial)
                    .WithMany(p => p.UserTestmonial)
                    .HasForeignKey(d => d.TestmonialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTestmonial_Testmonial");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTestmonial)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTestmonial_Users");
            });

            modelBuilder.Entity<UserTestQuestion>(entity =>
            {
                entity.HasKey(e => new { e.TestCode, e.QuestionId });

                entity.ToTable("UserTestQuestion", "orthobullets");

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.UserTestQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTestQuestion_TestQuestion");
            });

            modelBuilder.Entity<UserTestQuestionTagged>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.UserId });

                entity.ToTable("UserTestQuestionTagged", "orthobullets");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1753-01-01')");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.UserTestQuestionTagged)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTestQuestionTagged_Question");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTestQuestionTagged)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTestQuestionTagged_User");
            });

            modelBuilder.Entity<UserTestQuestionTaken>(entity =>
            {
                entity.HasKey(e => new { e.TestCode, e.QuestionId, e.UserId });

                entity.ToTable("UserTestQuestionTaken", "orthobullets");

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.QuestionId, e.SelectedAnswer })
                    .HasName("UserTestQuestionTaken_QuestionID_SelectedAnswer_Index");

                entity.HasIndex(e => new { e.TestCode, e.QuestionId, e.SelectedAnswer })
                    .HasName("UserTestQuestionTaken_TestCode_Index");

                entity.HasIndex(e => new { e.UserId, e.QuestionId, e.SelectedAnswer, e.TestCode })
                    .HasName("_dta_index_UserTestQuestionTaken_OB_892_1");

                entity.HasIndex(e => new { e.UserId, e.TestCode, e.QuestionId, e.SelectedAnswer })
                    .HasName("_dta_index_UserTestQuestionTaken_OB_892_3");

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserTestQuestionTakenCalculated>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.SelectedAnswer });
            });

            modelBuilder.Entity<UserTestResults>(entity =>
            {
                entity.HasKey(e => new { e.TestCode, e.UserId });

                entity.ToTable("UserTestResults", "orthobullets");

                entity.HasIndex(e => new { e.StartedOn, e.CompletedOn, e.UserId, e.TestCode })
                    .HasName("_dta_index_UserTestResults_OB_892_4");

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.StartedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserTopicTagged>(entity =>
            {
                entity.HasKey(e => new { e.TopicId, e.UserId });

                entity.ToTable("UserTopicTagged", "orthobullets");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.UserTopicTagged)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTopicTagged_Topic");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTopicTagged)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserTopicTagged_User");
            });

            modelBuilder.Entity<UserUniversity>(entity =>
            {
                entity.Property(e => e.Degree).HasMaxLength(50);

                entity.Property(e => e.Details).HasMaxLength(50);

                entity.Property(e => e.YearOfGraduation).HasColumnType("date");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.UserUniversity)
                    .HasForeignKey(d => d.UniversityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserUniversity_University");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserUniversity)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserUniversity_Users");
            });

            modelBuilder.Entity<UserVideoTagged>(entity =>
            {
                entity.HasKey(e => new { e.VideoId, e.UserId });

                entity.ToTable("UserVideoTagged", "orthobullets");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserVideoTagged)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserVideoTagged_Users");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.UserVideoTagged)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_UserVideoTagged_Video");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.Property(e => e.Body)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.LecturedTopicSince).HasColumnType("datetime");

                entity.Property(e => e.OriginalSince).HasColumnType("datetime");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.TestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbnailUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoryType)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.CategoryTypeId)
                    .HasConstraintName("FK_Video_CategoryType");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Video_Group");

                entity.HasOne(d => d.PermissionTier)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.PermissionTierId)
                    .HasConstraintName("FK_Video_PermissionTier");

                entity.HasOne(d => d.ProcedureSkill)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.ProcedureSkillId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Video_ProcedureSkill");

                entity.HasOne(d => d.Subspecialty)
                    .WithMany(p => p.Video)
                    .HasForeignKey(d => d.SubspecialtyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Video_Subspecialty");
            });

            modelBuilder.Entity<VideoPresenter>(entity =>
            {
                entity.Property(e => e.VideoPresenterId).HasColumnName("VideoPresenterID");

                entity.Property(e => e.Questions).HasColumnType("nchar(500)");

                entity.Property(e => e.TimeStamp).HasColumnType("nchar(500)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoPresenter)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoPresenter_Users");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoPresenter)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoPresenter_Video");
            });

            modelBuilder.Entity<VideoQuestionTimeStamp>(entity =>
            {
                entity.Property(e => e.VideoQuestionTimeStampId).HasColumnName("VideoQuestionTimeStampID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.TimeStamp).HasColumnType("nchar(50)");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.VideoQuestionTimeStamp)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoQuestionTimeStamp_TestQuestion");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.VideoQuestionTimeStamp)
                    .HasForeignKey(d => d.VideoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoQuestionTimeStamp_Video");
            });

            modelBuilder.Entity<VideoTestSection>(entity =>
            {
                entity.Property(e => e.VideoTestSectionId).HasColumnName("VideoTestSectionID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.TestCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.VideoTestSection)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoTestSection_TestQuestion");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VideoTestSection)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VideoTestSection_Users");
            });

            modelBuilder.Entity<Website>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DfpPropertyCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('ca-pub-1186080565597341')");

                entity.Property(e => e.GoogleSearchEngineId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('011011587714199370644:-t-us8pwwfw')");

                entity.Property(e => e.Hostname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");
            });

            modelBuilder.HasSequence<int>("GeneratedTransactionsSequence").StartsAt(10000);
        }
    }
}
