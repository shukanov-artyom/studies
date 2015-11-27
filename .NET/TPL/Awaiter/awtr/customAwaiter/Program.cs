using System;

namespace customAwaiter
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static async void AsyncMethod()
        {
            await Method();
        }

        /// <summary>
        /// method is awaitable, it returns an appropriate object 
        /// </summary>
        /// <returns></returns>
        private static CustomTaskSubsitute<object> Method()
        {
            throw new NotImplementedException();
        }
    }
}
