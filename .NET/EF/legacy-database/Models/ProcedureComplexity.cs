using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureComplexity
    {
        public ProcedureComplexity()
        {
            Procedure = new HashSet<Procedure>();
        }

        public int ProcedureComplexityId { get; set; }
        public string Name { get; set; }
        public int SpecialtyId { get; set; }

        public ICollection<Procedure> Procedure { get; set; }
    }
}
