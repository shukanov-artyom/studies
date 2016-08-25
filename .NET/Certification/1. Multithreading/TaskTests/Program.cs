using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTests
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Func<int> work = () =>
            {
                Console.WriteLine("Delegate called!");
                return 0;
            }; // просто делегат нужной сигнатуры

            Task<int> task = new Task<int>(work);
            task.Wait();*/
            //TestTask();
            //TestTask2();

            //Continuation.TestContinuationWithAwaiter();

            Continuation.TestContinuationWithTask();
        }

        private static void TestTask()
        {
            Task<bool> t = Task.Run(() =>
            {
                Thread.Sleep(2000);
                return true;
            });
            bool b = t.Result; // blocking on join here!
            Console.WriteLine(b);
            Console.Read();
        }

        private static async void TestTask2()
        {
            Console.WriteLine("Let's await!");
            await GetTask(1000);
            Console.WriteLine("Long last!");
            Console.Read();
        }

        private static Task<int> GetTask(int wait)
        {
            var source = new TaskCompletionSource<int>();
            //Task.Delay(100);
            Thread.Sleep(wait);
            source.SetResult(100);
            return source.Task;
        }
    }
}
