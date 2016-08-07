using System;
using System.Collections.Generic;

namespace sorting
{
    // Класс, явно реализующий интерфейс IComparer (в отличие от варианта с делегатом)
    class SortableUnitComparer : IComparer<SortableUnit>
    {
        // Пример с сортировкой
        public int Compare(SortableUnit x, SortableUnit y)
        {
            if (x.Key == y.Key)
            {
                return 0;
            }
            if (x.Key > y.Key)
            {
                return 1;
            }
            return -1;
        }
    }
}
