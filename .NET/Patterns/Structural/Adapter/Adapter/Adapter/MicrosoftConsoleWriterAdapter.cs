using System;

namespace Adapter.Adapter
{
    public class MicrosoftConsoleWriterAdapter : IConsoleLogger
    {
        private readonly MicrosoftConsoleWriter nativeLogger;

        public MicrosoftConsoleWriterAdapter(MicrosoftConsoleWriter nativeLogger)
        {
            this.nativeLogger = nativeLogger;
        }

        public void Log(ConsoleLogEntry entry)
        {
            nativeLogger.Write(entry.Message, entry.Format);
        }
    }
}
