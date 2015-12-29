using System;
using System.Threading.Tasks;

namespace shared
{
    public class DeadlockDemo
    {
        /// <summary>
        /// Asynchronous private method.
        /// </summary>
        private async Task AsyncMethod()
        {
            await Task.Delay(2000);
        }

        /// <summary>
        /// Synchronous method waiting for asynchronous method.
        /// </summary>
        public void Test()
        {
            Task t = AsyncMethod();
            t.Wait(); // in WPF it tries to insert a callback into UI thread queue, but locks UI thread by itself therefore deadlocks.
        }
    }
}
