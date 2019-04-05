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
    public partial class dashboardButton : System.Windows.Forms.Button
    {
        public dashboardButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);

            this.BackColor = ColorTranslator.FromHtml("#3b404c");
            this.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#3b404c");
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#d7ece7");
            this.Text = "";
            this.ForeColor = ColorTranslator.FromHtml("#6fbbaa");
            this.Size = new System.Drawing.Size(197, 69);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
        }
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
    
