using System;
using Adapter.Adapter;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConsoleLogger logger = SelectLogger(args.Length);
            logger.Log(new ConsoleLogEntry()
            {
                Format = "Log output is {0}",
                Message = "LALALA"
            });

            Console.Read();
        }

        private static IConsoleLogger SelectLogger(int parameter)
        {
            if (parameter == 0)
            {
                return new MicrosoftConsoleWriterAdapter(new MicrosoftConsoleWriter());
            }
            return new AppleConsoleLogWriterAdapter(new AppleConsoleLogWriter());
        }
    }
}
