using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class PermissionTier
    {
        public PermissionTier()
        {
            Product = new HashSet<Product>();
            Video = new HashSet<Video>();
        }

        public int PermissionTierId { get; set; }
        public string PermissionTierName { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<Video> Video { get; set; }
    }
}
