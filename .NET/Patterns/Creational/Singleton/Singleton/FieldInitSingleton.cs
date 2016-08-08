using System;

namespace Singleton
{
    /// <summary>
    /// Используем свойства инициализации статического поля.
    /// </summary>
    public class FieldInitSingleton
    {
        private static readonly FieldInitSingleton instance = 
            new FieldInitSingleton();

        static FieldInitSingleton()
        {
            
        }

        public static FieldInitSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void Do()
        {
            Console.WriteLine("Static Field Init singleton works!");
        }
    }
}
