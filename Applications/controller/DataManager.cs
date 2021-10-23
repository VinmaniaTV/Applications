using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Applications.controller
{
    public class DataManager
    {
        public static void writeToXml(object l)
        {
            XmlSerializer xs = new XmlSerializer(l.GetType());
            TextWriter tw = new StreamWriter(@"..\..\..\data\"+l.GetType().Name+".xml");
            xs.Serialize(tw, l);
            tw.Close();
        }

        public static Object readFromXml(Type type)
        {
            if (type is null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            XmlSerializer xs = new XmlSerializer(type);
            var sr = new StreamReader(@"..\..\..\data\" + type.Name + ".xml");
            return xs.Deserialize(sr); 
        }
    }
}

