using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncLambdas
{
    class Program
    {
        private static Func<Task> asyncLambda = async () =>
        {
            await Task.Delay(3000);
            Console.WriteLine("Bar");
        };

        static void Main(string[] args)
        {
            Task callAsyncLambda = CallAsyncLambda();

            /*Task tb = NamedMethod();
            tb.Wait();
            Console.Read();*/
        }

        private static void CallAsyncLambdaWithExplicitAwaiter()
        {
            TaskAwaiter aw = asyncLambda().GetAwaiter();
            aw.GetResult();
        }

        private static async Task CallAsyncLambda()
        {
            await asyncLambda();
        }

        private static async Task CallAsyncAnonymousDelegate()
        {
            await Task.Run(() => { });
        }

        private static async Task NamedMethod()
        {
            await Task.Delay(3000);
            Console.WriteLine("Foo");
        }
    }
}
