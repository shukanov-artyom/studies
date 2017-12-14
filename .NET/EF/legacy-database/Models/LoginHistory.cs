using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class LoginHistory
    {
        public long LoginHistoryId { get; set; }
        public string SessionId { get; set; }
        public int? UserId { get; set; }
        public string UserIp { get; set; }
        public bool IsSuccessful { get; set; }
        public string Info { get; set; }
        public DateTime Timestamp { get; set; }
        public string RedirectingUrl { get; set; }
        public string RouteId { get; set; }
        public string Browser { get; set; }

        public Users User { get; set; }
    }
}
