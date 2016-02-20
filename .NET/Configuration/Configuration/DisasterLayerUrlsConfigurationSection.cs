using System;
using System.Configuration;

namespace Configuration
{
    /// <summary>
    /// Configuration section for configuring required Disaster Map layers.
    /// </summary>
    public class DisasterLayerUrlsConfigurationSection : ConfigurationSection
    {
        private static readonly ConfigurationProperty UrlsCollectionProperty;
        private static readonly ConfigurationProperty NameProperty;
        private static readonly ConfigurationPropertyCollection properties;

        /// <summary>
        /// Initializes <see cref="DisasterLayerUrlsConfigurationSection"/> class.
        /// </summary>
        static DisasterLayerUrlsConfigurationSection()
        {
            UrlsCollectionProperty = new ConfigurationProperty(
                String.Empty,
                typeof (DisasterMapUrlsCollection),
                null,
                ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsDefaultCollection
                );
            properties = new ConfigurationPropertyCollection();
            properties.Add(UrlsCollectionProperty);
        }

        /// <summary>
        /// Overrides Properties collection.
        /// </summary>
        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                return properties;
            }
        }

        /// <summary>
        /// Exposes configured Urls.
        /// </summary>
        public DisasterMapUrlsCollection Urls
        {
            get
            {
                return (DisasterMapUrlsCollection)base[UrlsCollectionProperty];
            }
        }
    }
}
