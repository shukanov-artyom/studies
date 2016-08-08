using System;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace FactoryMethod
{
    class GenericFactoryMethodClass
    {
        /// <summary>
        /// Статический обобщённый фэктори-метод, создающий классы из иерархии Prooduct заданного типа.
        /// </summary>
        public static T Create<T>() where T : Product, new()
        {
            try
            {
                T t = new T();
                t.Initialize(); // выполняем в фэктори-методе внешнюю по отношению к конструктору работу по инициализации.
                return t;
            }
            catch (TargetInvocationException e) // reflection exception!
            {
                ExceptionDispatchInfo ex = ExceptionDispatchInfo.Capture(e.InnerException);
                ex.Throw();
                return default(T); // недостижимый код!
            }
        }
    }
}
