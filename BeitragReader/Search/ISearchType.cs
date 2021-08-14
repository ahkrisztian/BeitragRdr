namespace BeitragReader.Search
{
    public interface ISearchType
    {
        string Name { get; set; }

        string Type { get; set; }
        string Text { get; set; }
        string Hash { get; set; }
        string ID { get; set; }
        ISearchController SearchProcessor { get; set; }
    }
}