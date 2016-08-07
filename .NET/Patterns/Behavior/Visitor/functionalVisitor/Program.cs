using System;

namespace functionalVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            HierarchyLeafA a = new HierarchyLeafA();
            HierarchyLeafB b = new HierarchyLeafB();

            // вместо создания класса нам всего лишь надо вызвать метод базового класса, в котором всё и сконцентрировано.
            // Это функциональный паттерн посетитель: посещаем наш инстанс делегатами, а не классом.

            // здесь есть явный перебор листьев дерева наследования, зато нет изменения в самих листьях, только в базовом классе.

            // по сути это простая реализация сопоставления с образцом (pattern matching)
            a.Match(
                ha => Console.WriteLine("A accepted"),
                hb => Console.WriteLine("B accepted"));

            Console.Read();
        }
    }
}
