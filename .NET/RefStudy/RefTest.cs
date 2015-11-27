using System;
using System.Runtime.InteropServices;

namespace Richter.RefStudy
{
    internal class RefTest
    {
        // тестируем работу с бинарным деревом и передачей его элементов по ссылке в методы

        public static void Do()
        {
            
        }

        private static void Operate(ref A aelement)
        {
            if (aelement == null)
            {
                aelement = new B();
            }
            A t = aelement.Left;
            aelement.Left = aelement.Right;
            aelement.Right = t;
        }

        private static void Operate(ref B belement)
        {
            if (belement == null)
            {
                belement = new B();
            }
            B t = belement.Left;
            belement.Left = belement.Right;
            belement.Right = t;
        }

        private static void OperateGeneric<T>(ref T el) where T : A
        {
            //  дотнет не работает так! 
            // http://blogs.msdn.com/b/ericlippert/archive/2009/09/21/why-do-ref-and-out-parameters-not-allow-type-variation.aspx
            // тут эрик липперт описывает, что нельзя передавать по ссылке нечто с типом, отличным от ссылки
            // в дотнете ссылки очень строго типизированы
            //T t = el.Left;
        }
    }
}
