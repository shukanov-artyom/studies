using System;
using System.Threading.Tasks;

namespace awaitasync
{
    class Program
    {
        static void Main(string[] args)
        {
            // вызываем асинхроную операцию
            Task t = DisplayPrimesCountAsync(0);
            // назначаем обработчик ожидания
            t.GetAwaiter().OnCompleted( () => Console.WriteLine("Awaiter completed!"));
            Console.Read();
        }

        /// <summary>
        /// Асинхронно вызываем код, возвращаем объект Task, который сообит о своём завершении.
        /// Для этого используем конечный автомат.
        /// </summary>
        private static Task DisplayPrimesCountAsync(int i)
        {
            PrimesStateMachine sm = new PrimesStateMachine();
            sm.DisplayPrimesCountFrom(i);
            return sm.Task;
        }
    }
}
