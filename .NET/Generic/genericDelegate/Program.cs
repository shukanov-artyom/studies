using System;
using System.Runtime.Remoting.Messaging;

namespace genericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeDel<Object, ArgumentException> f1 = o => new ArgumentException();
            SomeDel<String, Exception> f2 = f1; // демонстрируем одновременно и ковариантность для выходного параметра, и контравариантность для выходного.

            // входной параметр во второй функции передаёт строку туда, где ожидается объект, что нормально
            // выходной параметр во второй функции интерпретирует ArgumentException как Exception, что тоже нормально.
        }

        // in - определяет ковариантность
        // out - конравариантность
        internal delegate TReturn GenDel<out TReturn, in TKey, in TValue>(TKey key, TValue value);

        internal delegate TResult SomeDel<in TArg, out TResult>(TArg arg);
    }
}
