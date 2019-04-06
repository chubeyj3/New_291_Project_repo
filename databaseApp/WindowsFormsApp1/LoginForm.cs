using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CMPT291_Project;
using WindowsFormsApp1;

namespace CMPT_291_Login_Page
{
    public partial class LoginForm : Form
    {
        
        SqlDataReader reader;
        DBManager db;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            if (isValidUser())
            {
                var dash = new WindowsFormsApp1.dashboard();
                dash.Show();
                this.Hide();
            }
        }

        private bool isValidUser()
        {
            //TODO: Actually do login functionality here
            db = new DBManager(WindowsFormsApp1.Properties.Settings.Default._291ProjectConnectionString);
            try
            {
                reader = db.query("SELECT * FROM MedSystemUser;");
            }
            catch (System.InvalidOperationException e){
                Application.Exit();
            }
            while (reader.Read())
            {
                if(reader.GetString(0) == this.usernameTextbox.Text && reader.GetString(1) == this.passwordTextbox.Text)
                {
                    GlobalVariables.UserAccess = reader.GetInt32(2);
                    db.closeConnection();
                    return true;
                }
            }

            db.closeConnection();
            return false;
        }

        private void setupDatabase()
        {
            //TODO: connect to the database and pull in the information after login is verified
            return;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
