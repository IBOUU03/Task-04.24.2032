using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.DataAccess;

namespace Task3
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
            services.AddControllersWithViews();

            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer("Server=LAPTOP-42S6SGKB;Database=Eter;Trusted_Connection=true");
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        "default",
                        "{controller=home}/{action=index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    "about",
                    "about-us",
                    defaults: new {controller = "home", action = "about"}
                    
                    );
                endpoints.MapControllerRoute(
                    "contact",
                    "contact-us",
                    defaults: new { controller = "home", action = "contact" }

                    );
                endpoints.MapControllerRoute(
                    "service",
                    "service-us",
                    defaults: new { controller = "service", action = "index" }

                    );
            });
        }
    }
}
