using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace parse
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = File.OpenRead("files.txt"))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (File.Exists(line))
                        {
                            ProcessFile(line);
                        }
                    }
                }
            }
        }

        private static void ProcessFile(string fileName)
        {
            XDocument doc = XDocument.Load(fileName);
            bool hasChanges = false;
            foreach (XElement elem in doc.Root.Elements().Where(e => e.Name.LocalName == "Attachments"))
            {
                foreach (XElement fileAttach in elem.Elements().Where(e => e.Name.LocalName == "FileAttachment"))
                {
                    hasChanges = ProcessAttachElement(fileAttach);
                }
            }
            if (hasChanges)
            {
                doc.Save(fileName);
            }
        }

        private static bool ProcessAttachElement(XElement attach)
        {
            // Basic lement is here - it is namespace which we add to all element names
            XNamespace ns = "http://schemas.microsoft.com/exchange/services/2006/types";
            bool hasChanges = false;
            if (!attach.Elements().Any(el => el.Name.LocalName == "LastModifiedTime"))
            {
                XElement elem = new XElement(ns + "LastModifiedTime");
                elem.Name = ns + "LastModifiedTime";
                elem.Value = "2015-11-30T13:29:11.6088823+03:00";
                attach.Add(elem);
                hasChanges = true;
            }
            if (!attach.Elements().Any(el => el.Name.LocalName == "IsContactPhoto"))
            {
                XElement elem = new XElement(ns + "IsContactPhoto");
                elem.Name = ns +"IsContactPhoto";
                elem.Value = "false";
                attach.Add(elem);
                hasChanges = true;
            }
            else
            {
                if (attach.Elements().First(el => el.Name.LocalName == "IsContactPhoto").Value == "False")
                {
                    attach.Elements().First(el => el.Name.LocalName == "IsContactPhoto").Value = "false";
                    hasChanges = true;
                }
            }
            return hasChanges;
        }
    }
}
