using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChangeVersion("2.2.2.2", @"d:\dev\trunk\Database\db-updates.xml");
            //string vv = GetConfigDatabaseVersion("3.3.3.3");
            Rename(@"d:\dev\trunk\Database\db-updates.xml", "06");
        }

        public static void Rename(string dbUpdatesXmlFilePath, string newVersionRevision)
        {
            if (!File.Exists(dbUpdatesXmlFilePath))
            {
                throw new FileNotFoundException("XML File not found");
            }
            XDocument doc;
            using (FileStream xmlFileStream =
                File.Open(dbUpdatesXmlFilePath, 
                FileMode.Open, 
                FileAccess.ReadWrite, 
                FileShare.None))
            {
                doc = XDocument.Load(xmlFileStream);
            }

            XElement database = doc.Root.Elements("database").FirstOrDefault(el => el.Attribute("version").Value.Contains("next"));
            if (database == null)
            {
                return;
            }
            string oldVersion = database.Attribute("version").Value;
            string newVersion = oldVersion.Replace("next", newVersionRevision);
            database.Attribute("version").Value = newVersion;

            XAttribute nameAttr = database.Element("update-set").Element("script-file").Attribute("name");
            string fileNameInXml = nameAttr.Value;
            string newFileNameInXml = fileNameInXml.Replace("next", newVersionRevision);
            nameAttr.Value = newFileNameInXml;
            using (FileStream rewriteStream = new FileStream(
                dbUpdatesXmlFilePath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None))
            {
                rewriteStream.Position = 0;
                doc.Save(rewriteStream);
            }
        }

        /*public static void ChangeVersion(string newVersion, string xmlFilePath)
        {
            if (!File.Exists(xmlFilePath))
            {
                throw new FileNotFoundException("XML File not found");
            }
            using (FileStream xmlFileStream = 
                File.Open(xmlFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                XDocument doc = XDocument.Load(xmlFileStream);
                XAttribute attr = doc.Root.Attribute("version");
                attr.SetValue(newVersion);
                xmlFileStream.Position = 0;
                doc.Save(xmlFileStream);
            }
        }

        public static string GetConfigDatabaseVersion(string version)
        {
            string[] split = version.Split('.');
            StringBuilder sb = new StringBuilder();
            sb.Append("1");
            for (int i=1; i<split.Length; i++)
            {
                sb.Append(String.Format(".{0}", split[i]));
            }
            return sb.ToString();
        }*/
    }
}
