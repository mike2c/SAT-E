using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Data.Data;
using Microsoft.EntityFrameworkCore;
using Service.Auth;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Application.Security;
using Microsoft.AspNetCore.Authorization;
using Core.Security;

namespace Application
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
            services
                .AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddDbContextFactory<SATContext>(options => 
                    options.UseSqlServer(Configuration.GetConnectionString("SATDatabase"))
                );

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Login/Login";
                    options.Cookie.Name = "SAT.UserData.Cookie";
                });

            services.AddAuthorization(options =>
                {
                    //options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    //.RequireAuthenticatedUser()
                    //.Build();
                });

            //services.AddTransient<AuthService>();
            services.AddTransient <IEncryptor, Sha256Encrypt>();
            services.AddTransient <SATContext>();
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
            }

            app.UseStaticFiles();
            app.UseRouting();

            CookiePolicyOptions cookiePolicyOptions = new CookiePolicyOptions()
            {
                MinimumSameSitePolicy = SameSiteMode.Strict
            };

            app.UseCookiePolicy(cookiePolicyOptions);

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}