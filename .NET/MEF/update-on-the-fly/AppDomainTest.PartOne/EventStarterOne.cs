using System;
using System.ComponentModel.Composition;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartOne
{
    [Export(typeof(IEventsExport))]
    [Serializable]
    public class EventStarterOne : MarshalByRefObject, IEventsExport
    {
        public event EventHandler SomeEvent;

        public event EventHandler SomeOtherEvent;
    }
}
