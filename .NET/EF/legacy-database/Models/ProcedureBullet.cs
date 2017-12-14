using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureBullet
    {
        public Guid Id { get; set; }
        public int ProcedureId { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int Order { get; set; }
        public string ItemClass { get; set; }

        public Procedure Procedure { get; set; }
    }
}
