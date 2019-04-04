﻿using System;
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
            if(isValidUser())
            {
                this.Hide();
                var dash = new WindowsFormsApp1.dashboard();
                dash.Show();
            }
        }

        private bool isValidUser()
        {
            //TODO: Actually do login functionality here
            db = new DBManager("Data Source=LAPTOP-STRPANMF;Initial Catalog=291Project;Integrated Security=True");
            reader = db.query("SELECT * FROM MedSystemUser;");
            while (reader.Read())
            {
                if(reader.GetString(0) == this.usernameTextbox.Text && reader.GetString(1) == this.passwordTextbox.Text)
                {
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
    }
}
