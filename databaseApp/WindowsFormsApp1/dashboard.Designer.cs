﻿namespace WindowsFormsApp1
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
            this._291ProjectDataSet = new WindowsFormsApp1._291ProjectDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.PatientTableAdapter();
            this.wardTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.WardTableAdapter();
            this.departmentTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.DepartmentTableAdapter();
            this.container1 = new WindowsFormsApp1.container();
            this.doctorView = new WindowsFormsApp1.query_panel();
            this.btnExpandDoctor = new System.Windows.Forms.Button();
            this.lblDoctorViewTitle = new System.Windows.Forms.Label();
            this.dgDoctor = new System.Windows.Forms.DataGridView();
            this.patientView = new WindowsFormsApp1.query_panel();
            this.btnExpandPatient = new System.Windows.Forms.Button();
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
            this.departmentPanel = new WindowsFormsApp1.query_panel();
            this.btnExpandDept = new System.Windows.Forms.Button();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.departmentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardsPanel = new WindowsFormsApp1.query_panel();
            this.btnExpandWard = new System.Windows.Forms.Button();
            this.dgWards = new System.Windows.Forms.DataGridView();
            this.wardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideBar1 = new WindowsFormsApp1.sideBar();
            this.wardDashboardButton = new WindowsFormsApp1.dashboardButton();
            this.departmentDashboardButton = new WindowsFormsApp1.dashboardButton();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoctorView = new WindowsFormsApp1.dashboardButton();
            this.btnPatientView = new WindowsFormsApp1.dashboardButton();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.DoctorTableAdapter();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).BeginInit();
            this.container1.SuspendLayout();
            this.doctorView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).BeginInit();
            this.patientView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.departmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            this.wardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWards)).BeginInit();
            this.sideBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this._291ProjectDataSet;
            // 
            // wardBindingSource
            // 
            this.wardBindingSource.DataMember = "Ward";
            this.wardBindingSource.DataSource = this._291ProjectDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // wardTableAdapter
            // 
            this.wardTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // container1
            // 
            this.container1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.container1.Controls.Add(this.doctorView);
            this.container1.Controls.Add(this.patientView);
            this.container1.Controls.Add(this.departmentPanel);
            this.container1.Controls.Add(this.wardsPanel);
            this.container1.Location = new System.Drawing.Point(219, 0);
            this.container1.Margin = new System.Windows.Forms.Padding(2);
            this.container1.MaximumSize = new System.Drawing.Size(3333, 3250);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(951, 577);
            this.container1.TabIndex = 1;
            // 
            // doctorView
            // 
            this.doctorView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorView.AutoSize = true;
            this.doctorView.Controls.Add(this.btnExpandDoctor);
            this.doctorView.Controls.Add(this.lblDoctorViewTitle);
            this.doctorView.Controls.Add(this.dgDoctor);
            this.doctorView.Location = new System.Drawing.Point(2, 0);
            this.doctorView.MaximumSize = new System.Drawing.Size(3333, 3250);
            this.doctorView.MinimumSize = new System.Drawing.Size(854, 468);
            this.doctorView.Name = "doctorView";
            this.doctorView.Size = new System.Drawing.Size(935, 574);
            this.doctorView.TabIndex = 3;
            this.doctorView.Paint += new System.Windows.Forms.PaintEventHandler(this.queryView_Paint);
            // 
            // btnExpandDoctor
            // 
            this.btnExpandDoctor.Location = new System.Drawing.Point(82, 6);
            this.btnExpandDoctor.Name = "btnExpandDoctor";
            this.btnExpandDoctor.Size = new System.Drawing.Size(114, 23);
            this.btnExpandDoctor.TabIndex = 3;
            this.btnExpandDoctor.Text = "Expand Selection";
            this.btnExpandDoctor.UseVisualStyleBackColor = true;
            this.btnExpandDoctor.Click += new System.EventHandler(this.btnExpandDoctor_Click);
            // 
            // lblDoctorViewTitle
            // 
            this.lblDoctorViewTitle.AutoSize = true;
            this.lblDoctorViewTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoctorViewTitle.Location = new System.Drawing.Point(4, 9);
            this.lblDoctorViewTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctorViewTitle.Name = "lblDoctorViewTitle";
            this.lblDoctorViewTitle.Size = new System.Drawing.Size(39, 13);
            this.lblDoctorViewTitle.TabIndex = 2;
            this.lblDoctorViewTitle.Text = "Doctor";
            this.lblDoctorViewTitle.Visible = false;
            // 
            // dgDoctor
            // 
            this.dgDoctor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgDoctor.AutoGenerateColumns = false;
            this.dgDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDoctor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.dutyDetailsDataGridViewTextBoxColumn});
            this.dgDoctor.DataSource = this.doctorBindingSource;
            this.dgDoctor.Location = new System.Drawing.Point(0, 33);
            this.dgDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.dgDoctor.Name = "dgDoctor";
            this.dgDoctor.ReadOnly = true;
            this.dgDoctor.RowTemplate.Height = 28;
            this.dgDoctor.Size = new System.Drawing.Size(933, 539);
            this.dgDoctor.TabIndex = 1;
            this.dgDoctor.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDoctor_CellClick);
            // 
            // patientView
            // 
            this.patientView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientView.AutoSize = true;
            this.patientView.Controls.Add(this.btnExpandPatient);
            this.patientView.Controls.Add(this.lblPatientViewTitle);
            this.patientView.Controls.Add(this.dgPatient);
            this.patientView.Location = new System.Drawing.Point(3, 2);
            this.patientView.MaximumSize = new System.Drawing.Size(3333, 3250);
            this.patientView.MinimumSize = new System.Drawing.Size(854, 468);
            this.patientView.Name = "patientView";
            this.patientView.Size = new System.Drawing.Size(935, 571);
            this.patientView.TabIndex = 4;
            // 
            // btnExpandPatient
            // 
            this.btnExpandPatient.Location = new System.Drawing.Point(81, 4);
            this.btnExpandPatient.Name = "btnExpandPatient";
            this.btnExpandPatient.Size = new System.Drawing.Size(114, 23);
            this.btnExpandPatient.TabIndex = 4;
            this.btnExpandPatient.Text = "Expand Selection";
            this.btnExpandPatient.UseVisualStyleBackColor = true;
            this.btnExpandPatient.Click += new System.EventHandler(this.btnExpandPatient_Click);
            // 
            // lblPatientViewTitle
            // 
            this.lblPatientViewTitle.AutoSize = true;
            this.lblPatientViewTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPatientViewTitle.Location = new System.Drawing.Point(2, 8);
            this.lblPatientViewTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientViewTitle.Name = "lblPatientViewTitle";
            this.lblPatientViewTitle.Size = new System.Drawing.Size(40, 13);
            this.lblPatientViewTitle.TabIndex = 3;
            this.lblPatientViewTitle.Text = "Patient";
            this.lblPatientViewTitle.Visible = false;
            // 
            // dgPatient
            // 
            this.dgPatient.AutoGenerateColumns = false;
            this.dgPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dgPatient.Location = new System.Drawing.Point(0, 32);
            this.dgPatient.Margin = new System.Windows.Forms.Padding(2);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.ReadOnly = true;
            this.dgPatient.RowTemplate.Height = 28;
            this.dgPatient.Size = new System.Drawing.Size(933, 537);
            this.dgPatient.TabIndex = 0;
            this.dgPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPatient_CellClick);
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
            // departmentPanel
            // 
            this.departmentPanel.Controls.Add(this.btnExpandDept);
            this.departmentPanel.Controls.Add(this.dgDepartment);
            this.departmentPanel.Location = new System.Drawing.Point(0, 0);
            this.departmentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.departmentPanel.Name = "departmentPanel";
            this.departmentPanel.Size = new System.Drawing.Size(935, 571);
            this.departmentPanel.TabIndex = 3;
            // 
            // btnExpandDept
            // 
            this.btnExpandDept.Location = new System.Drawing.Point(84, 6);
            this.btnExpandDept.Name = "btnExpandDept";
            this.btnExpandDept.Size = new System.Drawing.Size(114, 23);
            this.btnExpandDept.TabIndex = 5;
            this.btnExpandDept.Text = "Expand Selection";
            this.btnExpandDept.UseVisualStyleBackColor = true;
            this.btnExpandDept.Click += new System.EventHandler(this.btnExpandDept_Click);
            // 
            // dgDepartment
            // 
            this.dgDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgDepartment.AutoGenerateColumns = false;
            this.dgDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepartment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dgDepartment.DataSource = this.departmentBindingSource;
            this.dgDepartment.Location = new System.Drawing.Point(0, 34);
            this.dgDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.dgDepartment.MaximumSize = new System.Drawing.Size(933, 537);
            this.dgDepartment.MinimumSize = new System.Drawing.Size(900, 488);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.RowTemplate.Height = 24;
            this.dgDepartment.Size = new System.Drawing.Size(933, 537);
            this.dgDepartment.TabIndex = 0;
            this.dgDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartment_CellClick);
            // 
            // departmentIDDataGridViewTextBoxColumn1
            // 
            this.departmentIDDataGridViewTextBoxColumn1.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn1.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn1.Name = "departmentIDDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // wardsPanel
            // 
            this.wardsPanel.Controls.Add(this.btnExpandWard);
            this.wardsPanel.Controls.Add(this.dgWards);
            this.wardsPanel.Location = new System.Drawing.Point(2, 0);
            this.wardsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.wardsPanel.Name = "wardsPanel";
            this.wardsPanel.Size = new System.Drawing.Size(935, 574);
            this.wardsPanel.TabIndex = 3;
            // 
            // btnExpandWard
            // 
            this.btnExpandWard.Location = new System.Drawing.Point(82, 6);
            this.btnExpandWard.Name = "btnExpandWard";
            this.btnExpandWard.Size = new System.Drawing.Size(114, 23);
            this.btnExpandWard.TabIndex = 6;
            this.btnExpandWard.Text = "Expand Selection";
            this.btnExpandWard.UseVisualStyleBackColor = true;
            this.btnExpandWard.Click += new System.EventHandler(this.btnExpandWard_Click);
            // 
            // dgWards
            // 
            this.dgWards.AutoGenerateColumns = false;
            this.dgWards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgWards.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgWards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wardIDDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgWards.DataSource = this.wardBindingSource;
            this.dgWards.Location = new System.Drawing.Point(0, 32);
            this.dgWards.Margin = new System.Windows.Forms.Padding(2);
            this.dgWards.Name = "dgWards";
            this.dgWards.RowTemplate.Height = 24;
            this.dgWards.Size = new System.Drawing.Size(933, 539);
            this.dgWards.TabIndex = 0;
            this.dgWards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWards_CellClick);
            // 
            // wardIDDataGridViewTextBoxColumn
            // 
            this.wardIDDataGridViewTextBoxColumn.DataPropertyName = "WardID";
            this.wardIDDataGridViewTextBoxColumn.HeaderText = "WardID";
            this.wardIDDataGridViewTextBoxColumn.Name = "wardIDDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "TypeID";
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // sideBar1
            // 
            this.sideBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sideBar1.AutoSize = true;
            this.sideBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sideBar1.Controls.Add(this.wardDashboardButton);
            this.sideBar1.Controls.Add(this.departmentDashboardButton);
            this.sideBar1.Controls.Add(this.backButton);
            this.sideBar1.Controls.Add(this.label1);
            this.sideBar1.Controls.Add(this.btnDoctorView);
            this.sideBar1.Controls.Add(this.btnPatientView);
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.MaximumSize = new System.Drawing.Size(217, 936);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(217, 562);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar1_Paint);
            // 
            // wardDashboardButton
            // 
            this.wardDashboardButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.wardDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.wardDashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.wardDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wardDashboardButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.wardDashboardButton.Location = new System.Drawing.Point(2, 283);
            this.wardDashboardButton.Margin = new System.Windows.Forms.Padding(2);
            this.wardDashboardButton.Name = "wardDashboardButton";
            this.wardDashboardButton.Size = new System.Drawing.Size(212, 69);
            this.wardDashboardButton.TabIndex = 4;
            this.wardDashboardButton.Text = "Wards";
            this.wardDashboardButton.UseVisualStyleBackColor = false;
            this.wardDashboardButton.Click += new System.EventHandler(this.wardDashboardButton_Click);
            // 
            // departmentDashboardButton
            // 
            this.departmentDashboardButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.departmentDashboardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.departmentDashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.departmentDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentDashboardButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.departmentDashboardButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.departmentDashboardButton.Location = new System.Drawing.Point(2, 209);
            this.departmentDashboardButton.Margin = new System.Windows.Forms.Padding(2);
            this.departmentDashboardButton.Name = "departmentDashboardButton";
            this.departmentDashboardButton.Size = new System.Drawing.Size(212, 69);
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
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
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
            this.btnDoctorView.Location = new System.Drawing.Point(2, 59);
            this.btnDoctorView.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btnDoctorView.Name = "btnDoctorView";
            this.btnDoctorView.Size = new System.Drawing.Size(212, 69);
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
            this.btnPatientView.Location = new System.Drawing.Point(2, 134);
            this.btnPatientView.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.btnPatientView.Name = "btnPatientView";
            this.btnPatientView.Size = new System.Drawing.Size(212, 69);
            this.btnPatientView.TabIndex = 2;
            this.btnPatientView.Text = "Patients";
            this.btnPatientView.UseVisualStyleBackColor = false;
            this.btnPatientView.Click += new System.EventHandler(this.dashboardButton2_Click);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this._291ProjectDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Department Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dutyDetailsDataGridViewTextBoxColumn
            // 
            this.dutyDetailsDataGridViewTextBoxColumn.DataPropertyName = "DutyDetails";
            this.dutyDetailsDataGridViewTextBoxColumn.HeaderText = "DutyDetails";
            this.dutyDetailsDataGridViewTextBoxColumn.Name = "dutyDetailsDataGridViewTextBoxColumn";
            this.dutyDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1157, 570);
            this.Controls.Add(this.container1);
            this.Controls.Add(this.sideBar1);
            this.Name = "dashboard";
            this.Text = "Hospital Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).EndInit();
            this.container1.ResumeLayout(false);
            this.container1.PerformLayout();
            this.doctorView.ResumeLayout(false);
            this.doctorView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).EndInit();
            this.patientView.ResumeLayout(false);
            this.patientView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.departmentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            this.wardsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWards)).EndInit();
            this.sideBar1.ResumeLayout(false);
            this.sideBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
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
        private query_panel patientView;
        private System.Windows.Forms.DataGridView dgPatient;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private _291ProjectDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridView dgDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private container container1;
        private System.Windows.Forms.Label lblPatientViewTitle;
        private dashboardButton departmentDashboardButton;
        private query_panel departmentPanel;
        private System.Windows.Forms.DataGridView dgDepartment;
        private dashboardButton wardDashboardButton;
        private query_panel wardsPanel;
        private System.Windows.Forms.DataGridView dgWards;
        private System.Windows.Forms.Label lblDoctorViewTitle;
        private System.Windows.Forms.BindingSource wardBindingSource;
        private _291ProjectDataSetTableAdapters.WardTableAdapter wardTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private _291ProjectDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnExpandDoctor;
        private System.Windows.Forms.Button btnExpandPatient;
        private System.Windows.Forms.Button btnExpandDept;
        private System.Windows.Forms.Button btnExpandWard;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private _291ProjectDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyDetailsDataGridViewTextBoxColumn;
    }
}

