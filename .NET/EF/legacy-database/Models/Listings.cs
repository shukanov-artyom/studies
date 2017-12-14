using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Listings
    {
        public int Id { get; set; }
        public string PracticeDepartmentName { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ContactName { get; set; }
        public string OfficePhone { get; set; }
        public string OfficeFax { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public int? PracticeType { get; set; }
        public int? PartnershipTrack { get; set; }
        public int? SubspecialityNeeded { get; set; }
        public int? TraumaLevel { get; set; }
        public string MinimumRequirements { get; set; }
        public string DateAvailable { get; set; }
        public string AdditionalComments { get; set; }
        public string OrganizationPosting { get; set; }
        public DateTime? DatePosted { get; set; }
        public bool? IsPosted { get; set; }
        public string ContactTitle { get; set; }
        public int UserId { get; set; }

        public PartnershipTracks PartnershipTrackNavigation { get; set; }
        public UsaState StateNavigation { get; set; }
        public TraumaLevels TraumaLevelNavigation { get; set; }
        public Users User { get; set; }
    }
}
