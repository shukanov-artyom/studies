using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTests
{
    public static class Continuation
    {
        public static void TestContinuationWithAwaiter()
        {
            Task<int> t = Task.Run(() =>
            {
                throw null; // кидаем эксепшен
                return 0;
            }, CancellationToken.None);
            TaskAwaiter<int> awaiter = t.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                try
                {
                    int result = awaiter.GetResult(); // тут эксепшен будет переброшен
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType()); // не оборачивается в AggregateException!!
                }
            });
            Console.Read();
        }

        public static void TestContinuationWithTask()
        {
            Task<int> t = Task.Run(() =>
            {
                throw new Exception(); // кидаем эксепшен
                return 0;
            }, CancellationToken.None);
            
            t.ContinueWith((task) =>
            {
                try
                {
                    int result = task.Result; // тут эксепшен будет переброшен
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception e) // тут поймаем AggregateException
                {
                    if (e.InnerException == null)
                    {
                        Console.WriteLine("Null thrown!");
                    }
                    else
                    {
                        Console.WriteLine(e.InnerException.GetType()); // here e is null so not logging it!
                    }
                }
                Console.Read();
            });
            Console.Read();
        }
        // таким образом, вытащить исключение из таски, не оборачивая ег ов AggregateException можно посредством Awaiter.
        // async тоже использует awaiter, но компилятор оборачивает исключения в агрегатное.
    }
}
