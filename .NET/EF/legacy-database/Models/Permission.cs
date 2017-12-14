using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Permission
    {
        public Permission()
        {
            ExamAndPermission = new HashSet<ExamAndPermission>();
            RoleAndPermission = new HashSet<RoleAndPermission>();
            TestQuestionFlagAndPermission = new HashSet<TestQuestionFlagAndPermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; }

        public ICollection<ExamAndPermission> ExamAndPermission { get; set; }
        public ICollection<RoleAndPermission> RoleAndPermission { get; set; }
        public ICollection<TestQuestionFlagAndPermission> TestQuestionFlagAndPermission { get; set; }
    }
}
