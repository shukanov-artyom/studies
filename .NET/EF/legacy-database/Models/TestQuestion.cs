using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TestQuestion
    {
        public TestQuestion()
        {
            Case = new HashSet<Case>();
            Comment = new HashSet<Comment>();
            Image = new HashSet<Image>();
            InverseReferencedToNavigation = new HashSet<TestQuestion>();
            Post = new HashSet<Post>();
            Rating = new HashSet<Rating>();
            ReviewModeSlides = new HashSet<ReviewModeSlides>();
            SelfProgressQuestions = new HashSet<SelfProgressQuestions>();
            TestQuestionLevelHistory = new HashSet<TestQuestionLevelHistory>();
            TestQuestionNote = new HashSet<TestQuestionNote>();
            UserTestQuestion = new HashSet<UserTestQuestion>();
            UserTestQuestionTagged = new HashSet<UserTestQuestionTagged>();
            VideoQuestionTimeStamp = new HashSet<VideoQuestionTimeStamp>();
            VideoTestSection = new HashSet<VideoTestSection>();
        }

        public int QuestionId { get; set; }
        public int? QuestionNumber { get; set; }
        public int? TestId { get; set; }
        public int? TopicId { get; set; }
        public string OriginalHtml { get; set; }
        public string QuestionText { get; set; }
        public int? Answer { get; set; }
        public string Discussion { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Answer5 { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public string Reference4 { get; set; }
        public string OquestionText { get; set; }
        public int? Oanswer { get; set; }
        public string Odiscussion { get; set; }
        public string Oanswer1 { get; set; }
        public string Oanswer2 { get; set; }
        public string Oanswer3 { get; set; }
        public string Oanswer4 { get; set; }
        public string Oanswer5 { get; set; }
        public string OimageUrl1 { get; set; }
        public string OimageUrl2 { get; set; }
        public string OimageUrl3 { get; set; }
        public string OimageUrl4 { get; set; }
        public string Oreference2 { get; set; }
        public string Oreference3 { get; set; }
        public string Oreference4 { get; set; }
        public string ImageId1 { get; set; }
        public string ImageId2 { get; set; }
        public string ImageId3 { get; set; }
        public string ImageId4 { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Oillustration1 { get; set; }
        public string Oillustration2 { get; set; }
        public string Oillustration3 { get; set; }
        public string Illustration1 { get; set; }
        public string Illustration2 { get; set; }
        public string Illustration3 { get; set; }
        public string OimageUrl5 { get; set; }
        public string OimageUrl6 { get; set; }
        public string ImageId5 { get; set; }
        public string ImageId6 { get; set; }
        public int? LockedBy { get; set; }
        public int? CompletedBy { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? LockedOn { get; set; }
        public bool? LinkedToTopic { get; set; }
        public string Pmid2 { get; set; }
        public string Pmid3 { get; set; }
        public string Pmid4 { get; set; }
        public string Pmid5 { get; set; }
        public string Reference5 { get; set; }
        public string Reference6 { get; set; }
        public string Pmid6 { get; set; }
        public string ReferenceType2 { get; set; }
        public string ReferenceType3 { get; set; }
        public string ReferenceType4 { get; set; }
        public string ReferenceType5 { get; set; }
        public string ReferenceType6 { get; set; }
        public string Illustration4 { get; set; }
        public string Illustration5 { get; set; }
        public string Illustration6 { get; set; }
        public int? OwnerId { get; set; }
        public DateTime? OwnerUpdated { get; set; }
        public int? CategoryId { get; set; }
        public string Video1 { get; set; }
        public string Video2 { get; set; }
        public bool? ReferencePdf2 { get; set; }
        public bool? ReferencePdf3 { get; set; }
        public bool? ReferencePdf4 { get; set; }
        public bool? ReferencePdf5 { get; set; }
        public bool? ReferencePdf6 { get; set; }
        public bool? BlockedFromRelease { get; set; }
        public bool? IsOriginalImagesShow { get; set; }
        public int? LevelId { get; set; }
        public int? FocusId { get; set; }
        public int TestQuestionFlagId { get; set; }
        public DateTime? TestQuestionFlagLastActionDate { get; set; }
        public int? ReferencedTo { get; set; }
        public int? VersionNumber { get; set; }
        public int? CoreQuestionId { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public Focus Focus { get; set; }
        public Level Level { get; set; }
        public TestQuestion ReferencedToNavigation { get; set; }
        public Test Test { get; set; }
        public TestQuestionFlag TestQuestionFlag { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Case> Case { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Image> Image { get; set; }
        public ICollection<TestQuestion> InverseReferencedToNavigation { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<Rating> Rating { get; set; }
        public ICollection<ReviewModeSlides> ReviewModeSlides { get; set; }
        public ICollection<SelfProgressQuestions> SelfProgressQuestions { get; set; }
        public ICollection<TestQuestionLevelHistory> TestQuestionLevelHistory { get; set; }
        public ICollection<TestQuestionNote> TestQuestionNote { get; set; }
        public ICollection<UserTestQuestion> UserTestQuestion { get; set; }
        public ICollection<UserTestQuestionTagged> UserTestQuestionTagged { get; set; }
        public ICollection<VideoQuestionTimeStamp> VideoQuestionTimeStamp { get; set; }
        public ICollection<VideoTestSection> VideoTestSection { get; set; }
    }
}
