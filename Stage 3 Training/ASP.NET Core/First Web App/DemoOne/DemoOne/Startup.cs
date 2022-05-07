using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DemoOne
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISampleInterface, SampleInterface>();
            MvcOptions mvcOptions = new MvcOptions();
            Action<MvcOptions> action = new Action<MvcOptions>(m=>m.EnableEndpointRouting = false);
            services.AddMvc(action);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ISampleInterface sampleInterface)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});

            app.UseStaticFiles(); // This ensures that the app loads html pages that we have added
            app.UseMvcWithDefaultRoute();

            app.Run(async ctx =>
            {
                sampleInterface.PrintTest();
                await ctx.Response.WriteAsync("Look we have written to the response");
            });
        }
    }

    public interface ISampleInterface
    {
        void PrintTest();
    }

    public class SampleInterface : ISampleInterface
    {
        public void PrintTest()
        {
            Console.WriteLine("Hello from the Interface");
        }
    }
}
