using System;
using System.IO;

namespace fly
{
    internal class Program
    {
        //http://multithreadthoughts.blogspot.com.by/2013/08/mef-and-appdomain-remove-assemblies-on.html
        private static AppDomain domain;

        [STAThread]
        private static void Main()
        {
            var cachePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "ShadowCopyCache");
            var pluginPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "Plugins");
            if (!Directory.Exists(cachePath))
            {
                Directory.CreateDirectory(cachePath);
            }
            if (!Directory.Exists(pluginPath))
            {
                Directory.CreateDirectory(pluginPath);
            }
            // This creates a ShadowCopy of the MEF DLL's (and any other DLL's in the ShadowCopyDirectories)
            var setup = new AppDomainSetup
            {
                CachePath = cachePath,
                ShadowCopyFiles = "true",
                ShadowCopyDirectories = pluginPath
            };
        }
    }
}
