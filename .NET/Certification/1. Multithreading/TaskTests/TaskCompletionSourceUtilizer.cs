using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTests
{
    public class TaskCompletionSourceUtilizer
    {
        public static void Test()
        {
            
        }

        public static async Task<int> CustomTaskMethod()
        {
            TaskCompletionSource<int> tsc = new TaskCompletionSource<int>();
            // этот объект полностью управляет задачей
            // может засетить результат, эксепшен, отмену и так далее.

            new Thread(() =>
            {
                Thread.Sleep(2000);
                tsc.SetResult(42);
            }).Start();

            return tsc.Task;
        }
    }
}
