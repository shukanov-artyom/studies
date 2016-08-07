﻿using System;

namespace visitor
{
    /// <summary>
    /// Конкретные алгоритмы обработки каждого из конкретных классов вынесены в реализацию 
    /// посетителя. За счёт перегрузки операторов в рантайме выбирается какой конкретно код исполнять. 
    /// 
    /// Таким образом, логика обработки (код) отделён от данных (классов). Надо применять это в тех случаях, когда 
    /// нецелесообразно держать логику обработки объектов в составе методов самих объектов.
    /// 
    /// Хорошо, если мы редко меняем иерархию, но часто добавляем новые операции.
    /// Сложность изменения иерархии: если добавляем класс, то ломаем всех Посетителей новой операцией. Сами классы остаются в норме.
    /// </summary>
    internal interface IVisitor
    {
        void Visit(ConcreteClassA instanceA);

        void Visit(ConcreteClassB instanceB);
    }
}
