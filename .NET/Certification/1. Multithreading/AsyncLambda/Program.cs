using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Оборачиваем в таску синхронную лямбду
            Task<int> t = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 42;
            });

            Task<int> ts = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                return 42;
            });

            // Оборачиваем в таску асинхронную лямбду
            // С помощью Task.Factory.StartNew
            Task<Task<int>> tt = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(2000);
                return 42;
            });

            // Оборачиваем в таску асинхронную лямбду
            // С помощью Task.Run()
            Task<int> ttt = Task.Run(async () =>
            {
                await Task.Delay(2000);
                return 42;
            });
        }
    }
}
