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
            // самый простой случай
            Task<int> t = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 42;
            });

            // ---------------------------
            // делаем то же самое с помощью Task.Factory.StartNew()
            Task<int> ts = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                return 42; // возвращаем инт, поэтому результат выражения Task<int>
            });

            // ---------------------------
            // А что если вернуть результат-объект таски.
            Task<Task> tl = Task.Factory.StartNew(() =>
            {
                Task inner = Task.Factory.StartNew(() =>
                {
                    /* Пустая внутренняя таска, не делает вообще ничего.*/
                });
                return inner; // возвращаем объект таски!!
            });

            // ---------------------------
            // теперь внутренняя таска сама возвращает результат.
            Task<Task<int>> tti = Task.Factory.StartNew(() =>
            {
                Task<int> inner = Task.Factory.StartNew(() => 42);
                return inner;
            });

            // ---------------------------
            // На букакой тип у обычной лямбды?
            // это Func<int>
            Func<int> ul = () =>
            {
                Thread.Sleep(100);
                return 42;
            };

            // ---------------------------
            // какой тип у асинхронной лямбды вообще? 
            // оказывается, это Func<Task<int>>
            Func<Task<int>> fti = async () => 
            {
                await Task.Delay(100);
                return 42;
            };

            // ---------------------------
            // провернём то же самое с асинхронным делегатом
            // его тип тот же самый 
            Func<Task<int>> ad = async delegate
            {
                await Task.Delay(100);
                return 42;
            };

            // ---------------------------
            // Оборачиваем в таску асинхронную лямбду
            // С помощью Task.Factory.StartNew
            Task<Task<int>> tt = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(2000);
                return 42;
            });

            // ---------------------------
            // Оборачиваем в таску асинхронную лямбду
            // С помощью Task.Run()
            Task<int> ttt = Task.Run(async () =>
            {
                await Task.Delay(2000);
                return 42;
            }, CancellationToken.None); // явно задаём невозможность отмены, хоть это и необязательно

            // ---------------------------
            // видим, что типы разные, хотя лямбда одна и та же! 
            // это потому, что Task.Run() делает Unwrap()!!
            // сделаем его сами, используя TaskFactory(), и получим полный аналог Task.Run()
            Task<int> unwr = Task.Factory.StartNew(async () =>
                {
                    await Task.Delay(100);
                    return 42;
                }, 
                CancellationToken.None, 
                TaskCreationOptions.DenyChildAttach,
                TaskScheduler.Default).Unwrap();

            //---------------------------
            // Далее продолжим в асинхронном методе, так как нам нужны await
            TestAwaiting();
        }

        private static async void TestAwaiting()
        {
            // ---------------------------
            // подождём эту таску
            int tres = await Task.Factory.StartNew(async () =>
            {
                await Task.Delay(1000);
                return 42;
            }, 
            CancellationToken.None, 
            TaskCreationOptions.DenyChildAttach, 
            TaskScheduler.Default).Unwrap();

            // ---------------------------
            // а вот сейчас вообще сделаем офигительный финт
            // вместо Unwrap() применим await!

            tres = await await Task.Factory.StartNew(async () =>
            {
                await Task.Delay(1000);
                return 42;
            }, 
            CancellationToken.None, 
            TaskCreationOptions.DenyChildAttach, 
            TaskScheduler.Default);

            // что характерно, это не получится с использованием Task.Run(), так как он сам по себе уже делает Unwrap();
        }
    }
}
