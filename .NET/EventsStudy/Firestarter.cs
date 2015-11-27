using System;

namespace Richter.EventsStudy
{
    internal class Firestarter
    {
        public event EventHandler Fire;

        public void Start()
        {
            EventHandler eh = Fire;
            if (eh != null)
            {
                eh.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
