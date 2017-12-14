using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class NotificationTemplate
    {
        public NotificationTemplate()
        {
            PassNotificationCustomNotificationTemplate = new HashSet<PassNotification>();
            PassNotificationDefaultNotificationTemplate = new HashSet<PassNotification>();
        }

        public int NotificationTemplateId { get; set; }
        public bool IsDefault { get; set; }
        public string MessageHtml { get; set; }
        public string MessageTxt { get; set; }
        public string FromAddress { get; set; }
        public string FromLabel { get; set; }
        public string Subject { get; set; }
        public string MessageName { get; set; }
        public string MessageType { get; set; }
        public string MessageDescription { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Active { get; set; }

        public ICollection<PassNotification> PassNotificationCustomNotificationTemplate { get; set; }
        public ICollection<PassNotification> PassNotificationDefaultNotificationTemplate { get; set; }
    }
}
