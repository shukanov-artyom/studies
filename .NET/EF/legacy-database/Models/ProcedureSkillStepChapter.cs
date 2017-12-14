﻿using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProcedureSkillStepChapter
    {
        public int ProcedureId { get; set; }
        public int ProcedureSkillId { get; set; }
        public int ChapterId { get; set; }
        public int ActionUserId { get; set; }
        public DateTime ActionDate { get; set; }

        public Users ActionUser { get; set; }
        public Procedure Procedure { get; set; }
        public ProcedureSkill ProcedureSkill { get; set; }
    }
}
