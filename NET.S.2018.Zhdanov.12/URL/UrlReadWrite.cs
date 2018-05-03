using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace URL
{
    public class UrlReadWrite
    {
        /// <summary>
        /// Save to xml
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="xmlFile"></param>
        public static void SaveToXML(IEnumerable<UrlStruct> urls, string xmlFile)
        {
            var writer = new XmlTextWriter(xmlFile, Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement("urls");
            foreach (var url in urls)
            {
                WriteURL(url);
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            return;

            void WriteURL(UrlStruct url)
            {
                writer.WriteStartElement("url");
                writer.WriteAttributeString("struct", url.Struct);
                WriteHost();
                WritePath();
                WriteParameters();
                writer.WriteEndElement();
                return;

                void WriteHost()
                {
                    writer.WriteStartElement("host");
                    writer.WriteAttributeString("name", url.Host);
                    writer.WriteEndElement();
                }

                void WritePath()
                {
                    if (url.Segments?.Length > 0)
                    {
                        writer.WriteStartElement("url");
                        foreach (var segment in url.Segments)
                        {
                            writer.WriteElementString("segment", segment);
                        }

                        writer.WriteEndElement();
                    }
                }

                void WriteParameters()
                {
                    if (url.Parameters?.Length > 0)
                    {
                        writer.WriteStartElement("parameters");
                        foreach (var param in url.Parameters)
                        {
                            writer.WriteStartElement("parameter");
                            writer.WriteAttributeString("key", param.Key);
                            writer.WriteAttributeString("value", param.Value);
                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();
                    }
                }
            }
        }

      /// <summary>
      /// Get URL
      /// </summary>
      /// <param name="textFilePath"></param>
      /// <returns></returns>
        public static UrlStruct[] GetURL(string textFilePath)
        {
            using (var reader = new StreamReader(File.OpenRead(textFilePath)))
            {
                var list = new List<UrlStruct>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (UrlStruct.TryParse(line, out UrlStruct url))
                    {
                        list.Add(url);
                    }
                   
                }

                return list.ToArray();
            }
        }
    }
}
