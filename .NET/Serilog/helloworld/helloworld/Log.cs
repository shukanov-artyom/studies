using System;
using System.IO;
using System.Reflection;
using log4net.Config;
using Serilog;

namespace helloworld
{
    public static class Log
    {
        private static readonly ILogger Logger;

        static Log()
        {
            // configure Log4Net
            XmlConfigurator.Configure();
            //ILog log4netLog = LogManager.GetLogger("Application.Logger");

            // Get current folder to write log file to.
            string currentFolder = Assembly.GetExecutingAssembly().Location;
            string logFilePathName = Path.Combine(currentFolder, "log.txt");
            log4net.GlobalContext.Properties["LogFileName"] = logFilePathName;

            // configure Serilog Logger
            LoggerConfiguration config = new LoggerConfiguration();
            config.WriteTo.ColoredConsole();
            config.WriteTo.Log4Net(defaultLoggerName: "Application.Logger");
            // config.WriteTo.Seq("http://localhost:5341/");
            Logger = config.CreateLogger();
        }


        public static void Error(Exception e, string message)
        {
            Logger.Error(e, message);
        }

        public static void Error(string message)
        {
            Logger.Error(message);
        }

        public static void Warning(Exception e, string message)
        {
            Logger.Warning(e, message);
        }

        public static void Warning(string message)
        {
            Logger.Warning(message);
        }

        public static void Information(string message)
        {
            Logger.Information(message);
        }
    }
}
