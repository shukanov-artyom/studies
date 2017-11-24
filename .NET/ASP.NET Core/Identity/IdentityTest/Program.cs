using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IdentCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            var config = builder
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddCommandLine(args) // need packages to have these extensions
                .AddJsonFile("hosting.json", optional: true)
                .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>() // could as well use Configure();  ConfigureServices() will still have effect
                .UseConfiguration(config)
                .Build();

            host.Run();
        }
    }
}
