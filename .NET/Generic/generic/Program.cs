using System;

namespace generic
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // проверяем ковариантность массивов (Co-variance)
            A[] a = new A[10];
            B[] b = new B[10];
            A[] a2 = new B[2]; // ковариантное присваивание массивов
            // B[] b2 = new A[2]; // back conversion gives compilation error

            // пробуем ковариантность интерфейсов
            IInputable<B> inp = new Stack<A>(); // ковариантное присваивание
            IOutputable<A> outp = new Stack<B>(); // контравариантное присваивание
        }

        private class A
        {
        }

        private class B : A
        {
        }

        private interface IInputable<in T> where T : A
        {
            void Input(T t);
        }

        private interface IOutputable<out T> where T : A
        {
            T Output();
        }

        private class Stack<T> : IInputable<T>, IOutputable<T> where T : A
        {
            private T t;

            public T Output()
            {
                return t;
            }

            public void Input(T t)
            {
                this.t = t;
            }
        }
    }
}
