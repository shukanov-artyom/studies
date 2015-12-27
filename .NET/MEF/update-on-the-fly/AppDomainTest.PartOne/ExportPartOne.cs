using System;
using System.ComponentModel.Composition;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartOne
{
    [Export]
    public class ExportPartOne : MarshalByRefObject, IExport
    {
        public void InHere()
        {

        }
    }
}
