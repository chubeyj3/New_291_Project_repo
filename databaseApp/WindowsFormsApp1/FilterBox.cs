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

    public partial class FilterBox : TextBox
    {
        private string placeholderText;
        private BindingSource source;
        private int column;
        private DataGridView table;

        private string filter;
        public FilterBox(string columnName)
        {
            InitializeComponent();

            Size = new System.Drawing.Size(172, 20);
            ForeColor = Color.Gray;
            placeholderText = "Search by " + columnName + " ...";
            Text = placeholderText;

            this.filter = String.Empty;

        }

        public void setData(BindingSource source, int column, DataGridView table)
        {
            this.source = source;
            this.column = column;
            this.table = table;
        }


        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if(Text == placeholderText)
            {
                Text = "";
                ForeColor = Color.Black;
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if(Text == "" || Text == placeholderText)
            {
                Text = placeholderText;
                ForeColor = Color.Gray;

            }
        }


        public string getFilter()
        {
            if(Text == placeholderText || Text == String.Empty)
            {
                return String.Empty;
            }
            this.filter = this.table.Columns[this.column].HeaderText.ToString() + " LIKE '%" + Text + "%'";
            return this.filter;
        }

    }
}
