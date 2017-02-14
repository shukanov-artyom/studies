using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace identity.Infrastructure
{
    public class SomeCustomClaim : IdentityUserClaim<long>
    {
    }
}