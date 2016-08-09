using System;

namespace Adapter
{
    public class AppleConsoleLogWriter
    {
        public void Log(AppleLogEntry entry)
        {
            Console.WriteLine(String.Format(entry.Format, entry.Message));
        }
    }
}
