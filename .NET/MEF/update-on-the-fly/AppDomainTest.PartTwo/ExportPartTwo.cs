using System;
using System.ComponentModel.Composition;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartTwo
{
    [Export(typeof(IExport))]
    [Serializable]
    public class ExportPartTwo : MarshalByRefObject, IExport
    {
        private VisualExportPartTwo visual = new VisualExportPartTwo();
        private EventStarterTwo eventStarter = new EventStarterTwo();

        public void InHere()
        {
            Console.WriteLine("Export part two");
        }

        public IVisualExport Visual
        {
            get
            {
                return visual;
            }
        }

        public IEventsExport EventStarter
        {
            get
            {
                return eventStarter;
            }
        }
    }
}
