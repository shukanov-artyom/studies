using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureValidationEvidence
    {
        public int ProcedureValidationEvidenceId { get; set; }
        public string ValidationDescription { get; set; }
        public DateTime? EvidenceDate { get; set; }
        public byte[] Evidence { get; set; }
        public int ProcedureEvidenceTypeId { get; set; }
    }
}
