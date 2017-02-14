using System;
using identity.Persistency;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    /// <summary>
    /// Override IdentityUserLogin setting long as a primary key column type.
    /// </summary>
    public class ApplicationUserLogin : IdentityUserLogin<long>
    {
        
    }

    public class CustomRoleStore : RoleStore<ApplicationRole, long, ApplicationUserRole>
    {
        public CustomRoleStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}