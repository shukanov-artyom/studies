using System;
using System.ComponentModel.Composition;
using System.Windows;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartOne
{
    [Export(typeof(IVisualExport))]
    [Serializable]
    public class VisualExportPartOne : MarshalByRefObject, IVisualExport
    {
        public object SetWindowState()
        {
            return new Window();
        }
    }
}
