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
            this.container1 = new WindowsFormsApp1.container();
            this.homePage = new System.Windows.Forms.Panel();
            this.sideBar1 = new WindowsFormsApp1.sideBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.queryView = new WindowsFormsApp1.query_panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardButton1 = new WindowsFormsApp1.dashboardButton();
            this.dashboardButton2 = new WindowsFormsApp1.dashboardButton();
            this.backButton = new System.Windows.Forms.Button();
            this.container1.SuspendLayout();
            this.sideBar1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container1
            // 
            this.container1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(61)))));
            this.container1.Controls.Add(this.homePage);
            this.container1.Controls.Add(this.sideBar1);
            this.container1.Controls.Add(this.backButton);
            this.container1.Location = new System.Drawing.Point(12, 12);
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(1133, 547);
            this.container1.TabIndex = 0;
            // 
            // homePage
            // 
            this.homePage.BackColor = System.Drawing.Color.Red;
            this.homePage.Location = new System.Drawing.Point(306, 24);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(494, 191);
            this.homePage.TabIndex = 1;
            // 
            // sideBar1
            // 
            this.sideBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.sideBar1.Controls.Add(this.panel1);
            this.sideBar1.Controls.Add(this.dashboardButton1);
            this.sideBar1.Controls.Add(this.dashboardButton2);
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(200, 547);
            this.sideBar1.TabIndex = 0;
            this.sideBar1.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.queryView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // queryView
            // 
            this.queryView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.queryView.Location = new System.Drawing.Point(205, 0);
            this.queryView.Name = "queryView";
            this.queryView.Size = new System.Drawing.Size(925, 547);
            this.queryView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Highland Medical";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dashboardButton1
            // 
            this.dashboardButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.dashboardButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.dashboardButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dashboardButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.dashboardButton1.Location = new System.Drawing.Point(2, 75);
            this.dashboardButton1.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.dashboardButton1.Name = "dashboardButton1";
            this.dashboardButton1.Size = new System.Drawing.Size(197, 69);
            this.dashboardButton1.TabIndex = 1;
            this.dashboardButton1.Text = "Custom Query";
            this.dashboardButton1.UseVisualStyleBackColor = false;
            this.dashboardButton1.Click += new System.EventHandler(this.dashboardButton1_Click);
            // 
            // dashboardButton2
            // 
            this.dashboardButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.dashboardButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(64)))), ((int)(((byte)(76)))));
            this.dashboardButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dashboardButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(187)))), ((int)(((byte)(170)))));
            this.dashboardButton2.Location = new System.Drawing.Point(2, 150);
            this.dashboardButton2.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.dashboardButton2.Name = "dashboardButton2";
            this.dashboardButton2.Size = new System.Drawing.Size(197, 69);
            this.dashboardButton2.TabIndex = 2;
            this.dashboardButton2.Text = "View 2";
            this.dashboardButton2.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(211, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(42, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1157, 571);
            this.Controls.Add(this.container1);
            this.Name = "dashboard";
            this.Text = "Hospital Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.container1.ResumeLayout(false);
            this.sideBar1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private container container1;
        private sideBar sideBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private dashboardButton dashboardButton1;
        private dashboardButton dashboardButton2;
        private System.Windows.Forms.Panel homePage;
        private query_panel queryView;
        private System.Windows.Forms.Button backButton;
    }
}

