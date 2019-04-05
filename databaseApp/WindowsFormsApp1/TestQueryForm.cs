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

namespace WindowsFormsApp1
{
    public partial class TestQueryForm : Form
    {
        public TestQueryForm()
        {
            InitializeComponent();

            string sname = @"SURFACE-LAPTOP-\MSSQLSERVER01";
            string dbname = "291Project";
            string username = "admin";
            string password = "12345";
            DBManager db = new DBManager(sname, dbname, username, password);
            SqlDataReader dr = db.query("SELECT FirstName FROM Patient");

            DataTable patients = new DataTable("Patients");
            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "PatientName";
            column.Caption = "PatientName";
            patients.Columns.Add(column);

            DataRow patientRow = patients.NewRow();
            while (dr.Read())
            {
                patientRow = patients.NewRow();
                patientRow["PatientName"] = dr.GetValue(0).ToString();
                patients.Rows.Add(patientRow);
            }

            DataGrid patientDataGrid = new DataGrid();
            patientDataGrid.SetDataBinding(patients, "Patients");
            patientDataGrid.Location = new Point(200, 200);
            patientDataGrid.Size = new Size(300, 300);
            patientDataGrid.CaptionText = "Patient Data";

            dataGridView1.DataSource = patientDataGrid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
