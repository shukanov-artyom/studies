using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartTwo
{
    [Serializable]
    [Export(typeof(IVisualExport))]
    public class VisualExportPartTwo : MarshalByRefObject, IVisualExport, IDisposable
    {
        private NotifyIcon icon = new NotifyIcon();

        public VisualExportPartTwo()
        {
            icon.ContextMenu = new ContextMenu();
        }

        public object SetWindowState()
        {
            return new object();
        }

        public void Dispose()
        {
            this.ToString();
        }
    }
}
