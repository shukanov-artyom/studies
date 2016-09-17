using System.IO;
using hwnn.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace hwnn
{
    public class Startup
    {
        // http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var cb = new ConfigurationBuilder();
            cb.SetBasePath(Directory.GetCurrentDirectory());
            cb.AddJsonFile("appsettings.json");
            IConfigurationRoot config = cb.Build();

            string connectionString = config.GetConnectionString("ContosoDatabase");
            services.AddDbContext<ContosoContext>(options => options.UseSqlServer(connectionString));
        }

        // pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvcWithDefaultRoute();
        }
    }
}
