using System;
using System.ComponentModel.Composition;
using System.Threading;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartTwo
{
    [Export(typeof(IEventsExport))]
    [Serializable]
    public class EventStarterTwo : MarshalByRefObject, IEventsExport
    {
        private Timer timer;

        public EventStarterTwo()
        {
            timer = new Timer((delegate(object state)
            {
                if (SomeEvent != null)
                {
                    SomeEvent.Invoke(this, EventArgs.Empty);
                }
            }), null, 10*1000, 1000*10);
        }

        public event EventHandler SomeEvent;

        public event EventHandler SomeOtherEvent;
    }
}
