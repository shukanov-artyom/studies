using System;
using System.ComponentModel.Composition;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartTwo
{
    [Serializable]
    [Export(typeof(IVisualExport))]
    public class VisualExportPartTwo : MarshalByRefObject, IVisualExport
    {
        public object SetWindowState()
        {
            return new object();
        }
    }
}
