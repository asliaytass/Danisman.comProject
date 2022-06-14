using DanismanProject.Business.Abstract;
using DanismanProject.Business.Concrete;
using DanismanProject.Data.Abstract;
using DanismanProject.Data.Concrete.EfCore;
using DanismanProject.WebUI.EmailServices;
using DanismanProject.WebUI.Identity;
using DanismanProject.WebUI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI
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
            services.AddDbContext<ApplicationContext>(option => option.UseSqlite("Data Source=DanismanProjectDb"));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();




            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;

                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = true;
            });

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.SlidingExpiration = true;

                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name="DanismanProject.Security.Cookie",
                    SameSite= SameSiteMode.Strict
                };
            });

            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                 Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]
                ));

            services.AddScoped<IContactMessageService, ContactMessageManager>();
            services.AddScoped<IContactMessageRepository, EfCoreContactMessageRepository>();
            services.AddScoped<IJobService,JobManager>();
            services.AddScoped<IJobRepository, EfCoreJobRepository>();
            services.AddScoped<IAdvisorRepository, EfCoreAdvisorRepository>();
            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<IAdvisorService, AdvisorManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "adminuserlist",
                    pattern: "admin/user/list",
                    defaults: new { controller = "Admin", action = "UserList" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminusercreate",
                    pattern: "admin/user/create",
                    defaults: new { controller = "Admin", action = "UserCreate" }
                    );


                endpoints.MapControllerRoute(
                    name: "adminuserdelete",
                    pattern: "admin/user/{id}",
                    defaults: new { controller = "Admin", action = "UserDelete" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminuseredit",
                    pattern: "admin/userEdit/{id}",
                    defaults: new { controller = "Admin", action = "UserEdit" }
                    );


                endpoints.MapControllerRoute(
                    name: "adminrolelist",
                    pattern: "admin/role/list",
                    defaults: new { controller = "Admin", action = "RoleList" }
                    );
                endpoints.MapControllerRoute(
                name: "adminroldelete",
                pattern: "admin/roldelete/{id}",
                defaults: new { controller = "Admin", action = "UserDelete" }
                );

                endpoints.MapControllerRoute(
                    name: "adminrolecreate",
                    pattern: "admin/role/create",
                    defaults: new { controller = "Admin", action = "RoleCreate" }
                    );

                endpoints.MapControllerRoute(
                    name: "adminroleedit",
                    pattern: "admin/role/{id}",
                    defaults: new { controller = "Admin", action = "RoleEdit" }
                    );
              





                endpoints.MapControllerRoute(
                 name: "jobedit",
                 pattern: "admin/jobedit/{jobId}",
                 defaults: new { controller = "Admin", action = "JobEdit" }
                 );


                endpoints.MapControllerRoute(
                  name: "helpcontact",
                  pattern: "/HelpContact",
                  defaults: new { controller = "Home", action = "HelpContact" }
                  );
                   
                endpoints.MapControllerRoute(
                name: "adminpage",
                pattern: "/admin",
                defaults: new { controller = "Admin", action = "Index" }
                );

                //endpoints.MapControllerRoute(
                //name: "jobdetail",
                //pattern: "{jobname}",
                //defaults: new { controller = "Home", action = "JobDetail" }
                //);

                endpoints.MapControllerRoute(
               name: "advisordetail",
               pattern: "advisors/{advisorname}",
               defaults: new { controller = "Home", action = "AdvisorPage" }
               );

                


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();
        }
    }
}
