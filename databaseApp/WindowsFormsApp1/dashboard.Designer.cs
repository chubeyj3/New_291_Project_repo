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
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.PatientTableAdapter();
            this.wardTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.WardTableAdapter();
            this.departmentTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.DepartmentTableAdapter();
            this.doctorTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.DoctorTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsApp1._291ProjectDataSetTableAdapters.UserTableAdapter();
            this.medSystemUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._291ProjectDataSet1 = new WindowsFormsApp1._291ProjectDataSet1();
            this.medSystemUserTableAdapter = new WindowsFormsApp1._291ProjectDataSet1TableAdapters.MedSystemUserTableAdapter();
            this.container1 = new WindowsFormsApp1.container();
            this.usersView = new WindowsFormsApp1.query_panel();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.lblUserViewTitle = new System.Windows.Forms.Label();
            this.doctorView = new WindowsFormsApp1.query_panel();
            this.pnlAddDoctor = new System.Windows.Forms.Panel();
            this.lblDoctorDuties = new System.Windows.Forms.Label();
            this.txbDoctorDuties = new System.Windows.Forms.TextBox();
            this.btnExpandDoctor = new System.Windows.Forms.Button();
            this.btnDoctorSubmit = new System.Windows.Forms.Button();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
            this.lblDoctorDepartmentSelect = new System.Windows.Forms.Label();
            this.txbDoctorFirstName = new System.Windows.Forms.TextBox();
            this.cmbDoctorDepartmentSelect = new System.Windows.Forms.ComboBox();
            this.lblDoctorFirstNameInput = new System.Windows.Forms.Label();
            this.lblDoctorLastNameInput = new System.Windows.Forms.Label();
            this.txbDoctorLastName = new System.Windows.Forms.TextBox();
            this.lblDoctorViewTitle = new System.Windows.Forms.Label();
            this.dgDoctor = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientView = new WindowsFormsApp1.query_panel();
            this.pnlAddPatient = new System.Windows.Forms.Panel();
            this.btnExpandPatient = new System.Windows.Forms.Button();
            this.btnPatientSubmit = new System.Windows.Forms.Button();
            this.btnPatientDelete = new System.Windows.Forms.Button();
            this.txbPatientFirstName = new System.Windows.Forms.TextBox();
            this.lblPatientFirstNameTxb = new System.Windows.Forms.Label();
            this.lblPatientLastNameTxb = new System.Windows.Forms.Label();
            this.txbPatientLastName = new System.Windows.Forms.TextBox();
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
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.lblDepartmentViewTitle = new System.Windows.Forms.Label();
            this.btnExpandDept = new System.Windows.Forms.Button();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.departmentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardsPanel = new WindowsFormsApp1.query_panel();
            this.btnWardDelete = new System.Windows.Forms.Button();
            this.lblWardsViewTitle = new System.Windows.Forms.Label();
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
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medSystemUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet1)).BeginInit();
            this.container1.SuspendLayout();
            this.usersView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.doctorView.SuspendLayout();
            this.pnlAddDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).BeginInit();
            this.patientView.SuspendLayout();
            this.pnlAddPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).BeginInit();
            this.departmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            this.wardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWards)).BeginInit();
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
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this._291ProjectDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // medSystemUserBindingSource
            // 
            this.medSystemUserBindingSource.DataMember = "MedSystemUser";
            this.medSystemUserBindingSource.DataSource = this._291ProjectDataSet1;
            // 
            // _291ProjectDataSet1
            // 
            this._291ProjectDataSet1.DataSetName = "_291ProjectDataSet1";
            this._291ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medSystemUserTableAdapter
            // 
            this.medSystemUserTableAdapter.ClearBeforeFill = true;
            // 
            // container1
            // 
            this.container1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.container1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.container1.Controls.Add(this.usersView);
            this.container1.Controls.Add(this.doctorView);
            this.container1.Controls.Add(this.patientView);
            this.container1.Controls.Add(this.departmentPanel);
            this.container1.Controls.Add(this.wardsPanel);
            this.container1.Location = new System.Drawing.Point(292, 0);
            this.container1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.container1.MaximumSize = new System.Drawing.Size(4444, 4000);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(1268, 710);
            this.container1.TabIndex = 1;
            // 
            // usersView
            // 
            this.usersView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usersView.AutoSize = true;
            this.usersView.Controls.Add(this.dgUsers);
            this.usersView.Controls.Add(this.pnlAddUser);
            this.usersView.Controls.Add(this.lblUserViewTitle);
            this.usersView.Location = new System.Drawing.Point(1, 0);
            this.usersView.Margin = new System.Windows.Forms.Padding(4);
            this.usersView.MaximumSize = new System.Drawing.Size(4444, 4000);
            this.usersView.MinimumSize = new System.Drawing.Size(1139, 576);
            this.usersView.Name = "usersView";
            this.usersView.Size = new System.Drawing.Size(1247, 706);
            this.usersView.TabIndex = 13;
            // 
            // dgUsers
            // 
            this.dgUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgUsers.AutoGenerateColumns = false;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.accessLevelDataGridViewTextBoxColumn});
            this.dgUsers.DataSource = this.medSystemUserBindingSource;
            this.dgUsers.Location = new System.Drawing.Point(0, 73);
            this.dgUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RowTemplate.Height = 24;
            this.dgUsers.Size = new System.Drawing.Size(1244, 359);
            this.dgUsers.TabIndex = 0;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Location = new System.Drawing.Point(0, 438);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1239, 261);
            this.pnlAddUser.TabIndex = 2;
            // 
            // lblUserViewTitle
            // 
            this.lblUserViewTitle.AutoSize = true;
            this.lblUserViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUserViewTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserViewTitle.Location = new System.Drawing.Point(561, 4);
            this.lblUserViewTitle.Name = "lblUserViewTitle";
            this.lblUserViewTitle.Size = new System.Drawing.Size(76, 29);
            this.lblUserViewTitle.TabIndex = 1;
            this.lblUserViewTitle.Text = "Users";
            this.lblUserViewTitle.Visible = false;
            // 
            // doctorView
            // 
            this.doctorView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorView.AutoSize = true;
            this.doctorView.Controls.Add(this.pnlAddDoctor);
            this.doctorView.Controls.Add(this.lblDoctorViewTitle);
            this.doctorView.Controls.Add(this.dgDoctor);
            this.doctorView.Location = new System.Drawing.Point(0, 0);
            this.doctorView.Margin = new System.Windows.Forms.Padding(4);
            this.doctorView.MaximumSize = new System.Drawing.Size(4444, 4000);
            this.doctorView.MinimumSize = new System.Drawing.Size(1139, 576);
            this.doctorView.Name = "doctorView";
            this.doctorView.Size = new System.Drawing.Size(1247, 706);
            this.doctorView.TabIndex = 3;
            this.doctorView.Paint += new System.Windows.Forms.PaintEventHandler(this.queryView_Paint);
            // 
            // pnlAddDoctor
            // 
            this.pnlAddDoctor.Controls.Add(this.lblDoctorDuties);
            this.pnlAddDoctor.Controls.Add(this.txbDoctorDuties);
            this.pnlAddDoctor.Controls.Add(this.btnExpandDoctor);
            this.pnlAddDoctor.Controls.Add(this.btnDoctorSubmit);
            this.pnlAddDoctor.Controls.Add(this.btnDoctorDelete);
            this.pnlAddDoctor.Controls.Add(this.lblDoctorDepartmentSelect);
            this.pnlAddDoctor.Controls.Add(this.txbDoctorFirstName);
            this.pnlAddDoctor.Controls.Add(this.cmbDoctorDepartmentSelect);
            this.pnlAddDoctor.Controls.Add(this.lblDoctorFirstNameInput);
            this.pnlAddDoctor.Controls.Add(this.lblDoctorLastNameInput);
            this.pnlAddDoctor.Controls.Add(this.txbDoctorLastName);
            this.pnlAddDoctor.Location = new System.Drawing.Point(0, 438);
            this.pnlAddDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddDoctor.Name = "pnlAddDoctor";
            this.pnlAddDoctor.Size = new System.Drawing.Size(1239, 261);
            this.pnlAddDoctor.TabIndex = 12;
            // 
            // lblDoctorDuties
            // 
            this.lblDoctorDuties.AutoSize = true;
            this.lblDoctorDuties.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoctorDuties.Location = new System.Drawing.Point(367, 172);
            this.lblDoctorDuties.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorDuties.Name = "lblDoctorDuties";
            this.lblDoctorDuties.Size = new System.Drawing.Size(48, 17);
            this.lblDoctorDuties.TabIndex = 13;
            this.lblDoctorDuties.Text = "Duties";
            // 
            // txbDoctorDuties
            // 
            this.txbDoctorDuties.Location = new System.Drawing.Point(451, 169);
            this.txbDoctorDuties.Margin = new System.Windows.Forms.Padding(4);
            this.txbDoctorDuties.Name = "txbDoctorDuties";
            this.txbDoctorDuties.Size = new System.Drawing.Size(291, 22);
            this.txbDoctorDuties.TabIndex = 12;
            // 
            // btnExpandDoctor
            // 
            this.btnExpandDoctor.Location = new System.Drawing.Point(451, 11);
            this.btnExpandDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandDoctor.Name = "btnExpandDoctor";
            this.btnExpandDoctor.Size = new System.Drawing.Size(152, 28);
            this.btnExpandDoctor.TabIndex = 3;
            this.btnExpandDoctor.Text = "Expand Selection";
            this.btnExpandDoctor.UseVisualStyleBackColor = true;
            this.btnExpandDoctor.Click += new System.EventHandler(this.btnExpandDoctor_Click);
            // 
            // btnDoctorSubmit
            // 
            this.btnDoctorSubmit.Location = new System.Drawing.Point(451, 201);
            this.btnDoctorSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctorSubmit.Name = "btnDoctorSubmit";
            this.btnDoctorSubmit.Size = new System.Drawing.Size(292, 28);
            this.btnDoctorSubmit.TabIndex = 11;
            this.btnDoctorSubmit.Text = "Create New Doctor";
            this.btnDoctorSubmit.UseVisualStyleBackColor = true;
            this.btnDoctorSubmit.Click += new System.EventHandler(this.btnDoctorSubmit_Click);
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.Location = new System.Drawing.Point(611, 11);
            this.btnDoctorDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(132, 28);
            this.btnDoctorDelete.TabIndex = 4;
            this.btnDoctorDelete.Text = "Delete Selected";
            this.btnDoctorDelete.UseVisualStyleBackColor = true;
            // 
            // lblDoctorDepartmentSelect
            // 
            this.lblDoctorDepartmentSelect.AutoSize = true;
            this.lblDoctorDepartmentSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoctorDepartmentSelect.Location = new System.Drawing.Point(365, 138);
            this.lblDoctorDepartmentSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorDepartmentSelect.Name = "lblDoctorDepartmentSelect";
            this.lblDoctorDepartmentSelect.Size = new System.Drawing.Size(82, 17);
            this.lblDoctorDepartmentSelect.TabIndex = 10;
            this.lblDoctorDepartmentSelect.Text = "Department";
            // 
            // txbDoctorFirstName
            // 
            this.txbDoctorFirstName.Location = new System.Drawing.Point(451, 69);
            this.txbDoctorFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txbDoctorFirstName.Name = "txbDoctorFirstName";
            this.txbDoctorFirstName.Size = new System.Drawing.Size(291, 22);
            this.txbDoctorFirstName.TabIndex = 5;
            // 
            // cmbDoctorDepartmentSelect
            // 
            this.cmbDoctorDepartmentSelect.FormattingEnabled = true;
            this.cmbDoctorDepartmentSelect.Location = new System.Drawing.Point(451, 134);
            this.cmbDoctorDepartmentSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDoctorDepartmentSelect.Name = "cmbDoctorDepartmentSelect";
            this.cmbDoctorDepartmentSelect.Size = new System.Drawing.Size(291, 24);
            this.cmbDoctorDepartmentSelect.TabIndex = 9;
            // 
            // lblDoctorFirstNameInput
            // 
            this.lblDoctorFirstNameInput.AutoSize = true;
            this.lblDoctorFirstNameInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoctorFirstNameInput.Location = new System.Drawing.Point(367, 73);
            this.lblDoctorFirstNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorFirstNameInput.Name = "lblDoctorFirstNameInput";
            this.lblDoctorFirstNameInput.Size = new System.Drawing.Size(76, 17);
            this.lblDoctorFirstNameInput.TabIndex = 6;
            this.lblDoctorFirstNameInput.Text = "First Name";
            // 
            // lblDoctorLastNameInput
            // 
            this.lblDoctorLastNameInput.AutoSize = true;
            this.lblDoctorLastNameInput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDoctorLastNameInput.Location = new System.Drawing.Point(367, 105);
            this.lblDoctorLastNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorLastNameInput.Name = "lblDoctorLastNameInput";
            this.lblDoctorLastNameInput.Size = new System.Drawing.Size(76, 17);
            this.lblDoctorLastNameInput.TabIndex = 8;
            this.lblDoctorLastNameInput.Text = "Last Name";
            // 
            // txbDoctorLastName
            // 
            this.txbDoctorLastName.Location = new System.Drawing.Point(451, 101);
            this.txbDoctorLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txbDoctorLastName.Name = "txbDoctorLastName";
            this.txbDoctorLastName.Size = new System.Drawing.Size(291, 22);
            this.txbDoctorLastName.TabIndex = 7;
            // 
            // lblDoctorViewTitle
            // 
            this.lblDoctorViewTitle.AutoSize = true;
            this.lblDoctorViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDoctorViewTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoctorViewTitle.Location = new System.Drawing.Point(561, 4);
            this.lblDoctorViewTitle.Name = "lblDoctorViewTitle";
            this.lblDoctorViewTitle.Size = new System.Drawing.Size(84, 29);
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
            this.dgDoctor.Location = new System.Drawing.Point(0, 73);
            this.dgDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDoctor.Name = "dgDoctor";
            this.dgDoctor.ReadOnly = true;
            this.dgDoctor.RowTemplate.Height = 28;
            this.dgDoctor.Size = new System.Drawing.Size(1244, 359);
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
            // patientView
            // 
            this.patientView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientView.AutoSize = true;
            this.patientView.Controls.Add(this.pnlAddPatient);
            this.patientView.Controls.Add(this.lblPatientViewTitle);
            this.patientView.Controls.Add(this.dgPatient);
            this.patientView.Location = new System.Drawing.Point(4, 2);
            this.patientView.Margin = new System.Windows.Forms.Padding(4);
            this.patientView.MaximumSize = new System.Drawing.Size(4444, 4000);
            this.patientView.MinimumSize = new System.Drawing.Size(1139, 576);
            this.patientView.Name = "patientView";
            this.patientView.Size = new System.Drawing.Size(1247, 703);
            this.patientView.TabIndex = 4;
            // 
            // pnlAddPatient
            // 
            this.pnlAddPatient.Controls.Add(this.btnExpandPatient);
            this.pnlAddPatient.Controls.Add(this.btnPatientSubmit);
            this.pnlAddPatient.Controls.Add(this.btnPatientDelete);
            this.pnlAddPatient.Controls.Add(this.txbPatientFirstName);
            this.pnlAddPatient.Controls.Add(this.lblPatientFirstNameTxb);
            this.pnlAddPatient.Controls.Add(this.lblPatientLastNameTxb);
            this.pnlAddPatient.Controls.Add(this.txbPatientLastName);
            this.pnlAddPatient.Location = new System.Drawing.Point(4, 432);
            this.pnlAddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddPatient.Name = "pnlAddPatient";
            this.pnlAddPatient.Size = new System.Drawing.Size(1239, 261);
            this.pnlAddPatient.TabIndex = 13;
            // 
            // btnExpandPatient
            // 
            this.btnExpandPatient.Location = new System.Drawing.Point(451, 11);
            this.btnExpandPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandPatient.Name = "btnExpandPatient";
            this.btnExpandPatient.Size = new System.Drawing.Size(152, 28);
            this.btnExpandPatient.TabIndex = 4;
            this.btnExpandPatient.Text = "Expand Selection";
            this.btnExpandPatient.UseVisualStyleBackColor = true;
            this.btnExpandPatient.Click += new System.EventHandler(this.btnExpandPatient_Click);
            // 
            // btnPatientSubmit
            // 
            this.btnPatientSubmit.Location = new System.Drawing.Point(451, 169);
            this.btnPatientSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientSubmit.Name = "btnPatientSubmit";
            this.btnPatientSubmit.Size = new System.Drawing.Size(292, 28);
            this.btnPatientSubmit.TabIndex = 11;
            this.btnPatientSubmit.Text = "Create New Doctor";
            this.btnPatientSubmit.UseVisualStyleBackColor = true;
            // 
            // btnPatientDelete
            // 
            this.btnPatientDelete.Location = new System.Drawing.Point(611, 11);
            this.btnPatientDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientDelete.Name = "btnPatientDelete";
            this.btnPatientDelete.Size = new System.Drawing.Size(132, 28);
            this.btnPatientDelete.TabIndex = 4;
            this.btnPatientDelete.Text = "Delete Selected";
            this.btnPatientDelete.UseVisualStyleBackColor = true;
            // 
            // txbPatientFirstName
            // 
            this.txbPatientFirstName.Location = new System.Drawing.Point(451, 69);
            this.txbPatientFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txbPatientFirstName.Name = "txbPatientFirstName";
            this.txbPatientFirstName.Size = new System.Drawing.Size(291, 22);
            this.txbPatientFirstName.TabIndex = 5;
            // 
            // lblPatientFirstNameTxb
            // 
            this.lblPatientFirstNameTxb.AutoSize = true;
            this.lblPatientFirstNameTxb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientFirstNameTxb.Location = new System.Drawing.Point(367, 73);
            this.lblPatientFirstNameTxb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientFirstNameTxb.Name = "lblPatientFirstNameTxb";
            this.lblPatientFirstNameTxb.Size = new System.Drawing.Size(76, 17);
            this.lblPatientFirstNameTxb.TabIndex = 6;
            this.lblPatientFirstNameTxb.Text = "First Name";
            // 
            // lblPatientLastNameTxb
            // 
            this.lblPatientLastNameTxb.AutoSize = true;
            this.lblPatientLastNameTxb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientLastNameTxb.Location = new System.Drawing.Point(367, 105);
            this.lblPatientLastNameTxb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientLastNameTxb.Name = "lblPatientLastNameTxb";
            this.lblPatientLastNameTxb.Size = new System.Drawing.Size(76, 17);
            this.lblPatientLastNameTxb.TabIndex = 8;
            this.lblPatientLastNameTxb.Text = "Last Name";
            // 
            // txbPatientLastName
            // 
            this.txbPatientLastName.Location = new System.Drawing.Point(451, 101);
            this.txbPatientLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txbPatientLastName.Name = "txbPatientLastName";
            this.txbPatientLastName.Size = new System.Drawing.Size(291, 22);
            this.txbPatientLastName.TabIndex = 7;
            // 
            // lblPatientViewTitle
            // 
            this.lblPatientViewTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientViewTitle.AutoSize = true;
            this.lblPatientViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPatientViewTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPatientViewTitle.Location = new System.Drawing.Point(559, 9);
            this.lblPatientViewTitle.Name = "lblPatientViewTitle";
            this.lblPatientViewTitle.Size = new System.Drawing.Size(87, 29);
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
            this.dgPatient.Location = new System.Drawing.Point(0, 70);
            this.dgPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPatient.Name = "dgPatient";
            this.dgPatient.ReadOnly = true;
            this.dgPatient.RowTemplate.Height = 28;
            this.dgPatient.Size = new System.Drawing.Size(1244, 361);
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
            this.departmentPanel.Controls.Add(this.btnDepartmentDelete);
            this.departmentPanel.Controls.Add(this.lblDepartmentViewTitle);
            this.departmentPanel.Controls.Add(this.btnExpandDept);
            this.departmentPanel.Controls.Add(this.dgDepartment);
            this.departmentPanel.Location = new System.Drawing.Point(0, 0);
            this.departmentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentPanel.Name = "departmentPanel";
            this.departmentPanel.Size = new System.Drawing.Size(1247, 703);
            this.departmentPanel.TabIndex = 3;
            // 
            // btnDepartmentDelete
            // 
            this.btnDepartmentDelete.Location = new System.Drawing.Point(633, 438);
            this.btnDepartmentDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartmentDelete.Name = "btnDepartmentDelete";
            this.btnDepartmentDelete.Size = new System.Drawing.Size(132, 28);
            this.btnDepartmentDelete.TabIndex = 7;
            this.btnDepartmentDelete.Text = "Delete Selected";
            this.btnDepartmentDelete.UseVisualStyleBackColor = true;
            // 
            // lblDepartmentViewTitle
            // 
            this.lblDepartmentViewTitle.AutoSize = true;
            this.lblDepartmentViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDepartmentViewTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDepartmentViewTitle.Location = new System.Drawing.Point(563, 11);
            this.lblDepartmentViewTitle.Name = "lblDepartmentViewTitle";
            this.lblDepartmentViewTitle.Size = new System.Drawing.Size(138, 29);
            this.lblDepartmentViewTitle.TabIndex = 6;
            this.lblDepartmentViewTitle.Text = "Department";
            this.lblDepartmentViewTitle.Visible = false;
            // 
            // btnExpandDept
            // 
            this.btnExpandDept.Location = new System.Drawing.Point(12, 438);
            this.btnExpandDept.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandDept.Name = "btnExpandDept";
            this.btnExpandDept.Size = new System.Drawing.Size(152, 28);
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
            this.dgDepartment.Location = new System.Drawing.Point(0, 73);
            this.dgDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDepartment.MaximumSize = new System.Drawing.Size(1244, 661);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.RowTemplate.Height = 24;
            this.dgDepartment.Size = new System.Drawing.Size(1244, 361);
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
            this.wardsPanel.Controls.Add(this.btnWardDelete);
            this.wardsPanel.Controls.Add(this.lblWardsViewTitle);
            this.wardsPanel.Controls.Add(this.btnExpandWard);
            this.wardsPanel.Controls.Add(this.dgWards);
            this.wardsPanel.Location = new System.Drawing.Point(3, 0);
            this.wardsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wardsPanel.Name = "wardsPanel";
            this.wardsPanel.Size = new System.Drawing.Size(1247, 706);
            this.wardsPanel.TabIndex = 3;
            // 
            // btnWardDelete
            // 
            this.btnWardDelete.Location = new System.Drawing.Point(631, 438);
            this.btnWardDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnWardDelete.Name = "btnWardDelete";
            this.btnWardDelete.Size = new System.Drawing.Size(132, 28);
            this.btnWardDelete.TabIndex = 8;
            this.btnWardDelete.Text = "Delete Selected";
            this.btnWardDelete.UseVisualStyleBackColor = true;
            // 
            // lblWardsViewTitle
            // 
            this.lblWardsViewTitle.AutoSize = true;
            this.lblWardsViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWardsViewTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWardsViewTitle.Location = new System.Drawing.Point(560, 11);
            this.lblWardsViewTitle.Name = "lblWardsViewTitle";
            this.lblWardsViewTitle.Size = new System.Drawing.Size(138, 29);
            this.lblWardsViewTitle.TabIndex = 7;
            this.lblWardsViewTitle.Text = "Department";
            this.lblWardsViewTitle.Visible = false;
            // 
            // btnExpandWard
            // 
            this.btnExpandWard.Location = new System.Drawing.Point(109, 7);
            this.btnExpandWard.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpandWard.Name = "btnExpandWard";
            this.btnExpandWard.Size = new System.Drawing.Size(152, 28);
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
            this.dgWards.Location = new System.Drawing.Point(0, 73);
            this.dgWards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgWards.Name = "dgWards";
            this.dgWards.RowTemplate.Height = 24;
            this.dgWards.Size = new System.Drawing.Size(1244, 359);
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
            this.sideBar1.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar1.MaximumSize = new System.Drawing.Size(289, 1152);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(289, 692);
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
            this.wardDashboardButton.Location = new System.Drawing.Point(3, 348);
            this.wardDashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wardDashboardButton.Name = "wardDashboardButton";
            this.wardDashboardButton.Size = new System.Drawing.Size(283, 85);
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
            this.departmentDashboardButton.Location = new System.Drawing.Point(3, 257);
            this.departmentDashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label1.Location = new System.Drawing.Point(13, 11);
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
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accessLevelDataGridViewTextBoxColumn
            // 
            this.accessLevelDataGridViewTextBoxColumn.DataPropertyName = "AccessLevel";
            this.accessLevelDataGridViewTextBoxColumn.HeaderText = "AccessLevel";
            this.accessLevelDataGridViewTextBoxColumn.Name = "accessLevelDataGridViewTextBoxColumn";
            this.accessLevelDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medSystemUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._291ProjectDataSet1)).EndInit();
            this.container1.ResumeLayout(false);
            this.container1.PerformLayout();
            this.usersView.ResumeLayout(false);
            this.usersView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.doctorView.ResumeLayout(false);
            this.doctorView.PerformLayout();
            this.pnlAddDoctor.ResumeLayout(false);
            this.pnlAddDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctor)).EndInit();
            this.patientView.ResumeLayout(false);
            this.patientView.PerformLayout();
            this.pnlAddPatient.ResumeLayout(false);
            this.pnlAddPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatient)).EndInit();
            this.departmentPanel.ResumeLayout(false);
            this.departmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            this.wardsPanel.ResumeLayout(false);
            this.wardsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWards)).EndInit();
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
        private System.Windows.Forms.Label lblDepartmentViewTitle;
        private System.Windows.Forms.Label lblWardsViewTitle;
        private System.Windows.Forms.Button btnDoctorDelete;
        private System.Windows.Forms.Button btnDepartmentDelete;
        private System.Windows.Forms.Button btnWardDelete;
        private System.Windows.Forms.Label lblDoctorFirstNameInput;
        private System.Windows.Forms.TextBox txbDoctorFirstName;
        private System.Windows.Forms.Label lblDoctorLastNameInput;
        private System.Windows.Forms.TextBox txbDoctorLastName;
        private System.Windows.Forms.Button btnDoctorSubmit;
        private System.Windows.Forms.Panel pnlAddDoctor;
        private System.Windows.Forms.Panel pnlAddPatient;
        private System.Windows.Forms.Button btnExpandPatient;
        private System.Windows.Forms.Button btnPatientSubmit;
        private System.Windows.Forms.Button btnPatientDelete;
        private System.Windows.Forms.TextBox txbPatientFirstName;
        private System.Windows.Forms.Label lblPatientFirstNameTxb;
        private System.Windows.Forms.Label lblPatientLastNameTxb;
        private System.Windows.Forms.TextBox txbPatientLastName;
        private System.Windows.Forms.Label lblDoctorDepartmentSelect;
        private System.Windows.Forms.ComboBox cmbDoctorDepartmentSelect;
        private System.Windows.Forms.Label lblDoctorDuties;
        private System.Windows.Forms.TextBox txbDoctorDuties;
        private query_panel usersView;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Label lblUserViewTitle;
        private System.Windows.Forms.BindingSource userBindingSource;
        private _291ProjectDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private _291ProjectDataSet1 _291ProjectDataSet1;
        private System.Windows.Forms.BindingSource medSystemUserBindingSource;
        private _291ProjectDataSet1TableAdapters.MedSystemUserTableAdapter medSystemUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessLevelDataGridViewTextBoxColumn;
    }
}

