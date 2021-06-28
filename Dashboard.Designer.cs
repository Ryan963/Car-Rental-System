
namespace _291_Project
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameLblDash = new System.Windows.Forms.Label();
            this.logoutDash_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeReports_button = new System.Windows.Forms.Button();
            this.requestDash_button = new System.Windows.Forms.Button();
            this.updateEmpReports_button = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.dashLblTitle = new System.Windows.Forms.Label();
            this.closefrm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.logoutDash_button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.EmployeeReports_button);
            this.panel1.Controls.Add(this.requestDash_button);
            this.panel1.Controls.Add(this.updateEmpReports_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 768);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.userNameLblDash);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 214);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_291_Project.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(75, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID#";
            // 
            // userNameLblDash
            // 
            this.userNameLblDash.AutoSize = true;
            this.userNameLblDash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLblDash.Location = new System.Drawing.Point(57, 172);
            this.userNameLblDash.Name = "userNameLblDash";
            this.userNameLblDash.Size = new System.Drawing.Size(65, 15);
            this.userNameLblDash.TabIndex = 1;
            this.userNameLblDash.Text = "User Name";
            this.userNameLblDash.Click += new System.EventHandler(this.userNameLblDash_Click);
            // 
            // logoutDash_button
            // 
            this.logoutDash_button.Location = new System.Drawing.Point(12, 717);
            this.logoutDash_button.Name = "logoutDash_button";
            this.logoutDash_button.Size = new System.Drawing.Size(171, 39);
            this.logoutDash_button.TabIndex = 5;
            this.logoutDash_button.Text = "Logout";
            this.logoutDash_button.UseVisualStyleBackColor = true;
            this.logoutDash_button.Click += new System.EventHandler(this.logoutDash_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmployeeReports_button
            // 
            this.EmployeeReports_button.Location = new System.Drawing.Point(12, 505);
            this.EmployeeReports_button.Name = "EmployeeReports_button";
            this.EmployeeReports_button.Size = new System.Drawing.Size(171, 39);
            this.EmployeeReports_button.TabIndex = 3;
            this.EmployeeReports_button.Text = "Employee Reports";
            this.EmployeeReports_button.UseVisualStyleBackColor = true;
            this.EmployeeReports_button.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // requestDash_button
            // 
            this.requestDash_button.Location = new System.Drawing.Point(12, 415);
            this.requestDash_button.Name = "requestDash_button";
            this.requestDash_button.Size = new System.Drawing.Size(171, 39);
            this.requestDash_button.TabIndex = 2;
            this.requestDash_button.Text = "Emp_Bookings";
            this.requestDash_button.UseVisualStyleBackColor = true;
            this.requestDash_button.Click += new System.EventHandler(this.requestDash_button_Click);
            // 
            // updateEmpReports_button
            // 
            this.updateEmpReports_button.Location = new System.Drawing.Point(12, 460);
            this.updateEmpReports_button.Name = "updateEmpReports_button";
            this.updateEmpReports_button.Size = new System.Drawing.Size(171, 39);
            this.updateEmpReports_button.TabIndex = 2;
            this.updateEmpReports_button.Text = "Employee Updates";
            this.updateEmpReports_button.UseVisualStyleBackColor = true;
            this.updateEmpReports_button.Click += new System.EventHandler(this.updateDeleteDash_button_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.Silver;
            this.PnlFormLoader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlFormLoader.Location = new System.Drawing.Point(208, 109);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1140, 647);
            this.PnlFormLoader.TabIndex = 15;
            // 
            // dashLblTitle
            // 
            this.dashLblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashLblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashLblTitle.Location = new System.Drawing.Point(0, 0);
            this.dashLblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.dashLblTitle.Name = "dashLblTitle";
            this.dashLblTitle.Size = new System.Drawing.Size(1360, 106);
            this.dashLblTitle.TabIndex = 18;
            this.dashLblTitle.Text = "Dashboard";
            this.dashLblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closefrm
            // 
            this.closefrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closefrm.FlatAppearance.BorderSize = 0;
            this.closefrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closefrm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closefrm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closefrm.Location = new System.Drawing.Point(1316, 12);
            this.closefrm.Name = "closefrm";
            this.closefrm.Size = new System.Drawing.Size(32, 32);
            this.closefrm.TabIndex = 19;
            this.closefrm.Text = "X";
            this.closefrm.UseVisualStyleBackColor = true;
            this.closefrm.Click += new System.EventHandler(this.closefrm_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.closefrm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.dashLblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EmployeeReports_button;
        private System.Windows.Forms.Button updateEmpReports_button;
        private System.Windows.Forms.Button requestDash_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userNameLblDash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dashLblTitle;
        private System.Windows.Forms.Button logoutDash_button;
        private System.Windows.Forms.Button closefrm;
    }
}

