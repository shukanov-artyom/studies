using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductAndTestQuestionFlagPermission
    {
        public int ProductAndTestQuestionFlagPermissionId { get; set; }
        public int ProductId { get; set; }
        public int TestQuestionFlagId { get; set; }

        public Product Product { get; set; }
        public TestQuestionFlag TestQuestionFlag { get; set; }
    }
}
