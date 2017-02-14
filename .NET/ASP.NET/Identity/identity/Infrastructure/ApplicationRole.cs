using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    /// <summary>
    /// Override IdentityRole setting long as a primary key column type.
    /// </summary>
    public class ApplicationRole : IdentityRole<long, ApplicationUserRole>
    {
        public ApplicationRole()
        {

        }

        public ApplicationRole(string name)
            : this()
        {
            Name = name;
        }
    }
}