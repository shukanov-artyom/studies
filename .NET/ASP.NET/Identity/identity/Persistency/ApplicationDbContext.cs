using System;
using identity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Persistency
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base(DatabaseConnectionData.ConnectionStringName)
        {
            
        }

        // TODO : call tables with their good names
    }
}