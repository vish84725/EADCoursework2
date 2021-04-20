using EADCoursework2.Models;
using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EADCoursework2.DAL
{
    public class RemoteAccessService
    {
        Serializer serializer;
        static ReaderWriterLock locker = new ReaderWriterLock();

        public RemoteAccessService()
        {
            serializer = new Serializer();
        }
        
        public void ClearCachedObject<T>(T obj)where T : class
        {
            try
            {
                var path = Constants.LOCAL_XML_PATH + typeof(T).Name + ".xml";
                File.Delete(path);
            }
            catch(Exception e)
            {

            }
        }
        public void WriteToXML<T>(T obj)where T : class
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var path = Constants.LOCAL_XML_PATH + typeof(T).Name + ".xml";

                XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                FileStream file = System.IO.File.Create(path);

                writer.Serialize(file, obj);
                file.Close();
            }
            catch(Exception e)
            {

            }
            finally
            {
                locker.ReleaseWriterLock();
            }

        }

        public T ReadXML<T>() where T : class
        {
            try
            {
                var path = $"{Constants.LOCAL_XML_PATH}{typeof(T).Name}.xml";
                var xmlInputData = File.ReadAllText(path);

                var obj = serializer.Deserialize<T>(xmlInputData);
                var xmlOutputData = serializer.Serialize<T>(obj);

                //string xml = File.ReadAllText($"{Constants.LOCAL_XML_PATH}{tag}.xml");
                //var result = Deserialize<T>(xml);
                return obj;
            }
            catch(Exception e)
            {
                return default(T);
            }


        }

    }
}
