using System;
using System.Configuration;

namespace Configuration
{
    /// <summary>
    /// Represents a Map Layer configuration element.
    /// </summary>
    public class MapLayerElement : ConfigurationElement
    {
        private const string ConfigurationPropertyName = "url";

        private static readonly ConfigurationProperty UrlConfigurationProperty;

        /// <summary>
        /// Constructs a <see cref="MapLayerElement" /> class.
        /// </summary>
        static MapLayerElement()
        {
            UrlConfigurationProperty = new ConfigurationProperty(
                ConfigurationPropertyName,
                typeof(string),
                null,
                ConfigurationPropertyOptions.IsRequired
            );
        }

        /// <summary>
        /// Gets the Url setting.
        /// </summary>
        [ConfigurationProperty(ConfigurationPropertyName, IsRequired = true)]
        public string Url
        {
            get
            {
                return (string)base[UrlConfigurationProperty];
            }
            set
            {
                base[UrlConfigurationProperty] = value;
            }
        }
    }
}
