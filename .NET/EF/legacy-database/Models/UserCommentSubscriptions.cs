using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserCommentSubscriptions
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FeatureId { get; set; }
        public int FeatureType { get; set; }
        public bool Subscribe { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? LastOptOutDate { get; set; }

        public EmailNotificationFeature FeatureTypeNavigation { get; set; }
    }
}
