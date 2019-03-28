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
            this.homePage = new System.Windows.Forms.Panel();
            this.sideBar1 = new WindowsFormsApp1.sideBar();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardButton1 = new WindowsFormsApp1.dashboardButton();
            this.dashboardButton2 = new WindowsFormsApp1.dashboardButton();
            this.queryView = new WindowsFormsApp1.query_panel();
            this.container1 = new WindowsFormsApp1.container();
            this.homePage.SuspendLayout();
            this.sideBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.homePage.Controls.Add(this.queryView);
            this.homePage.Location = new System.Drawing.Point(212, 0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(952, 571);
            this.homePage.TabIndex = 1;
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
            // queryView
            // 
            this.queryView.Location = new System.Drawing.Point(3, 0);
            this.queryView.Name = "queryView";
            this.queryView.Size = new System.Drawing.Size(949, 574);
            this.queryView.TabIndex = 3;
            // 
            // container1
            // 
            this.container1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.container1.Location = new System.Drawing.Point(223, 12);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(922, 547);
            this.container1.TabIndex = 0;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1157, 571);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.container1);
            this.Name = "dashboard";
            this.Text = "Hospital Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.homePage.ResumeLayout(false);
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
    }
}

