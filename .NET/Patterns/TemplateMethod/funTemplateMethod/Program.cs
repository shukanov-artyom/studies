using System;
using System.Collections.Generic;
using funTemplateMethod.LogEntryImpl;

namespace funTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // вызываем обёрнутые методы 
            new LogSaverProxy().UploadExceptions(new List<ExceptionLogEntry>());

            new LogSaverProxy().UploadLogEntries(new List<LogEntry>());
        }
    }
}
