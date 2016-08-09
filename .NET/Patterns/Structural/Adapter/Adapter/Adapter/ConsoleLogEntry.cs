using System;

namespace Adapter.Adapter
{
    public class ConsoleLogEntry
    {
        public string Format { get; set; }

        public string Message { get; set; }

        public static ConsoleLogEntry FromAppleLogEntry(AppleLogEntry appleEntry)
        {
            return new ConsoleLogEntry()
            {
                 Format = appleEntry.Format,
                 Message = appleEntry.Message
            };
        }
    }
}
