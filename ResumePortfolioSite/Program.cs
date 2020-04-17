﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ResumePortfolioSite.Services;

namespace ResumePortfolioSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = CreateWebHostBuilder(args).Build();

            // Seed Data
            using (var scope = host.Services.CreateScope())
            {
                IServiceProvider services = scope.ServiceProvider;

                try
                {
                    ResumeDbContext context = services.GetRequiredService<ResumeDbContext>();

                    SeedDataInitializer seedDataInitializer = new SeedDataInitializer(context);
                    seedDataInitializer.Seed();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
