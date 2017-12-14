using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TestQuestionFlagAndPermission
    {
        public int PermissionId { get; set; }
        public int TestQuestionFlagId { get; set; }

        public Permission Permission { get; set; }
    }
}
