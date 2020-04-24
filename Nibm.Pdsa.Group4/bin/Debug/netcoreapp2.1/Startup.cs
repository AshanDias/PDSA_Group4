using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nibm.Pdsa.Group4.Interface;
using Nibm.Pdsa.Group4.Models;
using Nibm.Pdsa.Group4.Service;

namespace Nibm.Pdsa.Group4
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();
            services.AddScoped<IShortestPath, ShortestPath>();
            services.AddScoped<IHashMapDistances, HashMapDistances>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IMSTService, MSTService>();
            services.AddScoped<IApplicationService, ApplicationService>();


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<ApplicationContext>(option => option.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://pdsa-ui.azurewebsites.net",
                                        "https://pdsa-ui.azurewebsites.net");
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                DbSeed.InitializePortle(serviceScope);
             
                // Seed the database.
            }

            //app.UseCors(options =>
            //           options
            //          .WithOrigins("https://pdsa-ui.azurewebsites.net")
            //         .AllowAnyMethod()
            //         .AllowAnyHeader().AllowAnyOrigin());

            //app.UseCors(option => option
            //.AllowAnyOrigin().AllowCredentials().AllowAnyHeader().AllowAnyMethod());
            app.UseCors(MyAllowSpecificOrigins);
            app.UseMvc();
        }
    }
}
