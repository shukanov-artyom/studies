using System;
using System.Configuration;
using System.Linq;

namespace Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            DisasterLayerUrlsConfigurationSection section = ConfigurationManager.GetSection("disasterMapUrls") as DisasterLayerUrlsConfigurationSection;
            foreach (MapLayerElement url in section.Urls.Cast<MapLayerElement>())
            {
                Console.WriteLine(url.Url);
            }
        }
    }
}
