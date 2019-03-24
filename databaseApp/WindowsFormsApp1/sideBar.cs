using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class sideBar : FlowLayoutPanel
    {
        public sideBar()
        {
            InitializeComponent();

            Dock = DockStyle.Left;
            BackColor = ColorTranslator.FromHtml("#1e2025");
        }

        private void sideBar_Load(object sender, EventArgs e)
        {

        }
    }
}
