using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {

        private Panel currentView;
        private Panel previousView;
        public dashboard()
        {
            InitializeComponent();
            //BackColor = ColorTranslator.FromHtml("#25282F");
            currentView = homePage;
            previousView = homePage;
            queryView.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    this.doctorTableAdapter1.Fill(this._291ProjectDataSet.Doctor);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
        }

        /**
         * Handles the window swapping (to switch between views)
         * */
        private void dashboardButton1_Click(object sender, EventArgs e)
        {
            setView(queryView);
            
        }

        private void backButton_Paint(object sender, PaintEventArgs e)
        {
            backButton.FlatAppearance.MouseOverBackColor = backButton.BackColor;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = ColorTranslator.FromHtml("#4a9c8a");
        }

        private void setView(Panel newView)
        {
            currentView.Visible = false;
            previousView = currentView;
            currentView = newView;
            currentView.Visible = true;
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            setView(previousView);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            setView(homePage);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            setView(homePage);
        }

        private void sideBar1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctorTableAdapter1.Fill(this._291ProjectDataSet.Doctor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
