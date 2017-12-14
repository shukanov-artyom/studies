using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Case = new HashSet<Case>();
            ClustersTopics = new HashSet<ClustersTopics>();
            Comment = new HashSet<Comment>();
            Efootprint = new HashSet<Efootprint>();
            Image = new HashSet<Image>();
            Post = new HashSet<Post>();
            Procedure = new HashSet<Procedure>();
            ProcedureSkill = new HashSet<ProcedureSkill>();
            ProductLinkedTopics = new HashSet<ProductLinkedTopics>();
            Rating = new HashSet<Rating>();
            SelfProgressTopics = new HashSet<SelfProgressTopics>();
            TechniqueMap = new HashSet<TechniqueMap>();
            TestQuestion = new HashSet<TestQuestion>();
            TopicNote = new HashSet<TopicNote>();
            TopicPassPeakSummary = new HashSet<TopicPassPeakSummary>();
            TopicTopicLinkLinkToTopic = new HashSet<TopicTopicLink>();
            TopicTopicLinkTopic = new HashSet<TopicTopicLink>();
            UserTopicTagged = new HashSet<UserTopicTagged>();
        }

        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int? UserId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? LockedBy { get; set; }
        public bool? CheckMiller5 { get; set; }
        public bool? CheckOku9 { get; set; }
        public bool? CheckAaoscomp { get; set; }
        public bool? QuestionAndLinkCheck { get; set; }
        public bool? CheckOitequestions { get; set; }
        public bool? CheckSaquestions { get; set; }
        public bool? QuestionsLinked { get; set; }
        public DateTime? LockedOn { get; set; }
        public int? Position { get; set; }
        public int? Author2 { get; set; }
        public int? Author3 { get; set; }
        public string Color { get; set; }
        public bool? BlockedFromRelease { get; set; }
        public bool? IsTechniqueGuide { get; set; }
        public bool? IsMilestone { get; set; }
        public bool? IsCoreTopic { get; set; }
        public bool IsMarketingTopic { get; set; }
        public int SubspecialtyId { get; set; }
        public bool? CheckFirstAid1 { get; set; }
        public bool? CheckKaplanMed1 { get; set; }
        public bool? CheckGoljanRapid { get; set; }
        public bool? CheckKatzungPharma { get; set; }
        public bool? CheckClinMicrobio { get; set; }
        public bool? CheckFirstAid2 { get; set; }
        public bool? CheckKaplanMed2 { get; set; }
        public bool? CheckCrush2 { get; set; }
        public bool? CheckBoardsWards { get; set; }
        public bool? CheckGoljanRapid2 { get; set; }
        public bool? CheckSpellcheck { get; set; }
        public bool? CheckOther2 { get; set; }
        public bool? CheckVideo2 { get; set; }
        public bool? CheckQuestionAndImages { get; set; }
        public bool? CheckVideo1 { get; set; }
        public bool? CheckKeyImage1 { get; set; }
        public bool? CheckFormatingAndSpellCheck1 { get; set; }
        public DateTime UpdatedAt { get; set; }
        public byte[] RowVersion { get; set; }

        public Subspecialty Subspecialty { get; set; }
        public ICollection<Case> Case { get; set; }
        public ICollection<ClustersTopics> ClustersTopics { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Efootprint> Efootprint { get; set; }
        public ICollection<Image> Image { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<Procedure> Procedure { get; set; }
        public ICollection<ProcedureSkill> ProcedureSkill { get; set; }
        public ICollection<ProductLinkedTopics> ProductLinkedTopics { get; set; }
        public ICollection<Rating> Rating { get; set; }
        public ICollection<SelfProgressTopics> SelfProgressTopics { get; set; }
        public ICollection<TechniqueMap> TechniqueMap { get; set; }
        public ICollection<TestQuestion> TestQuestion { get; set; }
        public ICollection<TopicNote> TopicNote { get; set; }
        public ICollection<TopicPassPeakSummary> TopicPassPeakSummary { get; set; }
        public ICollection<TopicTopicLink> TopicTopicLinkLinkToTopic { get; set; }
        public ICollection<TopicTopicLink> TopicTopicLinkTopic { get; set; }
        public ICollection<UserTopicTagged> UserTopicTagged { get; set; }
    }
}
