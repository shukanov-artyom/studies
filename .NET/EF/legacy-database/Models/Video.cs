using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Video
    {
        public Video()
        {
            Cme = new HashSet<Cme>();
            HomepageVideo = new HashSet<HomepageVideo>();
            ProcedureSkillVideo = new HashSet<ProcedureSkillVideo>();
            ProductAndVideoPermission = new HashSet<ProductAndVideoPermission>();
            ProductLinkedTests = new HashSet<ProductLinkedTests>();
            ProductLinkedVideos = new HashSet<ProductLinkedVideos>();
            SelfProgressVideo = new HashSet<SelfProgressVideo>();
            StudyPlan = new HashSet<StudyPlan>();
            UserVideoTagged = new HashSet<UserVideoTagged>();
            VideoPresenter = new HashSet<VideoPresenter>();
            VideoQuestionTimeStamp = new HashSet<VideoQuestionTimeStamp>();
        }

        public int VideoId { get; set; }
        public int? VideoType { get; set; }
        public string VideoLink { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? PostAs { get; set; }
        public int? CategoryId { get; set; }
        public int? TopicId { get; set; }
        public int? GroupId { get; set; }
        public int? QuestionId { get; set; }
        public string ThumbnailUrl { get; set; }
        public int? JobId { get; set; }
        public bool? IsOriginal { get; set; }
        public DateTime? OriginalSince { get; set; }
        public bool? IsLecturedTopic { get; set; }
        public DateTime? LecturedTopicSince { get; set; }
        public string TestCode { get; set; }
        public int? CategoryTypeId { get; set; }
        public bool Hidden { get; set; }
        public int? PermissionTierId { get; set; }
        public int? ProcedureSkillId { get; set; }
        public int SubspecialtyId { get; set; }

        public CategoryType CategoryType { get; set; }
        public Group Group { get; set; }
        public PermissionTier PermissionTier { get; set; }
        public ProcedureSkill ProcedureSkill { get; set; }
        public Subspecialty Subspecialty { get; set; }
        public ICollection<Cme> Cme { get; set; }
        public ICollection<HomepageVideo> HomepageVideo { get; set; }
        public ICollection<ProcedureSkillVideo> ProcedureSkillVideo { get; set; }
        public ICollection<ProductAndVideoPermission> ProductAndVideoPermission { get; set; }
        public ICollection<ProductLinkedTests> ProductLinkedTests { get; set; }
        public ICollection<ProductLinkedVideos> ProductLinkedVideos { get; set; }
        public ICollection<SelfProgressVideo> SelfProgressVideo { get; set; }
        public ICollection<StudyPlan> StudyPlan { get; set; }
        public ICollection<UserVideoTagged> UserVideoTagged { get; set; }
        public ICollection<VideoPresenter> VideoPresenter { get; set; }
        public ICollection<VideoQuestionTimeStamp> VideoQuestionTimeStamp { get; set; }
    }
}
