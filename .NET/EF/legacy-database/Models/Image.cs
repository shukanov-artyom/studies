using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public int? TopicId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Filename { get; set; }
        public bool? Deleted { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int? QuestionId { get; set; }
        public int? ImageType { get; set; }
        public int? PostId { get; set; }
        public bool IsPrimary { get; set; }
        public int ImageOrder { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public Users CreatedByNavigation { get; set; }
        public Post Post { get; set; }
        public TestQuestion Question { get; set; }
        public Topic Topic { get; set; }
        public Users UpdatedByNavigation { get; set; }
    }
}
