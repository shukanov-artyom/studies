using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PassFacultyAndGroupLocations
    {
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int GroupLocationId { get; set; }

        public Group Group { get; set; }
        public GroupLocation GroupLocation { get; set; }
        public Users User { get; set; }
    }
}
