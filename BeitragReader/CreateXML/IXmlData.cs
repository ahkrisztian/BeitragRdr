namespace BeitragReader.CreateXML
{
    public interface IXmlData
    {
        string BeitragID { get; set; }
        string Hash { get; set; }
        string Name { get; set; }
        string Path { get; set; }
        string Text { get; set; }
        string Type { get; set; }
        IXMLModel XMLProcessor { get; set; }
    }
}