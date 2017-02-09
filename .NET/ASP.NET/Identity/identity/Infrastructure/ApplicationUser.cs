using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    /// <summary>
    /// This class instances will be persisted to database.
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        public string Country { get; set; }

        public int Age { get; set; }
    }
}