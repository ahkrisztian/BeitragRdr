using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BeitragReader.Add
{
    public class AddtoXML
    {       
        public async Task CreateXml(string Path, List<BeitragModel.BeitragModel> model)
        {
            var list = new List<Task>();
            XDocument xDocument = XDocument.Load(Path);

            foreach (var v in model)
            {
                list.Add(Task.Run(() => 
                {
                    XElement root = xDocument.Element("Beitrags");
                    IEnumerable<XElement> rows = root.Descendants("Beitrag");
                    XElement firstRow = rows.First();
                    firstRow.AddBeforeSelf(
                    new XElement("Beitrag",
                    new XElement("Name", v.Name),
                    new XAttribute("ID", v.BeitragID),
                    new XElement("Type", v.Type),
                    new XElement("Text", v.Text),
                    new XElement("Hash", v.Hash)));
                }));
               
            }
            await Task.WhenAll(list);
            xDocument.Save(Path);
        }

        public void AddToXML(string Path, string Name, string Type, string Text, string Hash)
        {
            XDocument doc = XDocument.Load(Path);
            XElement beitrags = doc.Element("beitrags");

            beitrags.Add(new XElement("beitrag",
                new XAttribute("name", Name),
                new XElement("type", Type),
                new XElement("text", Text),
                new XElement("hash", Hash)));
            doc.Save(Path);
        }

        public void CreateXmlFile(CreateXML.IXmlData data)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment($"{data.Path}, {DateTime.Now}"),
                new XElement("Beitrags", 
                    new XElement("Beitrag",
                        new XElement("Name", data.Name),
                        new XAttribute("ID", Convert.ToInt32(data.BeitragID)),
                        new XElement("Type", data.Type),
                        new XElement("Text", data.Text),
                        new XElement("Hash", data.Hash))));

            xmlDocument.Save(data.Path);
        }

        public List<int> GetLastId(string Path)
        {
            List<int> Ids = new List<int>();

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(Path);
            }
            catch
            {
                
            }

            foreach (XmlNode node in doc.SelectNodes("/Beitrags/Beitrag"))
            {
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    Ids.Add(Convert.ToInt32(attribute.Value));
                }
            }

            return Ids;

        }

        public int BeitragIDNumber(int tempI)
        {
            AddForm mc = new AddForm();

            List<int> temp = new List<int>();

            foreach(int i in IdSList())
            {
                temp.Add(i);
            }           

            for(int i = 0; i < temp.Count;)
            {
                var result = tempI != temp[i] ? mc.i = tempI : tempI++;

                return result;
            }

            return Convert.ToInt32(null);

        }

        public List<int> IdSList()
        {
            List<int> newList = GetLastId($"C:\\erpo.XML");
            
            return newList;
        }

        public List<int> BeitragModelIDList()
        {
            List<int> IdList = new List<int>();

            AddForm mc = new AddForm();
            if (mc.beitragsModels.Count > 0)
            {
                foreach(var v in mc.beitragsModels)
                {
                    IdList.Add(v.BeitragID);
                }
            }

            return IdList;
        }

    }
}
