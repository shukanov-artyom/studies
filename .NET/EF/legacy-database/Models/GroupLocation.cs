using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class GroupLocation
    {
        public GroupLocation()
        {
            PassFacultyAndGroupLocations = new HashSet<PassFacultyAndGroupLocations>();
        }

        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }

        public Group Group { get; set; }
        public ICollection<PassFacultyAndGroupLocations> PassFacultyAndGroupLocations { get; set; }
    }
}
