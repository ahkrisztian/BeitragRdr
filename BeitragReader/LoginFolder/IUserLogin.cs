namespace BeitragReader.LoginFolder
{
    public interface IUserLogin
    {
        bool CanLogIn(ILoginModel model);
    }
}