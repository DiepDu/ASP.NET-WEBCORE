﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using webcore.Areas.Admin.Extensions;

namespace webcore.Areas.Admin.Attributes
{
    public class AuthorizedAttribute : Attribute, IAuthorizationFilter
    {
        public string Code { get; set; } = "";
        public void OnAuthorization(AuthorizationFilterContext context)
        {
          List<string> codes = context.HttpContext.Session.GetObject<List<string>>("codes");
            if(codes.Count == 0 || !codes.Contains(Code))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}