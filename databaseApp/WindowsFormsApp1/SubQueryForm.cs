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
    public partial class SubQueryForm : Form
    {
        public SubQueryForm(string init_title, string query)
        {
            InitializeComponent();
            this.Text = init_title;
            lblTitle.Text = init_title;
            lblTitle.Refresh();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default._291ProjectConnectionString);
            SqlCommand comm = new SqlCommand
            {
                Connection = conn,
                CommandType = CommandType.Text,
                CommandText = query
            };

            SqlDataAdapter sda = new SqlDataAdapter(comm);
            DataTable doctorPatients = new DataTable();

            sda.Fill(doctorPatients);

            BindingSource bind = new BindingSource();
            bind.DataSource = doctorPatients;

            DataGridView dgv = new DataGridView();
            dgv.DataSource = bind;
            dgv.Width = query_panel1.Width;
            dgv.Height = query_panel1.Height;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoResizeColumns();

            query_panel1.Controls.Add(dgv);
        }

        private void SubQueryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
