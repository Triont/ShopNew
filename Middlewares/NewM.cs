using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using NewShopApp.Models;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using NewShopApp.ModelView;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace NewShopApp.Middlewares
{
    public class NewM
    {
        private readonly RequestDelegate requestDelegate;
        public NewM(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext httpContext )
        {
            if (httpContext.Request.IsHttps)
            {
              
               
                await requestDelegate.Invoke(httpContext);
            }
            else await httpContext.Response.WriteAsync("not safety");
           
        }
    }
}
