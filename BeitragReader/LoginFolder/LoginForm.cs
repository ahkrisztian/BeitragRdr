using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeitragReader.LoginFolder
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ILoginModel Model = Factory.CreateUser();
            IUserLogin userLogin = Factory.UserCanLogin();
            Model.UserName = usernametextBox.Text;
            Model.PassWord = passwordTextBox.Text;

            if (userLogin.CanLogIn(Model))
            {

                if (SqliteDataAccess.CheckUserifExits(Model))
                {
                    
                    List<ILoginModel> x =  SqliteDataAccess.LoadUserModel(usernametextBox.Text);

                    if (SqliteDataAccess.isValidUser(x[0], passwordTextBox.Text))
                    {
                        this.Hide();
                        Beitrag f2 = new Beitrag();
                        MessageBox.Show($"Welcome {Model.UserName}!");
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("User not valid");
                    }

                }
                else
                {
                    MessageBox.Show("User not found!");
                }

            }
        }

        public void ErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void showcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showcheckBox.Checked ? '\0' : '*';
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            ILoginModel Model = Factory.CreateUser();
            Model.UserName = usernametextBox.Text;
            Model.PassWord = passwordTextBox.Text;

            if (SqliteDataAccess.CheckUserifExits(Model))
            {
                MessageBox.Show("User already exists");
            }
            else
            {
                SqliteDataAccess.SaveUser(Model.UserName, Model.PassWord);
                MessageBox.Show("Userd added to Database");
                usernametextBox.Clear();
                passwordTextBox.Clear();
            }

        }
    }
}
