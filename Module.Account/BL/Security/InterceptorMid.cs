using Microsoft.AspNetCore.Http;

namespace BL.Security
{
    public class InterceptorMid
    {
        private readonly RequestDelegate _next;

        public InterceptorMid(RequestDelegate next)
        {
            _next = next;
        }

        public async Task<Task> Invoke(HttpContext httpContext)
        {
            return _next(httpContext);
        }
    }
}