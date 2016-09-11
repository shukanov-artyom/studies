using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace hw_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // встроенный веб-вервер создаётся тут!
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration() // раньше это делалочь в методе Configure() ! чтобы вставить в пайплайн 
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
