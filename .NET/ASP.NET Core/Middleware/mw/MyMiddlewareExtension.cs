using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace mw
{
    public static class MyMiddlewareExtension
    {
        public static void UseMyMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<MyMiddleware>();
        }
    }
}
