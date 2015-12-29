using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace nonaw
{
    class Program
    {
        static void Main(string[] args)
        {
            // perform awaited call
            TaskAwaiter<int> aw = AsyncFunction().GetAwaiter();
            aw.OnCompleted(() =>
                           {
                               int result = aw.GetResult();
                           });

            // perform unawaited call
            AsyncFunction2();
        }

        static async Task<int> AsyncFunction()
        {
            await Task.Delay(1500);
            return 5;
        }

        static async Task<int> AsyncFunction2()
        {
            Console.WriteLine(5);
            Console.Read();
            await DelayedFunction();
            Console.Read();
            return 5;
        }

        static async Task<int> AwaitedCaller()
        {
            int r = await AsyncFunction();
            return 10*r;
        }

        static async Task DelayedFunction()
        {
            await Task.Delay(2000);
        }
    }
}
