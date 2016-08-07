using System;

namespace basic
{
    /// <summary>
    /// Неявный медиатор - коллеги ничего не знают о посреднике!
    /// </summary>
    internal class Mediator
    {
        public Mediator(Colleague1 c1, Colleague2 c2)
        {
            c2.Do();
            Console.WriteLine("Some intermittent action taken in Mediator!");
            c1.Do();
        }
    }
}
