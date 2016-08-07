using System;
using System.Collections.Generic;
using funTemplateMethod.LogEntryImpl;

namespace funTemplateMethod
{
    public class LogSaverProxy : ILogSaver
    {

        /// <summary>
        /// Поскольку паттерн часто применяется во взаимодействии с WCF, здесь мы имитируем WCF.
        /// Эта реализация паттерна более концептуально сложная и платформно-специфичная.
        /// </summary>
        private class WcfLogSaverClient : ILogSaver
        {
            public void UploadLogEntries(IEnumerable<LogEntry> logEntries)
            {
                Console.WriteLine("Uploaded log entries to WCF");
            }

            public void UploadExceptions(IEnumerable<ExceptionLogEntry> exceptionLogEntries)
            {
                Console.WriteLine("Uploaded Exception log entries to WCF");
            }
        }

        /// <summary>
        /// Внимание! тут используется замыкание. 
        /// переданный в UseProxyClient делегат замкнут на logEntries. 
        /// Таким образом, в делегате происходит связывание метода и данных для аргумента метода.
        /// </summary>
        public void UploadLogEntries(IEnumerable<LogEntry> logEntries)
        {
            UseProxyClient((saver) => { saver.UploadLogEntries(logEntries); });
        }

        /// <summary>
        /// аналогично предыдущему методу.
        /// </summary>
        public void UploadExceptions(IEnumerable<ExceptionLogEntry> exceptionLogEntries)
        {
            UseProxyClient(saver => {saver.UploadExceptions(exceptionLogEntries);});
        }

        /// <summary>
        /// Это сердце реализации паттерна - метод, принимающий делегат.
        /// В этот делегат надо передать внутреннюю реализацию ILogSaver, и делегат вызовет на этой реализации нужный ему метод.
        /// </summary>
        private void UseProxyClient(Action<ILogSaver> accessor)
        {
            var client = new WcfLogSaverClient();

            try
            {
                accessor(client);
            }
            catch (Exception)
            {
                // client.abort();
                // throw new OperationFailedException();
            }
        }
    }
}
