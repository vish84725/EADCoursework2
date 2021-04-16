using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EADCoursework2.DAL
{
    public class RemoteAccessService
    {
        public static string Serialize<T>(T dataToSerialize)
        {
            try
            {
                var stringwriter = new System.IO.StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
            catch
            {
                throw;
            }
        }

        public static T Deserialize<T>(string xmlText)
        {
            try
            {
                var stringReader = new System.IO.StringReader(xmlText);
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
            catch
            {
                throw;
            }
        }

        public void WriteToXML<T>(T obj, string tag)
        {
            try
            {
                //var path = $"{Constants.LOCAL_XML_PATH}{tag}.xml";
                //if (!File.Exists(path))
                //{
                //    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                //    xmlWriterSettings.Indent = true;
                //    xmlWriterSettings.NewLineOnAttributes = true;
                //    using (XmlWriter xmlWriter = XmlWriter.Create(path, xmlWriterSettings))
                //    {
                //        xmlWriter.WriteStartDocument();
                //        xmlWriter.WriteStartElement(obj.GetType().Name,"");

                //        foreach (var property in typeof(T).GetProperties())
                //        {
                //            xmlWriter.WriteElementString(property.Name, property.GetValue(obj).ToString());
                //        }

                //        xmlWriter.WriteEndElement();
                //        xmlWriter.WriteEndDocument();
                //        xmlWriter.Flush();
                //        xmlWriter.Close();
                //    }
                //}
                //else
                //{
                //    XDocument xDocument = XDocument.Load(path);
                //    XElement root = xDocument.Element(tag);
                //    if(root != null)
                //        root.Remove();
                //    XElement newRoot = new XElement(tag);
                //    foreach (var property in typeof(T).GetProperties())
                //    {
                //        newRoot.Add(new XElement(property.Name, property.GetValue(obj)));
                //    }
                //    xDocument.Add(newRoot);
                //    xDocument.Save(path);

                //    //XElement
                //    //foreach (var property in typeof(T).GetProperties())
                //    //{
                //    //    var r = root.Descendants();
                //    //    r.
                //    //    IEnumerable<XElement> rows = root.Descendants(property.Name);
                //    //    XElement firstRow = rows.First();
                //    //    firstRow.AddBeforeSelf(
                //    //       new XElement(property.Name,
                //    //       new XElement(property.Name, property.GetValue(obj))));
                //    //}

                //    //xDocument.Save(path);
                //}


















                var path = Constants.LOCAL_XML_PATH+tag+".xml";

                XmlTextWriter xmlWriter = new XmlTextWriter(path, null);
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement(tag, "");

                foreach (var property in typeof(T).GetProperties())
                {
                    xmlWriter.WriteElementString(property.Name, property.GetValue(obj).ToString());
                }


                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();

            }
            catch(Exception e)
            {

            }

        }

        public T ReadXML<T>(string tag)
        {
            try
            {
                string xml = File.ReadAllText($"{Constants.LOCAL_XML_PATH}{tag}.xml");
                var result = Deserialize<T>(xml);
                return result;
            }
            catch(Exception e)
            {
                return default(T);
            }


        }

    }
}
