using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.CreateXML
{
    public class XmlData : IXmlData
    {
        public string Path { get; set; }
        public string BeitragID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string Hash { get; set; }

        public IXMLModel XMLProcessor { get; set; } = new XMLModel();

    }
}
