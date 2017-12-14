using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassNotification
    {
        public int PassNotificationId { get; set; }
        public int GroupId { get; set; }
        public int BucketId { get; set; }
        public int? WeeklyPatternId { get; set; }
        public int? MonthlyPatternId { get; set; }
        public bool IsRecurrent { get; set; }
        public int? CustomNotificationTemplateId { get; set; }
        public int? DefaultNotificationTemplateId { get; set; }

        public RoleBuckets Bucket { get; set; }
        public NotificationTemplate CustomNotificationTemplate { get; set; }
        public NotificationTemplate DefaultNotificationTemplate { get; set; }
        public Group Group { get; set; }
        public MonthlyPattern MonthlyPattern { get; set; }
        public WeeklyPattern WeeklyPattern { get; set; }
    }
}
