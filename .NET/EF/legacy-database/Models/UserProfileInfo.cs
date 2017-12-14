using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserProfileInfo
    {
        public int UserId { get; set; }
        public string Research { get; set; }
        public string Volunteer { get; set; }
        public string CellPhone { get; set; }
        public string OfficePhone { get; set; }
        public string PersonalEmail { get; set; }
        public string PracticeEmail { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public short? PrivResearch { get; set; }
        public short? PrivVolunteer { get; set; }
        public short? PrivCellPhone { get; set; }
        public short? PrivOfficePhone { get; set; }
        public short? PrivPersonalEmail { get; set; }
        public short? PrivPracticeEmail { get; set; }
        public short? PrivWebsite { get; set; }
        public short? PrivAddress { get; set; }
        public string Biography { get; set; }
        public string PracticeSummary { get; set; }
    }
}
