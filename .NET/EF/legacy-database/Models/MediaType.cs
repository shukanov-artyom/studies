using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class MediaType
    {
        public MediaType()
        {
            Media = new HashSet<Media>();
        }

        public int MediaTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Media> Media { get; set; }
    }
}
