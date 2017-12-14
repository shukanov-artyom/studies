using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserFeatureEmailNotifications
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FeatureType { get; set; }
        public bool AllSpecialities { get; set; }
        public bool MySpeciality { get; set; }
        public bool MyAuthored { get; set; }
    }
}
