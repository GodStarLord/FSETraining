using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.Swagger;

namespace HandsOnTwo
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Swagger Demo",
                    Version = "v1",
                    Description = "TBD",
                    TermsOfService = "None",
                    Contact = new Contact() {name = "John Doe", email = "john@xyzmail.com", url = "www.example.com"},
                    License = new Swashbuckle.Swagger.License() {name = "License Terms", url = "www.example.com"}
                });


            });
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                // specifying the Swagger JSON endpoint.
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string TermsOfService { get; set; }
        public Contact Contact { get; set; }
        public Swashbuckle.Swagger.License License { get; set; }
    }
}
