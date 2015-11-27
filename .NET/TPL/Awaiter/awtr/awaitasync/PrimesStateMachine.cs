using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace awaitasync
{
    /// <summary>
    /// Конечный автомат, основанный на TaskCompletionSource.
    /// Работа передаётся фоновым потокам из пула, затем посредством TaskCompletionSource сообщается о завершении.
    /// </summary>
    public class PrimesStateMachine
    {
        private readonly TaskCompletionSource<object> src = new TaskCompletionSource<object>();

        public Task Task
        {
            get
            {
                return src.Task;
            }
        }

        public void DisplayPrimesCountFrom(int i)
        {
            TaskAwaiter<int> awaiter = GetPrimesCountAsync(i*1000+2, 1000).GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                awaiter.GetResult();
                if (i++ < 10)
                {
                    DisplayPrimesCountFrom(i); // рекрсивный вызов метода при необходимости продолжения
                    // таким образом обеспечивается последовательное выполнение задач.
                }
                else
                {
                    Console.WriteLine("Done");
                    src.SetResult(null); // закончили, отправляем результат из конечного автомата.
                }
            });
        }

        /// <summary>
        /// Асинхронно запускает задачу по нахождению простых числе в диапазоне.
        /// </summary>
        private static Task<int> GetPrimesCountAsync(int start, int count)
        {
            return Task.Run(() => ParallelEnumerable.Range(start, count).
                Count(r => Enumerable.Range(2, (int)Math.Sqrt(r) - 1).All(p => r % p == 0)));
        }
    }
}
