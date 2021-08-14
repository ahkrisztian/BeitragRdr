using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using System.Threading.Tasks;

namespace BeitragReader.Search
{
    public class SearchXML
    {
        public void LoadXML(string XmlPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlPath);
        }
        public string deleteCharacter(string str)
        {
            var chrs = new[] { '!', ',', '.', ';', '?' };

            int index = 0;
            char[] result = new char[str.Length];
            str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetterOrDigit(str[i]) || Char.IsWhiteSpace(str[i]))
                {
                    result[index++] = str[i];
                }                   
            }
            return new string(result, 0, index);
        }

        public List<Search.ISearchType> XMLList(string Path, string Nodes)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/Beitrags/Beitrag");

            List<Search.ISearchType> infos = new List<Search.ISearchType>();

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                Search.SearchType info = new Search.SearchType();
                info.Name = xmlNode["Name"].InnerText;
                info.Type = xmlNode["Type"].InnerText;
                info.Text = xmlNode["Text"].InnerText;
                info.Hash = xmlNode["Hash"].InnerText;

                infos.Add(info);
            }

            return infos;
        }

        public async Task XmlListadd(string Path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);

            XmlNodeList xmlNodeList = xmlDoc.SelectNodes("/Beitrags/Beitrag");

            var infos = new List<Task>();

            foreach (XmlNode xmlNode in xmlNodeList)
            {
                Search.SearchType info = new Search.SearchType();
                info.Name = xmlNode["Name"].InnerText;
                info.Type = xmlNode["Type"].InnerText;
                info.Text = xmlNode["Text"].InnerText;
                info.Hash = xmlNode["Hash"].InnerText;

                infos.Add(Task.Run(() => xmlNode));
            }
            await Task.WhenAll(infos);
        }

        

    }
}
