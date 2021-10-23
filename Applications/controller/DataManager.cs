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
        public static void writeToXml(Object o)
        {
            XmlSerializer xs = new XmlSerializer(o.GetType());
            TextWriter tw = new StreamWriter(@"..\..\..\data\obj.xml");
            xs.Serialize(tw, o);
        }
       

        public static void readFromXml(string s)
        {
                var sr = new StreamReader(@"..\..\..\data\"+ s+".xml"))
                obj = (ob)xs.Deserialize(sr);
        }
    }
}
}
