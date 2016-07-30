using System;

namespace templateMethod
{
    /// <summary>
    /// Абстрактный класс, задающий базовую логику алгоритма и переменные шаги, переопределяемые наследниками.
    /// Тривиальная реализация паттерна "Шаблонный метод" на основе абстрактных методов и наследования.
    /// </summary>
    public abstract class LogImporter
    {
        /// <summary>
        /// Невиртуальный неабстрактный метод, задающий каркас алгоритма.
        /// </summary>
        public void MainAlgorythm()
        {

            object a = AlgorythmStep1();
            AlgorythmStep2(a);
        }

        /// <summary>
        /// Переменный шаг, переопределяемый наследниками.
        /// </summary>
        /// <returns></returns>
        protected abstract object AlgorythmStep1();

        /// <summary>
        /// Второй переменый шаг, переопределяемый наследниками. 
        /// </summary>
        protected abstract void AlgorythmStep2(object o);
    }
}
