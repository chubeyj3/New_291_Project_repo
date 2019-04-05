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
    public partial class SubQueryForm : Form
    {
        public SubQueryForm(string init_title, BindingSource init_bind)
        {
            InitializeComponent();
            this.Text = init_title;
            lblTitle.Text = init_title;
            lblTitle.Refresh();

            DataGridView dgv = new DataGridView();
            dgv.DataSource = init_bind;
            dgv.Refresh();
            query_panel1.Controls.Add(dgv);

        }

        private void query_panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
