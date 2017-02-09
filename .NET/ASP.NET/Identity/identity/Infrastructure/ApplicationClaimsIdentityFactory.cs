using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace identity.Infrastructure
{
    /// <summary>
    /// It adds application-specific claims to a claims collection when creating it.
    /// Takes data from user instance.
    /// </summary>
    public class ApplicationClaimsIdentityFactory : ClaimsIdentityFactory<ApplicationUser>
    {
        public override async Task<ClaimsIdentity> CreateAsync(
            UserManager<ApplicationUser, string> userManager,
            ApplicationUser user, 
            string authenticationType)
        {
            ClaimsIdentity identity = await base.CreateAsync(userManager, user, authenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Country, user.Country));
            //something is converted to claims, something is left in ApplicationUser domain object.
            return identity;
        }
    }
}