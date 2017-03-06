using System;
using IdentCore.Identity.Models;
using IdentCore.Persistency;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace IdentCore
{
    /// <summary>
    /// This class is required by asp.net core and named Startup by convention.
    /// </summary>
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Let's build configuration.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // What about our DI services?
            services
                .AddEntityFramework()
                .AddDbContext<ApplicationDbContext>(options => 
                    options.UseSqlServer(Configuration
                        .GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddIdentity<ApplicationUser, ApplicationUserRole>();

            // TODO : explore Options pattern here for configuration
            // services.Configure<MyConfig>(Configuration);
        }

        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory)
        {
            // configure logging
            loggerFactory
                //.AddConsole()
                .AddDebug()
                .AddSerilog();

            // Configuring Seq logging
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext() // capture Request/Response asp.net context details
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();

            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new
                    {
                        controller = "App",
                        action = "Index"
                    });
            });

            // Wiring up Identity middleware!
            app.UseIdentity();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
    }
}
