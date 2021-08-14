using System;

namespace BeitragReader.LoginFolder
{
    public class LoginModel : ILoginModel
    {
        private string _userName;
        private string _passWord;
        private string _passWordHash;
        private string _salt;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
            }
        }

        public string PassWord
        {
            get { return _passWord; }
            set
            {
                _passWord = value;
            }
        }

        public string PassWordHash
        {
            get { return _passWordHash; }
            set
            {
                _passWordHash = value;
            }
        }

        public string Salt
        {
            get { return _salt; }
            set
            {
                _salt = value;
            }
        }

        public bool CanLogIn(string userName, string passWord)
        {
            LoginForm mc = new LoginForm();
            
            bool output = false;

            if (!String.IsNullOrWhiteSpace(userName) && !String.IsNullOrWhiteSpace(passWord))
            {
                output = true;
            }

            if (String.IsNullOrWhiteSpace(userName))
            {
                mc.ErrorMessage("Username is Empty");
                return output;
            }

            if (String.IsNullOrWhiteSpace(passWord))
            {
                mc.ErrorMessage("Password is Empty");
                return output;
            }

            //mc.ErrorMessage("Please add Username and Password!");
            return output;
        }

    }
}
