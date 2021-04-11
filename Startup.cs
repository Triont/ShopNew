using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewShopApp.Services;
using Microsoft.Extensions.Hosting;
using NewShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShopApp.Middlewares;

namespace NewShopApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession(opt =>
            {
                opt.IdleTimeout = TimeSpan.FromHours(3);
                opt.Cookie.IsEssential = true;
            });
            services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            services.AddTransient<EmailSendService>();
            services.AddDbContext<OrderDbContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("ProductOrderConnection")));
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Latest).AddSessionStateTempDataProvider();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>

            {
                opt.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                opt.LogoutPath = new Microsoft.AspNetCore.Http.PathString("/Account/Logout");
            }
            
     );
            services.AddAuthorization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            
          

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            //  app.CreatePerOwinContext<SignInManager>(ApplicationSignInManager.Create);
            app.UseMiddleware<NewM>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
