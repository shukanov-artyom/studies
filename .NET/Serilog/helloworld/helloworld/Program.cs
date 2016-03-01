using System;
using log4net;
using log4net.Config;
using Serilog;

namespace helloworld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // configure log4net in app.config
            XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger("helloworld.logger");
            log.Error("Some Error!");

            // configure Serilog to write to console and to log4net sink
            LoggerConfiguration config = new LoggerConfiguration();
            config.WriteTo.ColoredConsole();
            config.WriteTo.Log4Net(defaultLoggerName: "helloworld.logger");
            config.WriteTo.Seq("http://localhost:5341/");
            ILogger logger = config.CreateLogger();

            logger.Information("Some data from Serilog!");
            logger.Error("Some error from Serilog!");
            logger.Information("Connector {connector} has produces {status} information equal to {completed}", "EV API", "Completed", "Completed");

            Console.Read();
        }
    }
}
