﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore; 
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.DependencyInjection; 

namespace UserManagementApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
