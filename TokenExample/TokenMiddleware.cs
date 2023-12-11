using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TokenExample
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext , MyToken token)
        {
            token.Email = "asd@gamil.com";
            token.Company = "Discount";
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class TokenMiddlewareExtensions
    {
        public static IApplicationBuilder UseTokenMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenMiddleware>();
        }
    }
}
