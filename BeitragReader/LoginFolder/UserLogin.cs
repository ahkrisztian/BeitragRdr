using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeitragReader.LoginFolder
{
    public class UserLogin : IUserLogin
    {
        ILoginModel _model;

        public bool CanLogIn(ILoginModel model)
        {
            _model = model;

            bool output = false;

            if (!String.IsNullOrWhiteSpace(_model.UserName) && !String.IsNullOrWhiteSpace(_model.PassWord))
            {
                output = true;
            }

            if (String.IsNullOrWhiteSpace(_model.UserName))
            {
                LoginFolder.LoginForm mc = new LoginForm();
                mc.ErrorMessage("Username is Empty");
                return output;
            }

            if (String.IsNullOrWhiteSpace(_model.PassWord))
            {
                LoginFolder.LoginForm mc = new LoginForm();
                mc.ErrorMessage("Password is Empty");
                return output;
            }

            return output;
        }

    }
}
