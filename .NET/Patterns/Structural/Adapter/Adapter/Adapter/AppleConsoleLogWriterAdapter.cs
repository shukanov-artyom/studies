using System;

namespace Adapter.Adapter
{
    public class AppleConsoleLogWriterAdapter : IConsoleLogger
    {
        private readonly AppleConsoleLogWriter nativeWriter;

        public AppleConsoleLogWriterAdapter(AppleConsoleLogWriter nativeWriter)
        {
            if (nativeWriter == null)
            {
                throw new ArgumentNullException();
            }
            this.nativeWriter = nativeWriter;
        }

        public void Log(ConsoleLogEntry entry)
        {
            nativeWriter.Log(new AppleLogEntry()
            {
                Format = entry.Format,
                Message = entry.Message
            });
        }
    }
}
