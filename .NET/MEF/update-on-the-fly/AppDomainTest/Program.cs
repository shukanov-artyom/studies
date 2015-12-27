using System;
using System.IO;
using AppDomainTestInterfaces;
using AppDomainTestRunner;

namespace AppDomainTest
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
            // Create a new AppDomain then create an new instance of this application in the new AppDomain.
            // This bypasses the Main method as it's not executing it.
            domain = AppDomain.CreateDomain(
                "Host_AppDomain", 
                AppDomain.CurrentDomain.Evidence, 
                setup);
            var runner = (Runner)domain.CreateInstanceAndUnwrap(
                typeof(Runner).Assembly.FullName, 
                typeof(Runner).FullName);

            IVisualExport visual = runner.GetVisual();
            IEventsExport eventsStarter = runner.GetEventsStarter();
            eventsStarter.SomeEvent += StarterOnSomeEvent;
            eventsStarter.SomeOtherEvent += StarterOnSomeOtherEvent;

            Console.WriteLine("The main AppDomain is: {0}", AppDomain.CurrentDomain.FriendlyName);

            // We now have access to all the methods and properties of Program.   
            runner.DoWorkInShadowCopiedDomain();
            runner.DoSomething();

            Console.WriteLine("\nHere you can remove a DLL from the Plugins folder.");
            Console.WriteLine("Press any key when ready...");
            Console.ReadKey();

            // After removing a DLL, we can now recompose the MEF parts and see that the removed DLL is no longer accessed.
            runner.Recompose();
            runner.DoSomething();
            Console.WriteLine("Press any key when ready...");
            Console.ReadKey();

            // Clean up.
            AppDomain.Unload(domain);
        }

        private static void StarterOnSomeEvent(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Some event fired");
        }

        private static void StarterOnSomeOtherEvent(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
