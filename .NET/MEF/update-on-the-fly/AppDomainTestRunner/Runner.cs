using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using AppDomainTestInterfaces;

namespace AppDomainTestRunner
{
    public class Runner : MarshalByRefObject
    {
        private CompositionContainer container;
        private DirectoryCatalog directoryCatalog;
        private IEnumerable<IExport> exports;

        private static readonly string pluginPath = Path.Combine();

    }
}
