using System;
using System.ComponentModel.Composition;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartOne
{
    [Export(typeof(IExport))]
    [Serializable]
    public class ExportPartOne : MarshalByRefObject, IExport
    {
        private VisualExportPartOne visualOne = new VisualExportPartOne();
        private EventStarterOne eventsOne = new EventStarterOne();

        public void InHere()
        {
            Console.WriteLine("Export part two");
        }

        public IVisualExport Visual
        {
            get
            {
                return visualOne;
            }
        }

        public IEventsExport EventStarter
        {
            get
            {
                return eventsOne;
            }
        }
    }
}
