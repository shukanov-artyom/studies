using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ExamAndPermission
    {
        public int PermissionId { get; set; }
        public string TestCode { get; set; }

        public Permission Permission { get; set; }
    }
}
