using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class Role
    {
        public Role()
        {
            GroupAndRole = new HashSet<GroupAndRole>();
            ProductAndRole = new HashSet<ProductAndRole>();
            RoleAndPermission = new HashSet<RoleAndPermission>();
            UserAndRole = new HashSet<UserAndRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsSystemRole { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public Users CreatedByNavigation { get; set; }
        public ICollection<GroupAndRole> GroupAndRole { get; set; }
        public ICollection<ProductAndRole> ProductAndRole { get; set; }
        public ICollection<RoleAndPermission> RoleAndPermission { get; set; }
        public ICollection<UserAndRole> UserAndRole { get; set; }
    }
}
