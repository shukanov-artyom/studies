using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace awtr
{
    static class Program
    {
        private static Func<int> code = () =>
        {
            return 0;
            //throw new ArgumentException();
        };

        static void Main(string[] args)
        {
            //GetTaskResultDirectly();
            GetTaskResultViaAwaiter();
            //GetTaskResultContinueWith();
        }

        private static void GetTaskResultDirectly()
        {
            Task<int> t = Task.Run(code);
            // get a result directly
            // must give AggregateException
            try
            {
                var r = t.Result;
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.GetType().ToString());
            }
        }

        private static void GetTaskResultViaAwaiter()
        {
            if (SynchronizationContext.Current != null)
            {
                SynchronizationContext.Current.ToString();
            }
            Task<int> t = Task.Run(code);
            TaskAwaiter<int> awaiter = t.GetAwaiter();
            try
            {
                awaiter.OnCompleted(() =>
                {
                    try
                    {
                        int result = awaiter.GetResult();
                        Console.WriteLine(result);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.GetType());
                        Console.Read();
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                    }
                    //throw new ApplicationException(result.ToString());
                });
            }
            catch (ApplicationException n)
            {
                // i am not getting here
                Console.WriteLine(n.GetType());
            }
        }

        private static void GetTaskResultContinueWith()
        {
            Task<int> t = Task.Run(code);
            Task task = t.ContinueWith(ant =>
                           {
                               try
                               {
                                   int result = ant.Result;
                                   Console.WriteLine(result);
                               }
                               catch (AggregateException ex)
                               {
                                   Console.WriteLine(ex.GetType());
                               }
                           });
        }
    }
}
