namespace BeitragReader.LoginFolder
{
    public interface ILoginModel
    {
        string PassWord { get; set; }
        string UserName { get; set; }

        string Salt { get; set; }
        string PassWordHash { get; set; }
    }
}