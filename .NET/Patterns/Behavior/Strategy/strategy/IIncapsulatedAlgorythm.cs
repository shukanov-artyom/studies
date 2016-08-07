using System;

namespace strategy
{
    /// <summary>
    /// Interface has two methods so we are unable to use delegates instead.
    /// </summary>
    public interface IIncapsulatedAlgorythm
    {
        void Do();

        void Do2();
    }
}
