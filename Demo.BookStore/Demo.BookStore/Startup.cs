using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;

namespace Demo.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from my first middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("hello from my first Response\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from my second middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("hello from my second response\n");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from my Third middleware\n");
                
            //});


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/harash", async context =>
                {
                    await context.Response.WriteAsync("Hello Harash");
                });
            });
        }
    }
}
