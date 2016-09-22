using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace mw
{
    public class MyMiddleware
    {
        private readonly RequestDelegate next;

        public MyMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        /// <summary>
        /// RequestDelegate implementation which i return.
        /// Must be asynchronous!
        /// </summary>
        public async Task Invoke(HttpContext context)
        {
            context.Response.Headers["ARTYOM_BEGIN_HEADER"] = new StringValues("LALALA");
            await next.Invoke(context);
            context.Response.Headers["ARTYOM_END_HEADER"] = new StringValues("LALALA"); // этот хедер уже недоступен, потому что ответ ушёл до него!
        } 
    }
}
