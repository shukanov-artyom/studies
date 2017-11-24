﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentCore2.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentCore2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>()
                .ToTable("User");
            builder.Entity<IdentityRole>()
                .ToTable("Role");
            builder.Entity<IdentityUserRole<string>>()
                .ToTable("UserRole");
            builder.Entity<IdentityUserClaim<string>>()
                .ToTable("UserClaim");
            builder.Entity<IdentityUserLogin<string>>()
                .ToTable("UserLogin");
            builder.Entity<IdentityRoleClaim<string>>()
                .ToTable("RoleClaim");
            builder.Entity<IdentityUserToken<string>>()
                .ToTable("UserToken");
        }
    }
}
