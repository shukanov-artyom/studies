using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Post
    {
        public Post()
        {
            Comment = new HashSet<Comment>();
            FreePdfStatistics = new HashSet<FreePdfStatistics>();
            Image = new HashSet<Image>();
            PostNote = new HashSet<PostNote>();
            SelfProgressArticles = new HashSet<SelfProgressArticles>();
            UserArticleTagged = new HashSet<UserArticleTagged>();
            UserPublication = new HashSet<UserPublication>();
        }

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? GroupId { get; set; }
        public int? PostAs { get; set; }
        public int? CategoryId { get; set; }
        public int? TopicId { get; set; }
        public int? QuestionId { get; set; }
        public Guid? JournalClubId { get; set; }
        public string JournalPostAutors { get; set; }
        public string JournalName { get; set; }
        public string Pmid { get; set; }
        public bool? Tested { get; set; }
        public DateTime? PubDate { get; set; }
        public string FreePdfUrl { get; set; }
        public bool AutoCreated { get; set; }
        public string MedlineTa { get; set; }
        public int? PdfLicenseId { get; set; }
        public string Doi { get; set; }
        public string FullTextUrl { get; set; }
        public string EvidenceObjectiveAndMethods { get; set; }
        public string EvidenceResult { get; set; }
        public string EvidenceImpactAndConclusion { get; set; }
        public int PostType { get; set; }
        public string Isbn { get; set; }
        public int SubspecialtyId { get; set; }
        public int? CategoryTypeId { get; set; }
        public int? EvidenceTypeId { get; set; }
        public int? EvidenceLevel { get; set; }

        public CategoryType CategoryType { get; set; }
        public Users CreatedByNavigation { get; set; }
        public EvidenceType EvidenceType { get; set; }
        public Group Group { get; set; }
        public JournalClub JournalClub { get; set; }
        public PdfLicense PdfLicense { get; set; }
        public Post PostNavigation { get; set; }
        public TestQuestion Question { get; set; }
        public Subspecialty Subspecialty { get; set; }
        public Topic Topic { get; set; }
        public Post InversePostNavigation { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<FreePdfStatistics> FreePdfStatistics { get; set; }
        public ICollection<Image> Image { get; set; }
        public ICollection<PostNote> PostNote { get; set; }
        public ICollection<SelfProgressArticles> SelfProgressArticles { get; set; }
        public ICollection<UserArticleTagged> UserArticleTagged { get; set; }
        public ICollection<UserPublication> UserPublication { get; set; }
    }
}
