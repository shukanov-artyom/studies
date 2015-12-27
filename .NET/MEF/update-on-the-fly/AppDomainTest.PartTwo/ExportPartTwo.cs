using System;
using AppDomainTestInterfaces;

namespace AppDomainTest.PartTwo
{
    public class ExportPartTwo : MarshalByRefObject, IExport
    {
        public void InHere()
        {
            
        }
    }
}
