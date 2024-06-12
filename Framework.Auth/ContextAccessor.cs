using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Framework.Auth
{
    public class ContextAccessor
    {
        public string UserName { get; set; }
        public ContextAccessor(IHttpContextAccessor contextAccessor)
        {
            UserName = contextAccessor.HttpContext.User.Claims.First().Value;
        }
    }
}