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
            currentView = doctorView;
            previousView = doctorView;
            currentView.Visible = true;
            patientView.Visible = false;
            //patientView1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291ProjectDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this._291ProjectDataSet.Patient);
            // TODO: This line of code loads data into the '_291ProjectDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this._291ProjectDataSet.Doctor);
        }

        /**
         * Handles the window swapping (to switch between views)
         * */
        private void dashboardButton1_Click(object sender, EventArgs e)
        {
            setView(doctorView);
            
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
            setView(doctorView);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            setView(doctorView);
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

        }

        private void doctorView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dashboardButton2_Click(object sender, EventArgs e)
        {
            setView(patientView);
        }

        private void DoctorBind_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void homepage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void queryView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql_select = "SELECT DISTINCT Patient.FirstName + ' ' + Patient.LastName "
                + "FROM PatientRegistration, Consultant, Patient "
                + "WHERE Consultant.PatientRegNum = PatientRegistration.RegistrationNumber "
                + "AND Patient.PID = PatientRegistration.PID "
                + "AND Consultant.DoctorID = ";
            object contents = dgDoctor.Rows[e.RowIndex].Cells[0].Value;
            sql_select += contents.ToString();

            lblDoctorViewTitle.Text = sql_select;
            lblDoctorViewTitle.Refresh();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = sql_select;

            SqlDataAdapter sda = new SqlDataAdapter(comm);

            DataTable doctorPatients = new DataTable();
            sda.Fill(doctorPatients);
            BindingSource bind = new BindingSource();
            bind.DataSource = doctorPatients;

            SubQueryForm sqf = new SubQueryForm("Doctor's Patients", bind);
            sqf.Show();
        }

        private void dgDoctor_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sql_select = "SELECT DISTINCT Patient.FirstName + ' ' + Patient.LastName "
                + "FROM PatientRegistration, Consultant, Patient "
                + "WHERE Consultant.PatientRegNum = PatientRegistration.RegistrationNumber "
                + "AND Patient.PID = PatientRegistration.PID "
                + "AND Consultant.DoctorID = ";
            object contents = dgDoctor.Rows[e.RowIndex].Cells[0].Value;
            sql_select += contents.ToString();

            lblDoctorViewTitle.Text = sql_select;
            lblDoctorViewTitle.Refresh();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = sql_select;

            SqlDataAdapter sda = new SqlDataAdapter(comm);

            DataTable doctorPatients = new DataTable();
            sda.Fill(doctorPatients);
            BindingSource bind = new BindingSource();
            bind.DataSource = doctorPatients;

            SubQueryForm sqf = new SubQueryForm("Doctor's Patients", bind);
            sqf.Show();
        }

        private void departmentDashboardButton_Click(object sender, EventArgs e)
        {
            setView(departmentPanel);
            dgDepartment.BringToFront();

            string query = "SELECT DepartmentID, Name FROM Department";
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable departmentTable = new DataTable();
            sqlAdapter.Fill(departmentTable);

            dgDepartment.DataSource = departmentTable;
        }
    }
}
