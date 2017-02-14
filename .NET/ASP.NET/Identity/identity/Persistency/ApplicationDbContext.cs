using System;
using System.Data.Entity;
using identity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Persistency
{
    /// <summary>
    /// Customization of DB Context to Identity framework needs.
    /// Storage customization is a strong point of Identity.
    /// We use it here and in model classes.
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,
        ApplicationRole,
        long,
        ApplicationUserLogin,
        ApplicationUserRole,
        ApplicationUserClaim>
    {
        public ApplicationDbContext()
            : base(DatabaseConnectionData.ConnectionStringName)
        {
            // nothing yet.
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // overriding default names for Identity tables. 
            // we have out own guidelines for table naming
            // and we also have custom objects for Identity basic components.
            modelBuilder.Entity<ApplicationUser>()
                .ToTable("User");

            modelBuilder.Entity<ApplicationRole>()
                .ToTable("Role");

            modelBuilder.Entity<ApplicationUserRole>()
                .ToTable("UserRole");

            modelBuilder.Entity<ApplicationUserClaim>()
                .ToTable("UserClaim");

            modelBuilder.Entity<ApplicationUserLogin>()
                .ToTable("UserLogin");
        }
    }
}