using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CJB_Medical
{
    public static class XMLSerializer
    {
        public static string Serialize(object objectToSerialize)
        {
            string serializedObject = "";

            XmlSerializer xmlSerializer = new XmlSerializer(objectToSerialize.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, objectToSerialize);
                serializedObject = textWriter.ToString();
            }

            return serializedObject;
        }

        public static object Deserialize<T>(string serializedObject)
        {
            T deserializedObject = default(T);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializedObject = serializedObject.Replace(@"\r", string.Empty);
                serializedObject = serializedObject.Replace(@"\n", string.Empty);
                serializedObject = serializedObject.Replace(@"\", string.Empty);
                serializedObject = serializedObject.Replace(@"\", string.Empty);
                StringReader reader = new StringReader(serializedObject);
                deserializedObject = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception) { }
            return deserializedObject;
        }
    }
}
