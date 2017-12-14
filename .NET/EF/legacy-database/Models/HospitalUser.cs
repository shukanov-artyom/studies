using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class HospitalUser
    {
        public int HospitalUserId { get; set; }
        public int HospitalId { get; set; }
        public int UserId { get; set; }
        public DateTime StartedYear { get; set; }
        public bool IsPrimary { get; set; }
        public string RoleDescription { get; set; }

        public Hospital Hospital { get; set; }
        public Users User { get; set; }
    }
}
