using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace SismontProcessos
{
    public static class Extensions
    {
        public static byte[] ObjectToByteArray(this Object obj)
        {
            if (obj == null)
            {
                return null;
            }
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            try
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Object ByteArrayToObject(this byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }

        public static byte[] SerializeToXml<T>(this T value)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(T));
            StringWriter stringWriter = new StringWriter();
            XmlWriter writer = XmlWriter.Create(stringWriter);
            xmlserializer.Serialize(writer, value);
            return stringWriter.ToString().ObjectToByteArray();
        }
    }
}