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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {

        private Panel currentView;
        private Panel previousView;
        private int selectedRow = 0;

        public dashboard()
        {
            InitializeComponent();
            //BackColor = ColorTranslator.FromHtml("#25282F");
            currentView = doctorView;
            previousView = doctorView;
            currentView.Visible = true;
            patientView.Visible = false;
            departmentPanel.Visible = false;
            wardsPanel.Visible = false;

            if(GlobalVariables.UserAccess == 2)
            {
                wardDashboardButton.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291ProjectDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this._291ProjectDataSet.Doctor);
            // TODO: This line of code loads data into the '_291ProjectDataSet.Ward' table. You can move, or remove it, as needed.
            this.wardTableAdapter.Fill(this._291ProjectDataSet.Ward);
            // TODO: This line of code loads data into the '_291ProjectDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._291ProjectDataSet.Department);
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
            setView(departmentPanel);
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
            selectedRow = 0;
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

        private void wardDashboardButton_Click(object sender, EventArgs e)
        {
            setView(wardsPanel);
            dgWards.BringToFront();

            string query = "SELECT * FROM Ward";
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable wardsTable = new DataTable();
            sqlAdapter.Fill(wardsTable);

            dgWards.DataSource = wardsTable;
        }

        private void btnExpandDoctor_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
                return;

            string sql_select = "SELECT DISTINCT Patient.FirstName + ' ' + Patient.LastName as PatientName, "
                + "CAST(PatientRegistration.[Year] as varchar(10)) "
                + "+ ' ' + CAST(PatientRegistration.Month as varchar(10)) "
                + "+ ' ' + CAST(PatientRegistration.Day as varchar(10)) as Admitted "
                + "FROM PatientRegistration, Consultant, Patient "
                + "WHERE Consultant.PatientRegNum = PatientRegistration.RegistrationNumber "
                + "AND Patient.PID = PatientRegistration.PID "
                + "AND Consultant.DoctorID = ";
            object contents = dgDoctor.Rows[selectedRow].Cells[0].Value;
            sql_select += contents.ToString();

            SubQueryForm sqf = new SubQueryForm("Doctor #" + contents.ToString() + "'s Patient History", sql_select);
            sqf.Show();
        }

        private void btnExpandPatient_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
                return;

            string sql_select = "SELECT ConInfo.ContactType, ConInfo.Contact, ConInfo.Description "
                + "FROM PatientContactInfo as ConInfo "
                + "WHERE ConInfo.PID = ";
            object contents = dgPatient.Rows[selectedRow].Cells[0].Value;
            sql_select += contents.ToString();

            SubQueryForm sqf = new SubQueryForm("Patient #" + contents.ToString() + "'s Contact Information", sql_select);
            sqf.Show();

        }

        private void btnExpandDept_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
                return;

            string sql_select = "SELECT Doctor.FirstName + ' ' + Doctor.LastName as Name "
                   + "FROM Doctor "
                   + "WHERE Doctor.DepartmentID = ";
            object contents = dgDepartment.Rows[selectedRow].Cells[0].Value;
            sql_select += contents.ToString();

            SubQueryForm sqf = new SubQueryForm("Doctors in Department #" + contents.ToString(), sql_select);
            sqf.Show();
        }

        private void btnExpandWard_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
                return;

            string sql_select = "SELECT Patient.FirstName + ' ' + Patient.LastName as PatientName, "
                + "CAST(PReg.[Year] as varchar(10)) "
                + "+ ' ' + CAST(PReg.Month as varchar(10)) "
                + "+ ' ' + CAST(PReg.Day as varchar(10)) as Admitted "
                + "FROM Patient, Ward, PatientRegistration as PReg "
                + "WHERE PReg.WardID = Ward.WardID "
                + "AND Patient.PID = PReg.PID "
                + "AND PReg.WardID = ";
            object contents = dgWards.Rows[selectedRow].Cells[0].Value;
            sql_select += contents.ToString();

            SubQueryForm sqf = new SubQueryForm("Patients in Ward " + contents.ToString(), sql_select);
            sqf.Show();
        }

        private void dgDoctor_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedRow = e.RowIndex;
        }

        private void dgPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedRow = e.RowIndex;
        }

        private void dgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedRow = e.RowIndex;
        }

        private void dgWards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedRow = e.RowIndex;
        }
    }
}
