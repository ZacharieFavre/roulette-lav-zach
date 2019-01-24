using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
 
namespace Jeu_de_la_roulette
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        class Login
        {
            //decalre properties 
            public string Username { get; set; }
            public string Userpassword { get; set; }

            //intialise  
            public Login(string user, string pass)
            {
                this.Username = user;
                this.Userpassword = pass;
            }
            //validate string 
            private bool StringValidator(string input)
            {
                string pattern = "[^a-zA-Z]";
                if (Regex.IsMatch(input, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //validate integer 
            private bool IntegerValidator(string input)
            {
                string pattern = "[^0-9]";
                if (Regex.IsMatch(input, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //clear user inputs 
            private void ClearTexts(string user, string pass)
            {
                user = String.Empty;
                pass = String.Empty;
            }
            //method to check if eligible to be logged in 
            internal bool IsLoggedIn(string user, string pass)
            {
                //check user name empty 
                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Enter the user name!");
                    return false;

                }
                //check user name is valid type 
                else if (StringValidator(user) == true)
                {
                    MessageBox.Show("Enter only text here");
                    ClearTexts(user, pass);
                    return false;
                }
                //check user name is correct 
                else
                {
                    if (Username != user)
                    {
                        MessageBox.Show("User name is incorrect!");
                        ClearTexts(user, pass);
                        return false;
                    }
                    //check password is empty 
                    else
                    {
                        if (string.IsNullOrEmpty(pass))
                        {
                            MessageBox.Show("Enter the passowrd!");
                            return false;
                        }
                        //check password is valid 
                        else if (IntegerValidator(pass) == true)
                        {
                            MessageBox.Show("Enter only integer here");
                            return false;
                        }
                        //check password is correct 
                        else if (Userpassword != pass)
                        {
                            MessageBox.Show("Password is incorrect");
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //Enter code here for your version of username and userpassword 
            Login login = new Login("admin", "1234");

            //define local variables from the user inputs 
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in successfully");
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
        }
    }
}
