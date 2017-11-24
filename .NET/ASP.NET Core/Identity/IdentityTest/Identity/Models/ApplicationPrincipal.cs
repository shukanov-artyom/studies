using System;
using System.Security.Claims;

namespace IdentCore.Identity.Models
{
    /// <summary>
    /// This class is used in Controllers and Views and is not persisted in Database.
    /// Actually it's just a wrapper for user's ClaimsPrincipal : IPrincipal.
    /// </summary>
    public class ApplicationPrincipal : ClaimsPrincipal
    {
        public ApplicationPrincipal(ClaimsPrincipal principal)
            : base(principal)
        {

        }

        public string Name => FindFirst(ClaimTypes.Name).Value;

        public string Country => FindFirst(ClaimTypes.Country).Value;

        // Name and Email are the same in our application.
        public string Email => FindFirst(ClaimTypes.Name).Value;
    }
}
