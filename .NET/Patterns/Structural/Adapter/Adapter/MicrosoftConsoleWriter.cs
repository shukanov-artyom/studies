using System;

namespace Adapter
{
    public class MicrosoftConsoleWriter
    {
        private const string empty = "";

        public bool Write(string message, string format = empty)
        {
            if (!String.IsNullOrEmpty(format))
            {
                Console.WriteLine(format, message);
                return true;
            }
            Console.WriteLine(message);
            return false;
        }
    }
}
