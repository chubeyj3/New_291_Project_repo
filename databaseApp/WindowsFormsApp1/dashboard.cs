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
        private FilterBox filterDocFirstName;
        private FilterBox filterDocLastName;
        private FilterBox filterPatientFirstName;
        private FilterBox filterPatientLastName;
        public dashboard()
        {
            InitializeComponent();
            setupFilters();
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
                pnlAddDoctor.Hide();
            }
        }

        private void setupFilters()
        {


            filterDocFirstName = new FilterBox("First Name");
            filterDocLastName = new FilterBox("Last Name");

            filterPatientFirstName = new FilterBox("First Name");
            filterPatientLastName = new FilterBox("Last Name");

            doctorView.Controls.Add(filterDocLastName);
            doctorView.Controls.Add(filterDocFirstName);
            patientView.Controls.Add(filterPatientFirstName);
            patientView.Controls.Add(filterPatientLastName);
            /**
             * UI STUFF
             */

            filterDocFirstName.ForeColor = System.Drawing.Color.Gray;
            filterDocLastName.ForeColor = System.Drawing.Color.Gray;
            filterDocFirstName.Location = new System.Drawing.Point(224, 34);
            filterDocLastName.Location = new System.Drawing.Point(400, 34);
            filterDocFirstName.Name = "filterDocFirstName";
            filterDocFirstName.Size = new System.Drawing.Size(132, 20);
            filterDocFirstName.TabIndex = 13;
            filterDocFirstName.Text = "Search by First Name ...";

            filterDocLastName.Name = "filterDocLastName";
            filterDocLastName.Size = new System.Drawing.Size(140, 20);
            filterDocLastName.TabIndex = 14;
            filterDocLastName.Text = "Search by Last Name ...";


            filterPatientFirstName.ForeColor = System.Drawing.Color.Gray;
            filterPatientLastName.ForeColor = System.Drawing.Color.Gray;
            filterPatientFirstName.Location = new System.Drawing.Point(50, 34);
            filterPatientLastName.Location = new System.Drawing.Point(175, 34);
            filterPatientFirstName.Name = "filterPatientFirstName";
            filterPatientFirstName.Size = new System.Drawing.Size(115, 20);
            filterPatientFirstName.TabIndex = 13;
            filterPatientFirstName.Text = "Search by First Name ...";
            filterPatientLastName.Name = "filterPatientLastName";
            filterPatientLastName.Size = new System.Drawing.Size(115, 20);
            filterPatientLastName.TabIndex = 13;
            filterPatientLastName.Text = "Search by Last Name ...";

            pIDDataGridViewTextBoxColumn.Width = 50;

            /**
            * FUNCTIONAL STUFF 
            */

            filterDocFirstName.KeyDown += new KeyEventHandler(filterDocName_KeyDown);
            filterDocLastName.KeyDown += new KeyEventHandler(filterDocName_KeyDown);
            filterDocFirstName.setData(doctorBindingSource, 1, dgDoctor);
            filterDocLastName.setData(doctorBindingSource, 2, dgDoctor);

            // Patient filters

            filterPatientFirstName.KeyDown += new KeyEventHandler(filterPatient_KeyDown);
            filterPatientLastName.KeyDown += new KeyEventHandler(filterPatient_KeyDown);
            filterPatientFirstName.setData(patientBindingSource, 1, dgPatient);
            filterPatientLastName.setData(patientBindingSource, 2, dgPatient);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_291ProjectDataSet1.MedSystemUser' table. You can move, or remove it, as needed.
            this.medSystemUserTableAdapter.Fill(this._291ProjectDataSet1.MedSystemUser);
            // TODO: This line of code loads data into the '_291ProjectDataSet.User' table. You can move, or remove it, as needed.
            //this.userTableAdapter.Fill(this._291ProjectDataSet.User);
            // TODO: This line of code loads data into the '_291ProjectDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this._291ProjectDataSet.Doctor);
            // TODO: This line of code loads data into the '_291ProjectDataSet.Ward' table. You can move, or remove it, as needed.
            this.wardTableAdapter.Fill(this._291ProjectDataSet.Ward);
            // TODO: This line of code loads data into the '_291ProjectDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._291ProjectDataSet.Department);
            // TODO: This line of code loads data into the '_291ProjectDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this._291ProjectDataSet.Patient);
            

            // Initialise combox box for department selection
            string dept_id_name_query = "SELECT DepartmentID, Name FROM Department";
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(dept_id_name_query, sqlConnection);
            DataTable deptTable = new DataTable();
            sqlAdapter.Fill(deptTable);
            cmbDoctorDepartmentSelect.DataSource = deptTable;
            cmbDoctorDepartmentSelect.DisplayMember = "Name";
            cmbDoctorDepartmentSelect.ValueMember = "DepartmentID";
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


        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void dashboardButton2_Click(object sender, EventArgs e)
        {
            setView(patientView);
        }


        private void departmentDashboardButton_Click(object sender, EventArgs e)
        {
            setView(departmentPanel);
        }

        private void wardDashboardButton_Click(object sender, EventArgs e)
        {
            setView(wardsPanel);
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

            string name = dgDoctor.Rows[selectedRow].Cells[1].Value.ToString() + " " + dgDoctor.Rows[selectedRow].Cells[2].Value.ToString();

            SubQueryForm sqf = new SubQueryForm(name + "'s Patient History", sql_select);
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

            string name = dgPatient.Rows[selectedRow].Cells[1].Value.ToString() + " " + dgPatient.Rows[selectedRow].Cells[2].Value.ToString();
            SubQueryForm sqf = new SubQueryForm(name + "'s Contact Information", sql_select);
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

        private void btnDoctorSubmit_Click(object sender, EventArgs e)
        {
            string max_id_query = "SELECT MAX(DoctorID) FROM Doctor";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(max_id_query, conn);
            SqlDataReader sql_reader = comm.ExecuteReader();
            sql_reader.Read();
            int next_id = (int) sql_reader[0];
            next_id++;
            sql_reader.Close();
            conn.Close();

            string insert_doc_query = "INSERT INTO Doctor Values ("
                + next_id.ToString() + ", "
                + cmbDoctorDepartmentSelect.SelectedValue + ", '"
                + sanitizeQuery(txbDoctorDuties.Text) + "', '"
                + sanitizeQuery(txbDoctorFirstName.Text) + "', '"
                + sanitizeQuery(txbDoctorLastName.Text) + "')";
            lblDoctorViewTitle.Text = insert_doc_query;

            conn = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            conn.Open();
            comm = new SqlCommand(insert_doc_query, conn);
            comm.ExecuteNonQuery();
            conn.Close();


            doctorBindingSource.ResetBindings(false);
            this.doctorTableAdapter.Fill(this._291ProjectDataSet.Doctor);

            string msg = "Doctor " + txbDoctorFirstName.Text + " " + txbDoctorLastName.Text + " successfully added.";
            MessageBox.Show(msg);
            txbDoctorFirstName.Text = String.Empty;
            txbDoctorLastName.Text = String.Empty;
            txbDoctorDuties.Text = String.Empty;

            

        }

        private string sanitizeQuery(string query)
        {
            string search = String.Empty;
            foreach (char c in query)
            {
                if (char.IsLetterOrDigit(c))
                {
                    search += c;
                }
            }

            return search;
        }
        private void filterDocName_KeyDown(object sender, KeyEventArgs e)
        {
            updateFilter(doctorBindingSource, filterDocFirstName, filterDocLastName, dgDoctor);
        }

        private void filterPatient_KeyDown(object sender, KeyEventArgs e)
        {
            updateFilter(patientBindingSource, filterPatientFirstName, filterPatientLastName, dgPatient);
        }
       
        private void updateFilter(BindingSource bs, FilterBox filter1, FilterBox filter2, DataGridView dg)
        {
            string[] filters = new string[2];
            filters[0] = filter1.getFilter();
            filters[1] = filter2.getFilter();


            if(filters[0] != String.Empty)
            {
                string final = filters[0];
                if(filters[1] != String.Empty)
                {
                    final = "(" + final + ") AND (" + filters[1] + ")";
                }
                bs.Filter = final;
            }

            else if(filters[1] != String.Empty)
            {
                string final = filters[1];
                bs.Filter = final;
            }
            else
            {
                bs.RemoveFilter();
            }

            bs.EndEdit();
            dg.Refresh();
           }

        private void usersDashboardBtn_Click(object sender, EventArgs e)
        {
            setView(usersView);
        }

        private void btnPatientSubmit_Click(object sender, EventArgs e)
        {
            string max_id_query = "SELECT MAX(PID) FROM Patient";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(max_id_query, conn);
            SqlDataReader sql_reader = comm.ExecuteReader();
            sql_reader.Read();
            int next_id = (int)sql_reader[0];
            next_id++;
            sql_reader.Close();
            conn.Close();

            string insert_patient_query = "INSERT INTO Patient Values ("
                + next_id.ToString() + ", "
                + sanitizeQuery(lblPatientFirstNameTxb.Text) + "', '"
                + sanitizeQuery(lblPatientLastNameTxb.Text) + "')";
            lblDoctorViewTitle.Text = insert_patient_query;

            conn = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            conn.Open();
            comm = new SqlCommand(insert_patient_query, conn);
            comm.ExecuteNonQuery();
            conn.Close();


            patientBindingSource.ResetBindings(false);
            this.patientTableAdapter.Fill(this._291ProjectDataSet.Patient);

            string msg = "Patient " + lblPatientFirstNameTxb.Text + " " + lblPatientLastNameTxb.Text + " successfully added.";
            MessageBox.Show(msg);
            lblPatientFirstNameTxb.Text = String.Empty;
            lblPatientLastNameTxb.Text = String.Empty;


        }
    }
}
