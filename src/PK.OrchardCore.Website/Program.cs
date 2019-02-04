﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using OrchardCore.Logging;

namespace PK.OrchardCore.Website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseNLogWeb()
                .UseStartup<Startup>();
    }
}
