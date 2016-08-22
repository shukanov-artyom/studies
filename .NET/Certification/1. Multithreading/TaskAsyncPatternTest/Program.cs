using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskAsyncPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            MethodTestAsyncPatternsConversion();
            Console.Read();
        }

        private static int SyncMethod(int to = 1000)
        {
            Thread.Sleep(to);
            return 5;
        }

        private static Task<int> MethodAsync()
        {
            return Task.Run(() => SyncMethod());
        }

        private static Task<int> MethodAsync2()
        {
            return Task.Run(() => SyncMethod(2000));
        }

        private static async void Method()
        {
            int a = 10;
            Task<int> b = MethodAsync();
            Task<int> c = MethodAsync2();
            int[] res = await Task.WhenAll(b, c); // Используем комбинатор тасков
            Console.WriteLine(a + res[0] + res[1]);
        }

        private static string Greeting(string name)
        {
            Thread.Sleep(3000);
            return String.Format("Hello, {0}", name);
        }

        private static void MethodTestAsyncPatternsConversion()
        {
            Func<string, string> meth = Greeting;

        }
    }
}
