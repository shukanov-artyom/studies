using System;

namespace Singleton
{
    /// <summary>
    /// Самая простая и эффективная реализация синглтона, но работает только на 4-м фреймворке и выше.
    /// </summary>
    public sealed class LazySingleton
    {
        private static Lazy<LazySingleton> lazy =
            new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            // explicitly state that only Instance property can construct an instance.
        }

        public static LazySingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public void Do()
        {
            Console.WriteLine("Lazy Singleton does job!");
        }
    }
}
