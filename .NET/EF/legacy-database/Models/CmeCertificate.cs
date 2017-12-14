using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class CmeCertificate
    {
        public int CmeCertificateId { get; set; }
        public int UserId { get; set; }
        public string Filename { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CmeId { get; set; }

        public Cme Cme { get; set; }
        public Users User { get; set; }
    }
}
