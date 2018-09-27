using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlWriterReader
{
    public static class XmlReader<T>
    {
        private static List<T> _list = new List<T>();

        public static bool condition = true;
   
        public static List<T> Read(string fileName)
        {
            var formatter = new XmlSerializer(typeof(List<T>));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                    _list = (List<T>)formatter.Deserialize(fs);
            }
            return _list;
        }
    }
}
