using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Auth
{
    public class ReadableBodyStream : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var username = context.HttpContext.User.Claims.First(claim => claim.Type == ClaimTypes.Name).Value;
            new ClaimContext(username);
        }
    }

    public class ClaimContext { 
        private static string _username;

        public ClaimContext(string username)
        {
            _username = username;
        }
        public static string UserName() 
        {
            return _username;
        }
    }
}
