using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PdfLicense
    {
        public PdfLicense()
        {
            Post = new HashSet<Post>();
        }

        public int PdfLicenseId { get; set; }
        public string PdfLicenseName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Post> Post { get; set; }
    }
}
