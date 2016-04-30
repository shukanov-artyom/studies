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

            Log.Information("Some data from Serilog!");
            Log.Error("Some error from Serilog!");
            Log.Information(String.Format("Connector {0} has produces {1} information equal to {2}", "EV API", "Completed", "Completed"));
            Console.Read();
        }
    }
}
