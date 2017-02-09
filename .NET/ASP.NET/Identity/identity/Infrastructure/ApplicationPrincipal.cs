using System;
using System.Security.Claims;

namespace identity.Infrastructure
{
    /// <summary>
    /// This class is used in Controllers and Views and is not persisted in Database.
    /// Actually it's just a wrapper for user's Claims collection.
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
    }
}