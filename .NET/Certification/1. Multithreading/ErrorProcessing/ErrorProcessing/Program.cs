using System;
using System.Diagnostics;

namespace ErrorProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // ообъявляем метод, иногда кидающий эксепшен
            // для разнообразия с помощью лямбда-выражения
            Func<int, bool> method = (int a) =>
            {
                if (a == 0)
                {
                    throw null;
                }
                return true;
            };

            // тут ни один из блоков catch не выполняется!!
            // чтобы обработать эксепшен в методе, надо и ловить его в этом лямбда-выражении, потом возвращать в составе результата
            try
            {
                // выполняем метод с помощью асинхронного шаблона
                method.BeginInvoke(1, ar =>
                {
                    try
                    {
                        bool result = method.EndInvoke(ar);
                        if (result)
                        {
                            Console.WriteLine("Successful scenario!");
                        }
                    }
                    catch (NullReferenceException e)
                    {
                        Debug.WriteLine(e);
                    }
                }, null);
            }
            catch (NullReferenceException e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
