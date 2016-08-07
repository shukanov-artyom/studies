using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace dispose
{
    /// <summary>
    /// Более эффективная реализация, предложенная Тепляковым в книге "Паттерны проектирования на платформе .NET Framework"
    /// </summary>
    internal class DisposableSimplified : IDisposable
    {
        private IntPtr unmanagedResource;
        private SafeHandle handle;

        public DisposableSimplified()
        {
            // выделяем неуправляемый ресурс (имитация)
            unmanagedResource = new IntPtr(0);

            // выделяем управляемый ресурс
            handle = new SafeWaitHandle(IntPtr.Zero, true);
        }

        public void Dispose()
        {
            DisposeNativeResources();
            DisposeManagedResources();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Даём наследникам возможность переопределить эти методы.
        /// Будем надеяться, что наследник перевызовет метод базового класса из переопределённого.
        /// </summary>
        protected virtual void DisposeNativeResources()
        {
            Marshal.Release(unmanagedResource);
        }

        protected virtual void DisposeManagedResources()
        {
            if (handle != null)
            {
                handle.Close();
            }
        }

        ~DisposableSimplified()
        {
            // Диспоузим только то, о чём GC не знает.
            DisposeNativeResources();
        }
    }
}
