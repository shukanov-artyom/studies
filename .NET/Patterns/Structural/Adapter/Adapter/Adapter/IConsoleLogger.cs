using System;

namespace Adapter.Adapter
{
    public interface IConsoleLogger
    {
        void Log(ConsoleLogEntry entry);
    }
}
