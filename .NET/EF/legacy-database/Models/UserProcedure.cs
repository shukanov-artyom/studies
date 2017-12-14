using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class UserProcedure
    {
        public int UserProcedureId { get; set; }
        public int UserId { get; set; }
        public int ProcedureId { get; set; }
        public DateTime Started { get; set; }

        public Procedure Procedure { get; set; }
        public Users User { get; set; }
    }
}
