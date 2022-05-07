using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAccess.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatabaseAccess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            SeedTheDB(host);    
            host.Run();
        }

        private static void SeedTheDB(IHost host)
        {
            var dataScope = host.Services.CreateScope();
            var myServices = dataScope.ServiceProvider;
            var myContext = myServices.GetRequiredService<CompanyContext>();
            DbInitializer.Initialize(myContext);

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logBuilder =>
                {
                    logBuilder.ClearProviders(); // removes all providers from LoggerFactory
                    logBuilder.AddConsole();
                    logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
