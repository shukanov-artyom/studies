using System;
using System.Collections.Generic;
using funTemplateMethod.LogEntryImpl;

namespace funTemplateMethod
{
    public interface ILogSaver
    {
        void UploadLogEntries(IEnumerable<LogEntry> logEntries);

        void UploadExceptions(IEnumerable<ExceptionLogEntry> exceptionLogEntries);
    }
}
