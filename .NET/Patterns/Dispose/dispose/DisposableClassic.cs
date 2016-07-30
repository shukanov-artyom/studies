using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace dispose
{
    /// <summary>
    /// Классическая реализация паттерна Dispose.
    /// Должна применяться в библиотечном коде.
    /// Избыточна в большинстве случаев, должна применяться тогда, когда класс содержит одновременно 
    /// и управляемые, и неуправляемые ресурсы (редкий случай).
    /// </summary>
    public class DisposableClassic : IDisposable
    {
        private IntPtr unmanagedResource;
        private SafeHandle handle;

        public DisposableClassic()
        {
            // выделяем неуправляемый ресурс (имитация)
            unmanagedResource = new IntPtr(0);

            // выделяем управляемый ресурс
            handle = new SafeWaitHandle(IntPtr.Zero, true);
        }

        /// <summary>
        /// Виртуальный метод, который должен разобраться кто инициировал диспоуз - пользовательский код или финализатор.
        /// Вызывается ид диспоуз и финализатора с разным значением аргумента.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            // безусловно освобождаем неуправляемые ресурсы (имитация).
            Marshal.Release(unmanagedResource); 
            if (disposing)
            {
                // если это пользовательский вызов, то GC ещё не уничтожил управляемые ресурсы, 
                // и мы можем их освободить не опасаясь, что они уже освобождены.
                if (handle != null)
                {
                    handle.Close();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // мы уже всё сделали, финализация не нужна.
        }

        /// <summary>
        /// Финализатор. Вызывается финализирующим потоком сборщика мусора.
        /// </summary>
        ~DisposableClassic()
        {
            Dispose(false);
        }
    }
}
