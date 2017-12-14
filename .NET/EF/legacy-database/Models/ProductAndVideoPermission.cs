using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class ProductAndVideoPermission
    {
        public int ProductAndVideoPermissionId { get; set; }
        public int ProductId { get; set; }
        public int VideoId { get; set; }

        public Product Product { get; set; }
        public Video Video { get; set; }
    }
}
