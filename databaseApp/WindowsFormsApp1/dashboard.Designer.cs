namespace WindowsFormsApp1
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.homePage = new System.Windows.Forms.Panel();
            this.queryView = new WindowsFormsApp1.query_panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.doctorView = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorBind = new System.Windows.Forms.BindingSource(this.components);
            this._291ProjectDataSet = new WindowsFormsApp1._291ProjectDataSet();
            this.sideBar1 = new WindowsFormsApp1.sideBar();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardButton1 = new WindowsFormsApp1.dashboardButton();
            this.dashboardButton2 = new WindowsFormsApp1.dashboardButton();
            this.container1 = new WindowsFormsApp1.container();
            this.doctorTableAdapter1 = new WindowsFormsApp1._291ProjectDataSetTableAdapters.DoctorTableAdapter();
            this.queryView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorBind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet)).BeginInit();
            this.sideBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.homePage.Location = new System.Drawing.Point(212, 0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(952, 571);
            this.homePage.TabIndex = 1;
            // 
            // queryView
            // 
            this.queryView.Controls.Add(this.textBox1);
            this.queryView.Controls.Add(this.doctorView);
            this.queryView.Location = new System.Drawing.Point(217, 0);
            this.queryView.Name = "queryView";
            this.queryView.Size = new System.Drawing.Size(949, 574);
            this.queryView.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 20);
            this.textBox1.TabIndex = 1;
            // 
            // doctorView
            // 
            this.doctorView.AutoGenerateColumns = false;
            this.doctorView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.doctorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.dutyDetailsDataGridViewTextBoxColumn});
            this.doctorView.DataSource = this.DoctorBind;
            this.doctorView.Location = new System.Drawing.Point(3, 75);
            this.doctorView.Name = "doctorView";
            this.doctorView.Size = new System.Drawing.Size(925, 493);
            this.doctorView.TabIndex = 0;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // dutyDetailsDataGridViewTextBoxColumn
            // 
            this.dutyDetailsDataGridViewTextBoxColumn.DataPropertyName = "DutyDetails";
            this.dutyDetailsDataGridViewTextBoxColumn.HeaderText = "DutyDetails";
            this.dutyDetailsDataGridViewTextBoxColumn.Name = "dutyDetailsDataGridViewTextBoxColumn";
            // 
            // DoctorBind
            // 
            this.DoctorBind.DataMember = "Doctor";
            this.DoctorBind.DataSource = this._291ProjectDataSet;
            // 
            // _291ProjectDataSet
            // 
            this._291ProjectDataSet.DataSetName = "_291ProjectDataSet";
            this._291ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sideBar1
            // 
            this.sideBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sideBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sideBar1.Controls.Add(this.backButton);
            this.sideBar1.Controls.Add(this.label1);
            this.sideBar1.Controls.Add(this.dashboardButton1);
            this.sideBar1.Controls.Add(this.dashboardButton2);
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(217, 574);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar1_Paint);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.backButton.Location = new System.Drawing.Point(164, 536);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(42, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highland Medical";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dashboardButton1
            // 
            this.dashboardButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dashboardButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.dashboardButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboardButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dashboardButton1.Location = new System.Drawing.Point(2, 59);
            this.dashboardButton1.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.dashboardButton1.Name = "dashboardButton1";
            this.dashboardButton1.Size = new System.Drawing.Size(212, 69);
            this.dashboardButton1.TabIndex = 1;
            this.dashboardButton1.Text = "Custom Query";
            this.dashboardButton1.UseVisualStyleBackColor = false;
            this.dashboardButton1.Click += new System.EventHandler(this.dashboardButton1_Click);
            // 
            // dashboardButton2
            // 
            this.dashboardButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dashboardButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.dashboardButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dashboardButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dashboardButton2.Location = new System.Drawing.Point(2, 134);
            this.dashboardButton2.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.dashboardButton2.Name = "dashboardButton2";
            this.dashboardButton2.Size = new System.Drawing.Size(212, 69);
            this.dashboardButton2.TabIndex = 2;
            this.dashboardButton2.Text = "View 2";
            this.dashboardButton2.UseVisualStyleBackColor = false;
            // 
            // container1
            // 
            this.container1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.container1.Location = new System.Drawing.Point(223, 12);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(922, 547);
            this.container1.TabIndex = 0;
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1157, 571);
            this.Controls.Add(this.queryView);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.container1);
            this.Name = "dashboard";
            this.Text = "Hospital Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.queryView.ResumeLayout(false);
            this.queryView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorBind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet)).EndInit();
            this.sideBar1.ResumeLayout(false);
            this.sideBar1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private sideBar sideBar1;
        private dashboardButton dashboardButton1;
        private dashboardButton dashboardButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel homePage;
        private container container1;
        private query_panel queryView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView doctorView;
        private System.Windows.Forms.BindingSource DoctorBind;
        private _291ProjectDataSet _291ProjectDataSet;
        private _291ProjectDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyDetailsDataGridViewTextBoxColumn;
    }
}

