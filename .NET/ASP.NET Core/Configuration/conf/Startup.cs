using System;
using System.IO;
using conf.Configuration.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace conf
{
    public class Startup
    {
        private IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddOptions(); // setup options delivery with DI
            services.Configure<BusinessRulesOptions>(Configuration.GetSection("BusinessRules")); // raise configuration section
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseMvcWithDefaultRoute();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            var c = AddConfiguration();
        }

        private IConfiguration AddConfiguration()
        {
            return new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                AddInMemoryCollection().
                Build();
        }
    }
}
