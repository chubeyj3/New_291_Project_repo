namespace WindowsFormsApp1
{
    partial class SubQueryForm
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
            this.query_panel1 = new WindowsFormsApp1.query_panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // query_panel1
            // 
            this.query_panel1.AutoSize = true;
            this.query_panel1.Location = new System.Drawing.Point(8, 19);
            this.query_panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.query_panel1.Name = "query_panel1";
            this.query_panel1.Size = new System.Drawing.Size(517, 265);
            this.query_panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "TITLE";
            // 
            // SubQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.query_panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SubQueryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SubQueryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private query_panel query_panel1;
        private System.Windows.Forms.Label lblTitle;
    }
}