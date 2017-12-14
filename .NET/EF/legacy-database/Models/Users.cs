using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Users
    {
        public Users()
        {
            AuthorsTeam = new HashSet<AuthorsTeam>();
            BiannualReportData = new HashSet<BiannualReportData>();
            BiannualReportKnowledgeRecord = new HashSet<BiannualReportKnowledgeRecord>();
            BiannualReportPracticeRecord = new HashSet<BiannualReportPracticeRecord>();
            BiannualReportUser = new HashSet<BiannualReportUser>();
            CaseCreatedByNavigation = new HashSet<Case>();
            CaseProctor = new HashSet<Case>();
            CaseShare = new HashSet<CaseShare>();
            CmeCertificate = new HashSet<CmeCertificate>();
            CmePostSurveyResults = new HashSet<CmePostSurveyResults>();
            ColleagueGroup = new HashSet<ColleagueGroup>();
            CommentReview = new HashSet<CommentReview>();
            EfootprintAuthor = new HashSet<Efootprint>();
            EfootprintAuthor2 = new HashSet<Efootprint>();
            EfootprintAuthor3 = new HashSet<Efootprint>();
            EfootprintRefs = new HashSet<EfootprintRefs>();
            EmailBlackList = new HashSet<EmailBlackList>();
            FreePdfStatistics = new HashSet<FreePdfStatistics>();
            HomepageVideo = new HashSet<HomepageVideo>();
            HospitalUser = new HashSet<HospitalUser>();
            ImageCreatedByNavigation = new HashSet<Image>();
            ImageUpdatedByNavigation = new HashSet<Image>();
            Listings = new HashSet<Listings>();
            LoginHistory = new HashSet<LoginHistory>();
            MilestoneReportRecords = new HashSet<MilestoneReportRecords>();
            MyGroups = new HashSet<MyGroups>();
            MyGroupsAndCategories = new HashSet<MyGroupsAndCategories>();
            OfficeUser = new HashSet<OfficeUser>();
            PassFacultyAndGroupLocations = new HashSet<PassFacultyAndGroupLocations>();
            PassUserScoresFaculty = new HashSet<PassUserScores>();
            PassUserScoresResident = new HashSet<PassUserScores>();
            Poll = new HashSet<Poll>();
            PollResult = new HashSet<PollResult>();
            Post = new HashSet<Post>();
            PostNote = new HashSet<PostNote>();
            PostNoteFile = new HashSet<PostNoteFile>();
            PracticeSubscription = new HashSet<PracticeSubscription>();
            PracticeSubspecialtyUser = new HashSet<PracticeSubspecialtyUser>();
            ProcedureSkillActionHistoryApprovedCccuser = new HashSet<ProcedureSkillActionHistory>();
            ProcedureSkillActionHistoryEnteredFacultyToGradeUser = new HashSet<ProcedureSkillActionHistory>();
            ProcedureSkillActionHistoryGradedFacultyUser = new HashSet<ProcedureSkillActionHistory>();
            ProcedureSkillActionHistoryUser = new HashSet<ProcedureSkillActionHistory>();
            ProcedureSkillStepChapter = new HashSet<ProcedureSkillStepChapter>();
            ProcedureSkillStepEvidence = new HashSet<ProcedureSkillStepEvidence>();
            ProcedureSkillStepNote = new HashSet<ProcedureSkillStepNote>();
            ProcedureSkillStepNoteFile = new HashSet<ProcedureSkillStepNoteFile>();
            ProcedureSkillStepProgress = new HashSet<ProcedureSkillStepProgress>();
            ProcedureSkillStepTagged = new HashSet<ProcedureSkillStepTagged>();
            ProcedureSkillTest = new HashSet<ProcedureSkillTest>();
            ProcedureSkillUserAction = new HashSet<ProcedureSkillUserAction>();
            ProcedureSkillVideo = new HashSet<ProcedureSkillVideo>();
            Product = new HashSet<Product>();
            Rating = new HashSet<Rating>();
            ReviewModeSlides = new HashSet<ReviewModeSlides>();
            Role = new HashSet<Role>();
            SelfProgressArticles = new HashSet<SelfProgressArticles>();
            SelfProgressQuestions = new HashSet<SelfProgressQuestions>();
            SelfProgressTopics = new HashSet<SelfProgressTopics>();
            SelfProgressVideo = new HashSet<SelfProgressVideo>();
            TestQuestionFlagLog = new HashSet<TestQuestionFlagLog>();
            TestQuestionLevelHistory = new HashSet<TestQuestionLevelHistory>();
            TestQuestionNote = new HashSet<TestQuestionNote>();
            TestQuestionNoteFile = new HashSet<TestQuestionNoteFile>();
            Testmonial = new HashSet<Testmonial>();
            TopicNote = new HashSet<TopicNote>();
            TopicNoteFile = new HashSet<TopicNoteFile>();
            TopicPassPeakSummary = new HashSet<TopicPassPeakSummary>();
            UserAndDisabledQuestionCriteria = new HashSet<UserAndDisabledQuestionCriteria>();
            UserAndEliminatedAnswer = new HashSet<UserAndEliminatedAnswer>();
            UserAndRole = new HashSet<UserAndRole>();
            UserArticleTagged = new HashSet<UserArticleTagged>();
            UserCaseTagged = new HashSet<UserCaseTagged>();
            UserFellowship = new HashSet<UserFellowship>();
            UserInternship = new HashSet<UserInternship>();
            UserMedia = new HashSet<UserMedia>();
            UserMedicalSchool = new HashSet<UserMedicalSchool>();
            UserProcedure = new HashSet<UserProcedure>();
            UserPublication = new HashSet<UserPublication>();
            UserResidency = new HashSet<UserResidency>();
            UserTestQuestionTagged = new HashSet<UserTestQuestionTagged>();
            UserTestmonial = new HashSet<UserTestmonial>();
            UserTopicTagged = new HashSet<UserTopicTagged>();
            UserUniversity = new HashSet<UserUniversity>();
            UserVideoTagged = new HashSet<UserVideoTagged>();
            Userandproduct = new HashSet<Userandproduct>();
            UsersAndWebsite = new HashSet<UsersAndWebsite>();
            UsersInFaculties = new HashSet<UsersInFaculties>();
            VideoPresenter = new HashSet<VideoPresenter>();
            VideoTestSection = new HashSet<VideoTestSection>();
        }

        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public int? CategoryId { get; set; }
        public string Country { get; set; }
        public string Position { get; set; }
        public string Specialty { get; set; }
        public string Location { get; set; }
        public string Guid { get; set; }
        public string ReferrerUrl { get; set; }
        public string ReferrerUrlsession { get; set; }
        public string LandingPage { get; set; }
        public string ZipCode { get; set; }
        public string Title { get; set; }
        public string Fellowship { get; set; }
        public string Residency { get; set; }
        public string MedicalSchool { get; set; }
        public string Undergrad { get; set; }
        public bool? EmailNotification { get; set; }
        public short? PrivFirstname { get; set; }
        public short? PrivLastname { get; set; }
        public short? PrivTitle { get; set; }
        public short? PrivLocation { get; set; }
        public short? PrivPosition { get; set; }
        public short? PrivSpecialty { get; set; }
        public short? PrivFellowship { get; set; }
        public short? PrivResidency { get; set; }
        public short? PrivSchool { get; set; }
        public short? PrivUndergrad { get; set; }
        public short? PrivPhoto { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UsernameDisplay { get; set; }
        public int? VerifiedBy { get; set; }
        public string GraduationYear { get; set; }
        public int? SignupWebsiteid { get; set; }
        public int? ResidencyStartYear { get; set; }
        public int? PracticeStartYear { get; set; }
        public bool IsNewFellowship { get; set; }
        public bool IsNewResidency { get; set; }
        public bool IsNewUndergrad { get; set; }
        public bool IsNewMedicalSchool { get; set; }
        public bool IsNewInternship { get; set; }
        public string Internship { get; set; }
        public short? PrivInternship { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte[] RowVersion { get; set; }

        public Website SignupWebsite { get; set; }
        public PassuserAndCompetencyLevel PassuserAndCompetencyLevel { get; set; }
        public UserSiteSettings UserSiteSettings { get; set; }
        public ICollection<AuthorsTeam> AuthorsTeam { get; set; }
        public ICollection<BiannualReportData> BiannualReportData { get; set; }
        public ICollection<BiannualReportKnowledgeRecord> BiannualReportKnowledgeRecord { get; set; }
        public ICollection<BiannualReportPracticeRecord> BiannualReportPracticeRecord { get; set; }
        public ICollection<BiannualReportUser> BiannualReportUser { get; set; }
        public ICollection<Case> CaseCreatedByNavigation { get; set; }
        public ICollection<Case> CaseProctor { get; set; }
        public ICollection<CaseShare> CaseShare { get; set; }
        public ICollection<CmeCertificate> CmeCertificate { get; set; }
        public ICollection<CmePostSurveyResults> CmePostSurveyResults { get; set; }
        public ICollection<ColleagueGroup> ColleagueGroup { get; set; }
        public ICollection<CommentReview> CommentReview { get; set; }
        public ICollection<Efootprint> EfootprintAuthor { get; set; }
        public ICollection<Efootprint> EfootprintAuthor2 { get; set; }
        public ICollection<Efootprint> EfootprintAuthor3 { get; set; }
        public ICollection<EfootprintRefs> EfootprintRefs { get; set; }
        public ICollection<EmailBlackList> EmailBlackList { get; set; }
        public ICollection<FreePdfStatistics> FreePdfStatistics { get; set; }
        public ICollection<HomepageVideo> HomepageVideo { get; set; }
        public ICollection<HospitalUser> HospitalUser { get; set; }
        public ICollection<Image> ImageCreatedByNavigation { get; set; }
        public ICollection<Image> ImageUpdatedByNavigation { get; set; }
        public ICollection<Listings> Listings { get; set; }
        public ICollection<LoginHistory> LoginHistory { get; set; }
        public ICollection<MilestoneReportRecords> MilestoneReportRecords { get; set; }
        public ICollection<MyGroups> MyGroups { get; set; }
        public ICollection<MyGroupsAndCategories> MyGroupsAndCategories { get; set; }
        public ICollection<OfficeUser> OfficeUser { get; set; }
        public ICollection<PassFacultyAndGroupLocations> PassFacultyAndGroupLocations { get; set; }
        public ICollection<PassUserScores> PassUserScoresFaculty { get; set; }
        public ICollection<PassUserScores> PassUserScoresResident { get; set; }
        public ICollection<Poll> Poll { get; set; }
        public ICollection<PollResult> PollResult { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<PostNote> PostNote { get; set; }
        public ICollection<PostNoteFile> PostNoteFile { get; set; }
        public ICollection<PracticeSubscription> PracticeSubscription { get; set; }
        public ICollection<PracticeSubspecialtyUser> PracticeSubspecialtyUser { get; set; }
        public ICollection<ProcedureSkillActionHistory> ProcedureSkillActionHistoryApprovedCccuser { get; set; }
        public ICollection<ProcedureSkillActionHistory> ProcedureSkillActionHistoryEnteredFacultyToGradeUser { get; set; }
        public ICollection<ProcedureSkillActionHistory> ProcedureSkillActionHistoryGradedFacultyUser { get; set; }
        public ICollection<ProcedureSkillActionHistory> ProcedureSkillActionHistoryUser { get; set; }
        public ICollection<ProcedureSkillStepChapter> ProcedureSkillStepChapter { get; set; }
        public ICollection<ProcedureSkillStepEvidence> ProcedureSkillStepEvidence { get; set; }
        public ICollection<ProcedureSkillStepNote> ProcedureSkillStepNote { get; set; }
        public ICollection<ProcedureSkillStepNoteFile> ProcedureSkillStepNoteFile { get; set; }
        public ICollection<ProcedureSkillStepProgress> ProcedureSkillStepProgress { get; set; }
        public ICollection<ProcedureSkillStepTagged> ProcedureSkillStepTagged { get; set; }
        public ICollection<ProcedureSkillTest> ProcedureSkillTest { get; set; }
        public ICollection<ProcedureSkillUserAction> ProcedureSkillUserAction { get; set; }
        public ICollection<ProcedureSkillVideo> ProcedureSkillVideo { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<Rating> Rating { get; set; }
        public ICollection<ReviewModeSlides> ReviewModeSlides { get; set; }
        public ICollection<Role> Role { get; set; }
        public ICollection<SelfProgressArticles> SelfProgressArticles { get; set; }
        public ICollection<SelfProgressQuestions> SelfProgressQuestions { get; set; }
        public ICollection<SelfProgressTopics> SelfProgressTopics { get; set; }
        public ICollection<SelfProgressVideo> SelfProgressVideo { get; set; }
        public ICollection<TestQuestionFlagLog> TestQuestionFlagLog { get; set; }
        public ICollection<TestQuestionLevelHistory> TestQuestionLevelHistory { get; set; }
        public ICollection<TestQuestionNote> TestQuestionNote { get; set; }
        public ICollection<TestQuestionNoteFile> TestQuestionNoteFile { get; set; }
        public ICollection<Testmonial> Testmonial { get; set; }
        public ICollection<TopicNote> TopicNote { get; set; }
        public ICollection<TopicNoteFile> TopicNoteFile { get; set; }
        public ICollection<TopicPassPeakSummary> TopicPassPeakSummary { get; set; }
        public ICollection<UserAndDisabledQuestionCriteria> UserAndDisabledQuestionCriteria { get; set; }
        public ICollection<UserAndEliminatedAnswer> UserAndEliminatedAnswer { get; set; }
        public ICollection<UserAndRole> UserAndRole { get; set; }
        public ICollection<UserArticleTagged> UserArticleTagged { get; set; }
        public ICollection<UserCaseTagged> UserCaseTagged { get; set; }
        public ICollection<UserFellowship> UserFellowship { get; set; }
        public ICollection<UserInternship> UserInternship { get; set; }
        public ICollection<UserMedia> UserMedia { get; set; }
        public ICollection<UserMedicalSchool> UserMedicalSchool { get; set; }
        public ICollection<UserProcedure> UserProcedure { get; set; }
        public ICollection<UserPublication> UserPublication { get; set; }
        public ICollection<UserResidency> UserResidency { get; set; }
        public ICollection<UserTestQuestionTagged> UserTestQuestionTagged { get; set; }
        public ICollection<UserTestmonial> UserTestmonial { get; set; }
        public ICollection<UserTopicTagged> UserTopicTagged { get; set; }
        public ICollection<UserUniversity> UserUniversity { get; set; }
        public ICollection<UserVideoTagged> UserVideoTagged { get; set; }
        public ICollection<Userandproduct> Userandproduct { get; set; }
        public ICollection<UsersAndWebsite> UsersAndWebsite { get; set; }
        public ICollection<UsersInFaculties> UsersInFaculties { get; set; }
        public ICollection<VideoPresenter> VideoPresenter { get; set; }
        public ICollection<VideoTestSection> VideoTestSection { get; set; }
    }
}
