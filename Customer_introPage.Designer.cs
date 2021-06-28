
namespace _291_Project
{
    partial class Customer_introPage
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
            this.newCustomers_btn = new System.Windows.Forms.Button();
            this.existantCustomers_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCustomers_btn
            // 
            this.newCustomers_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newCustomers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCustomers_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newCustomers_btn.Location = new System.Drawing.Point(462, 458);
            this.newCustomers_btn.Name = "newCustomers_btn";
            this.newCustomers_btn.Size = new System.Drawing.Size(267, 147);
            this.newCustomers_btn.TabIndex = 5;
            this.newCustomers_btn.Text = "NEW CUSTOMERS";
            this.newCustomers_btn.UseVisualStyleBackColor = false;
            // 
            // existantCustomers_btn
            // 
            this.existantCustomers_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.existantCustomers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.existantCustomers_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.existantCustomers_btn.Location = new System.Drawing.Point(462, 209);
            this.existantCustomers_btn.Name = "existantCustomers_btn";
            this.existantCustomers_btn.Size = new System.Drawing.Size(267, 147);
            this.existantCustomers_btn.TabIndex = 4;
            this.existantCustomers_btn.Text = "EXISTANT CUSTOMERS";
            this.existantCustomers_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(329, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Canada Plus Car Rentals";
            // 
            // Customer_introPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1152, 681);
            this.Controls.Add(this.newCustomers_btn);
            this.Controls.Add(this.existantCustomers_btn);
            this.Controls.Add(this.label1);
            this.Name = "Customer_introPage";
            this.Text = "Customer_introPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newCustomers_btn;
        private System.Windows.Forms.Button existantCustomers_btn;
        private System.Windows.Forms.Label label1;
    }
}