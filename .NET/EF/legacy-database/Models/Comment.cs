using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int? TopicId { get; set; }
        public string Text { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? ImageId { get; set; }
        public int? QuestionId { get; set; }
        public int? Type { get; set; }
        public int? TopicHistoryId { get; set; }
        public int? Level { get; set; }
        public bool? PublicComment { get; set; }
        public int? DirectedTo { get; set; }
        public int? CaseId { get; set; }
        public int? GroupId { get; set; }
        public int? PostId { get; set; }
        public int? PostAs { get; set; }
        public int? ItemId { get; set; }
        public int? ItemType { get; set; }
        public int? ParentItemId { get; set; }
        public int? ParentItemType { get; set; }
        public int? ProcedureSkillId { get; set; }

        public Case Case { get; set; }
        public Group Group { get; set; }
        public Post Post { get; set; }
        public ProcedureSkill ProcedureSkill { get; set; }
        public TestQuestion Question { get; set; }
        public Topic Topic { get; set; }
        public CommentReview CommentReview { get; set; }
    }
}
