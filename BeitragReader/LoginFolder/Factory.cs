using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.LoginFolder
{
    public class Factory
    {
        public static ILoginModel CreateUser()
        {
            return new LoginModel();
        }

        public static IUserLogin UserCanLogin()
        {
            return new UserLogin();
        }
    }
}
