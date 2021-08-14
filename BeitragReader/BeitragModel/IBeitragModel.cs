namespace BeitragReader.BeitragModel
{
    public interface IBeitragModel
    {
        int BeitragID { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Text { get; set; }
        string Hash { get; set; }
        IBeitragController BeitragProcessor { get; set; }
    }
}