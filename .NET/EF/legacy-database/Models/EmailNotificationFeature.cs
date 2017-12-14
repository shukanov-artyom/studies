using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class EmailNotificationFeature
    {
        public EmailNotificationFeature()
        {
            UserCommentSubscriptions = new HashSet<UserCommentSubscriptions>();
        }

        public int FeatureId { get; set; }
        public string Name { get; set; }

        public ICollection<UserCommentSubscriptions> UserCommentSubscriptions { get; set; }
    }
}
