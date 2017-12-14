using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public int? TopicId { get; set; }
        public int? QuestionId { get; set; }
        public int Rating1 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ItemId { get; set; }
        public int? ItemType { get; set; }
        public int? PostId { get; set; }
        public int? SpecialtyId { get; set; }

        public Users CreatedByNavigation { get; set; }
        public TestQuestion Question { get; set; }
        public Specialty Specialty { get; set; }
        public Topic Topic { get; set; }
    }
}
