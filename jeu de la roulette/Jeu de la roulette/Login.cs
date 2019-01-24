using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;
using System.Threading.Tasks;

namespace Jeu_de_la_roulette
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        public class Login
        {
            //decalre properties 
            public string Username { get; set; }
            public string Userpassword { get; set; }
            public int amount { get; set; }

            //intialise  
            public Login(string user, string pass, int amount)
            {
                this.Username = user;
                this.Userpassword = pass;
                this.amount = amount;
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
            SQLiteConnection.CreateFile("MyDatabase.sqlite");

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "create table user (username varchar(20), password varchar(20), montant int);";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login("", "", 0);

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM user;", m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            // Call Read before accessing data.
            while (reader.Read())
            {
                //Enter code here for your version of username and userpassword 
                login = new Login(reader.GetString(0),reader.GetString(1),reader.GetInt32(2));
            }

            // Call Close when done reading.
            reader.Close();
            

            //define local variables from the user inputs 
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            int mont = login.amount;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in successfully");
                Accueil.createLogin(login);
                this.Close();
                
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
        }
        public static void MajSomme(int somme, string username)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "update user set montant = " + somme + " where username = '"+ username +"';";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }

        private void cmd_Inscription_Click(object sender, EventArgs e)
        {

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "insert into user (username, password, montant) values ('"+ txt_UsrName.Text +"', '"+ txt_pswd.Text +"', "+ txt_Amount.Text +" );";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();

            MessageBox.Show("Vous êtes bien inscrit! Veuillez vous logger.");
        }
    }
}
