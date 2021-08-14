using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.CreateXML
{
    public class XMLModel : IXMLModel
    {
        public XmlData Create(IXmlData data)
        {
            XmlData output = new XmlData();

            output.Path = data.Path;
            output.BeitragID = data.BeitragID;
            output.Name = data.Name;
            output.Type = data.Type;
            output.Text = data.Text;
            output.Hash = data.Hash;

            return output;
        }
    }
}
