using System;
using System.Security.Claims;

namespace identity.Infrastructure
{
    /// <summary>
    /// This class is used in Controllers and Views and is not persisted in Database.
    /// Actually it's just a strongly-typed wrapper for user's ClaimsPrincipal : IPrincipal.
    /// </summary>
    public class ApplicationPrincipal : ClaimsPrincipal
    {
        public ApplicationPrincipal(ClaimsPrincipal principal)
            : base(principal)
        {
            
        }

        public string Name
        {
            get
            {
                return FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string Country
        {
            get
            {
                return FindFirst(ClaimTypes.Country).Value;
            }
        }

        public string Email
        {
            get
            {
                // Name and Email are the same in our application.
                return FindFirst(ClaimTypes.Name).Value;
            }
        }
    }
}