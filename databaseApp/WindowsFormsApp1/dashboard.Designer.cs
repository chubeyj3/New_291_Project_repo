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
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._291ProjectDataSet = new WindowsFormsApp1._291ProjectDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.DoctorTableAdapter();
            this.patientTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.PatientTableAdapter();
            this.container1 = new WindowsFormsApp1.container();
            this.doctorView = new WindowsFormsApp1.query_panel();
            this.departmentPanel = new WindowsFormsApp1.query_panel();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.lblDoctorViewTitle = new System.Windows.Forms.Label();
            this.dgDoctor = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientView = new WindowsFormsApp1.query_panel();
            this.lblPatientViewTitle = new System.Windows.Forms.Label();
            this.dgPatient = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideBar1 = new WindowsFormsApp1.sideBar();
            this.departmentDashboardButton = new WindowsFormsApp1.dashboardButton();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoctorView = new WindowsFormsApp1.dashboardButton();
            this.btnPatientView = new WindowsFormsApp1.dashboardButton();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.container1.SuspendLayout();
            this.doctorView.SuspendLayout();
            this.departmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).BeginInit();
            this.patientView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.sideBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this._291ProjectDataSet;
            // 
            // _291ProjectDataSet
            // 
            this._291ProjectDataSet.DataSetName = "_291ProjectDataSet";
            this._291ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this._291ProjectDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // container1
            // 
            this.container1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.container1.Controls.Add(this.doctorView);
            this.container1.Controls.Add(this.patientView);
            this.container1.Controls.Add(this.departmentPanel);
            this.container1.Location = new System.Drawing.Point(292, 0);
            this.container1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.container1.MaximumSize = new System.Drawing.Size(4444, 4000);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(1268, 710);
            this.container1.TabIndex = 1;
            // 
            // doctorView
            // 
            this.doctorView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorView.AutoSize = true;
            this.doctorView.Controls.Add(this.lblDoctorViewTitle);
            this.doctorView.Controls.Add(this.dgDoctor);
            this.doctorView.Location = new System.Drawing.Point(2, 0);
            this.doctorView.Margin = new System.Windows.Forms.Padding(4);
            this.doctorView.MaximumSize = new System.Drawing.Size(4444, 4000);
            this.doctorView.MinimumSize = new System.Drawing.Size(1138, 576);
            this.doctorView.Name = "doctorView";
            this.doctorView.Size = new System.Drawing.Size(1247, 706);
            this.doctorView.TabIndex = 3;
            this.doctorView.Paint += new System.Windows.Forms.PaintEventHandler(this.queryView_Paint);
            // 
            // departmentPanel
            // 
            this.departmentPanel.Controls.Add(this.dgDepartment);
            this.departmentPanel.Location = new System.Drawing.Point(0, 0);
            this.departmentPanel.Name = "departmentPanel";
            this.departmentPanel.Size = new System.Drawing.Size(844, 441);
            this.departmentPanel.TabIndex = 3;
            // 
            // dgDepartment
            // 
            this.dgDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartment.Location = new System.Drawing.Point(0, 39);
            this.dgDepartment.MaximumSize = new System.Drawing.Size(1244, 661);
            this.dgDepartment.MinimumSize = new System.Drawing.Size(1200, 600);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.RowTemplate.Height = 24;
            this.dgDepartment.Size = new System.Drawing.Size(1244, 661);
            this.dgDepartment.TabIndex = 0;
            // 
            // lblDoctorViewTitle
            // 
            this.lblDoctorViewTitle.AutoSize = true;
            this.lblDoctorViewTitle.Location = new System.Drawing.Point(5, 11);
            this.lblDoctorViewTitle.Name = "lblDoctorViewTitle";
            this.lblDoctorViewTitle.Size = new System.Drawing.Size(46, 17);
            this.lblDoctorViewTitle.TabIndex = 2;
            this.lblDoctorViewTitle.Text = "label2";
            // 
            // dgDoctor
            // 
            this.dgDoctor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgDoctor.AutoGenerateColumns = false;
            this.dgDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.dutyDetailsDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgDoctor.DataSource = this.doctorBindingSource;
            this.dgDoctor.Location = new System.Drawing.Point(0, 41);
            this.dgDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDoctor.Name = "dgDoctor";
            this.dgDoctor.ReadOnly = true;
            this.dgDoctor.RowTemplate.Height = 28;
            this.dgDoctor.Size = new System.Drawing.Size(1244, 663);
            this.dgDoctor.TabIndex = 1;
            this.dgDoctor.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDoctor_CellClick);
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dutyDetailsDataGridViewTextBoxColumn
            // 
            this.dutyDetailsDataGridViewTextBoxColumn.DataPropertyName = "DutyDetails";
            this.dutyDetailsDataGridViewTextBoxColumn.HeaderText = "DutyDetails";
            this.dutyDetailsDataGridViewTextBoxColumn.Name = "dutyDetailsDataGridViewTextBoxColumn";
            this.dutyDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientView
            // 
            this.patientView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientView.AutoSize = true;
            this.patientView.Controls.Add(this.lblPatientViewTitle);
            this.patientView.Controls.Add(this.dgPatient);
            this.patientView.Location = new System.Drawing.Point(4, 2);
            this.patientView.Margin = new System.Windows.Forms.Padding(4);
            this.patientView.MaximumSize = new System.Drawing.Size(4444, 4000);
            this.patientView.MinimumSize = new System.Drawing.Size(1138, 576);
            this.patientView.Name = "patientView";
            this.patientView.Size = new System.Drawing.Size(1247, 702);
            this.patientView.TabIndex = 4;
            // 
            // lblPatientViewTitle
            // 
            this.lblPatientViewTitle.AutoSize = true;
            this.lblPatientViewTitle.Location = new System.Drawing.Point(3, 10);
            this.lblPatientViewTitle.Name = "lblPatientViewTitle";
            this.lblPatientViewTitle.Size = new System.Drawing.Size(46, 17);
            this.lblPatientViewTitle.TabIndex = 3;
            this.lblPatientViewTitle.Text = "label2";
            // 
            // dgPatient
            // 
            this.dgPatient.AutoGenerateColumns = false;
            this.dgPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn});
            this.dgPatient.DataSource = this.patientBindingSource;
            this.dgPatient.Location = new System.Drawing.Point(0, 39);
            this.dgPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.ReadOnly = true;
            this.dgPatient.RowTemplate.Height = 28;
            this.dgPatient.Size = new System.Drawing.Size(1244, 661);
            this.dgPatient.TabIndex = 0;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sideBar1
            // 
            this.sideBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sideBar1.AutoSize = true;
            this.sideBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sideBar1.Controls.Add(this.departmentDashboardButton);
            this.sideBar1.Controls.Add(this.backButton);
            this.sideBar1.Controls.Add(this.label1);
            this.sideBar1.Controls.Add(this.btnDoctorView);
            this.sideBar1.Controls.Add(this.btnPatientView);
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar1.MaximumSize = new System.Drawing.Size(289, 1152);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(289, 692);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar1_Paint);
            // 
            // departmentDashboardButton
            // 
            this.departmentDashboardButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.departmentDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.departmentDashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.departmentDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentDashboardButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.departmentDashboardButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.departmentDashboardButton.Location = new System.Drawing.Point(3, 257);
            this.departmentDashboardButton.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.departmentDashboardButton.Name = "departmentDashboardButton";
            this.departmentDashboardButton.Size = new System.Drawing.Size(283, 85);
            this.departmentDashboardButton.TabIndex = 3;
            this.departmentDashboardButton.Text = "Department";
            this.departmentDashboardButton.UseVisualStyleBackColor = false;
            this.departmentDashboardButton.Click += new System.EventHandler(this.departmentDashboardButton_Click);
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
            this.backButton.Location = new System.Drawing.Point(219, 660);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 28);
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
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highland Medical";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDoctorView
            // 
            this.btnDoctorView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDoctorView.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnDoctorView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoctorView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorView.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDoctorView.Location = new System.Drawing.Point(3, 73);
            this.btnDoctorView.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.btnDoctorView.Name = "btnDoctorView";
            this.btnDoctorView.Size = new System.Drawing.Size(283, 85);
            this.btnDoctorView.TabIndex = 1;
            this.btnDoctorView.Text = "Doctors";
            this.btnDoctorView.UseVisualStyleBackColor = false;
            this.btnDoctorView.Click += new System.EventHandler(this.dashboardButton1_Click);
            // 
            // btnPatientView
            // 
            this.btnPatientView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPatientView.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnPatientView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatientView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientView.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPatientView.Location = new System.Drawing.Point(3, 165);
            this.btnPatientView.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.btnPatientView.Name = "btnPatientView";
            this.btnPatientView.Size = new System.Drawing.Size(283, 85);
            this.btnPatientView.TabIndex = 2;
            this.btnPatientView.Text = "Patients";
            this.btnPatientView.UseVisualStyleBackColor = false;
            this.btnPatientView.Click += new System.EventHandler(this.dashboardButton2_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1543, 702);
            this.Controls.Add(this.container1);
            this.Controls.Add(this.sideBar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dashboard";
            this.Text = "Hospital Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.container1.ResumeLayout(false);
            this.container1.PerformLayout();
            this.doctorView.ResumeLayout(false);
            this.doctorView.PerformLayout();
            this.departmentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).EndInit();
            this.patientView.ResumeLayout(false);
            this.patientView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.sideBar1.ResumeLayout(false);
            this.sideBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private sideBar sideBar1;
        private dashboardButton btnDoctorView;
        private dashboardButton btnPatientView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private query_panel doctorView;
        private _291ProjectDataSet _291ProjectDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private _291ProjectDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private query_panel patientView;
        private System.Windows.Forms.DataGridView dgPatient;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private _291ProjectDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridView dgDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private container container1;
        private System.Windows.Forms.Label lblDoctorViewTitle;
        private System.Windows.Forms.Label lblPatientViewTitle;
        private dashboardButton departmentDashboardButton;
        private query_panel departmentPanel;
        private System.Windows.Forms.DataGridView dgDepartment;
    }
}

