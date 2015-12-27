using System;
using System.Windows;

namespace appdom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            AppDomainSetup setup = new AppDomainSetup();
            AppDomain domain = AppDomain.CreateDomain("MyAppDomain", AppDomain.CurrentDomain.Evidence, setup);
            DomainObjectFactory kpr = domain.CreateInstanceAndUnwrap(typeof (DomainObjectFactory).Assembly.FullName,
                typeof (DomainObjectFactory).FullName) as DomainObjectFactory;
            var result = kpr.Generate();
            result.Do(); // Displaying WPF window from another domain
            base.OnStartup(e);
        }
    }
}
