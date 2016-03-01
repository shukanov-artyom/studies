using System;
using System.Configuration;

namespace Configuration
{
    /// <summary>
    /// Urls collection kept inside a configuration section.
    /// </summary>
    public class DisasterMapUrlsCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Determines collection Type. 
        /// </summary>
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        /// <summary>
        /// Determines Element Name.
        /// </summary>
        protected override string ElementName
        {
            get
            {
                return "url";
            }
        }

        /// <summary>
        /// Exposes properties.
        /// </summary>
        protected override ConfigurationPropertyCollection Properties
        {
            get
            {
                return new ConfigurationPropertyCollection();
            }
        }

        /// <summary>
        /// Overrides new element creatin method.
        /// </summary>
        /// <returns>new instance of the <see cref="MapLayerElement"/> class.</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new MapLayerElement();
        }

        /// <summary>
        /// Provides Url as element key.
        /// </summary>
        /// <param name="element">Element to get key of.</param>
        /// <returns>Key value.</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as MapLayerElement).Url;
        }
    }
}
