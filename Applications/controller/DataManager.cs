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
            TextWriter tw = new StreamWriter(@"..\..\..\data\data.xml");
            xs.Serialize(tw, o);
        }
    }
}
