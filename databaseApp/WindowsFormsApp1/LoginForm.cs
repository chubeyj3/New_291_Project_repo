using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_291_Login_Page
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(isValidUser("test", "password123"))
            {
                this.Hide();
                var dash = new WindowsFormsApp1.dashboard();
                dash.Show();
            }
        }

        private bool isValidUser(string username, string password)
        {
            //TODO: Actually do login functionality here
            setupDatabase();
            return true;
        }

        private void setupDatabase()
        {
            //TODO: connect to the database and pull in the information after login is verified
            return;
        }
    }
}
