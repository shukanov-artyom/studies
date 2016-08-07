using System;
using System.Collections.Generic;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            // рассмотрим применение паттерна "стратегия" в реализации с делегатом в задаче сортировки

            List<SortableUnit> coll = new List<SortableUnit>()
            {
                new SortableUnit() {Key = 1},
                new SortableUnit() {Key = 7},
                new SortableUnit() {Key = 5},
                new SortableUnit() {Key = 4},
                new SortableUnit() {Key = 9}
            };

            coll.Sort((a,b) => 0); // вариант с явным заданием делегата

            coll.Sort(new SortableUnitComparer()); // вариант с явным заданием компаратора

            coll.Sort(ComparisonWrapperFactory.Create<SortableUnit>((a, b) => 0)); // вариант с обёртыванием делегата в компаратор
        }
    }
}
