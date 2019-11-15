using Appliances.Models;
using Appliances.ViewModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Appliances
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } 
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
              
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            string connection = "Server=(localdb)\\mssqllocaldb;Database=UsersRoles;Trusted_Connection=True;";
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            services.AddTransient<IProduct, EFProductRepository>();

            _ = services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/Login");
                });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

  
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            { 
            
                routes.MapRoute(name: null, 
                    template: "{Category}/Page{productPage:int}"
                    , defaults: new { controller = "Home", action = "Index" } );
           
            routes.MapRoute(name: null, 
                template: "Page{productPage:int}"
                , defaults: new { controller = "Home",
                 action = "Index", productPage = 1 } ) ;
          
            routes.MapRoute(name: null,
           template:" {Category}" , defaults: new
            {controller = "Home",action ="Index",productPage = 1});

            routes.MapRoute(name: null,
         template: "", defaults: new
         { controller = "Home", action = "Index", productPage = 1 }) ;

            routes.MapRoute(
                    name: null,
                    template: "",
                    defaults:new {controller="Home",action="Index",productPage=1 });
                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            });
         
          // SeedData.EnsurePopulated(app);
        }
    }
}
