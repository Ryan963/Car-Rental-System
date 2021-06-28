/*
namespace _291_Project
{
    partial class Emp_ReportsForm
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
            this.reportLblText = new System.Windows.Forms.Label();
            this.generateReport = new System.Windows.Forms.Button();
            this.reportListbox = new System.Windows.Forms.ListBox();
            this.reportsComboBox = new System.Windows.Forms.ComboBox();
            this.branchNameComboBox = new System.Windows.Forms.ComboBox();
            this.branchNameLbL = new System.Windows.Forms.Label();
            this.availabilityChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportLblText
            // 
            this.reportLblText.AutoSize = true;
            this.reportLblText.Location = new System.Drawing.Point(5, 90);
            this.reportLblText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reportLblText.Name = "reportLblText";
            this.reportLblText.Size = new System.Drawing.Size(75, 25);
            this.reportLblText.TabIndex = 0;
            this.reportLblText.Text = "Reports";
            this.reportLblText.Click += new System.EventHandler(this.label1_Click);
            // 
            // generateReport
            // 
            this.generateReport.BackColor = System.Drawing.Color.Gray;
            this.generateReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateReport.Location = new System.Drawing.Point(5, 533);
            this.generateReport.Margin = new System.Windows.Forms.Padding(5);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(225, 75);
            this.generateReport.TabIndex = 2;
            this.generateReport.Text = "Run Report";
            this.generateReport.UseVisualStyleBackColor = false;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // reportListbox
            // 
            this.reportListbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportListbox.FormattingEnabled = true;
            this.reportListbox.ItemHeight = 25;
            this.reportListbox.Location = new System.Drawing.Point(592, 0);
            this.reportListbox.Margin = new System.Windows.Forms.Padding(5);
            this.reportListbox.Name = "reportListbox";
            this.reportListbox.Size = new System.Drawing.Size(532, 608);
            this.reportListbox.TabIndex = 3;
            this.reportListbox.SelectedIndexChanged += new System.EventHandler(this.peopleFoundListbox_SelectedIndexChanged);
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Customers with 3 or more rentals in a year",
            "Car\'s over due",
            "Rentals approvals pending",
            "Rentals with free upgrades, no membership",
            "Rentals with free upgrades, gold members"});
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Location = new System.Drawing.Point(138, 85);
            this.reportsComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(392, 33);
            this.reportsComboBox.TabIndex = 13;
            this.reportsComboBox.SelectedIndexChanged += new System.EventHandler(this.findComboBox_SelectedIndexChanged);
            // 
            // branchNameComboBox
            // 
            this.branchNameComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Customers with 3 or more rentals in a year",
            "Car\'s over due",
            "Rentals approvals pending",
            "Rentals with free upgrades, no membership",
            "Rentals with free upgrades, gold members"});
            this.branchNameComboBox.FormattingEnabled = true;
            this.branchNameComboBox.Location = new System.Drawing.Point(138, 133);
            this.branchNameComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.branchNameComboBox.Name = "branchNameComboBox";
            this.branchNameComboBox.Size = new System.Drawing.Size(222, 33);
            this.branchNameComboBox.TabIndex = 14;
            this.branchNameComboBox.SelectedIndexChanged += new System.EventHandler(this.branchNameComboBox_SelectedIndexChanged);
            // 
            // branchNameLbL
            // 
            this.branchNameLbL.AutoSize = true;
            this.branchNameLbL.Location = new System.Drawing.Point(5, 138);
            this.branchNameLbL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.branchNameLbL.Name = "branchNameLbL";
            this.branchNameLbL.Size = new System.Drawing.Size(126, 25);
            this.branchNameLbL.TabIndex = 15;
            this.branchNameLbL.Text = "Branch Name";
            this.branchNameLbL.Click += new System.EventHandler(this.branchNameLbL_Click);
            // 
            // availabilityChoiceComboBox
            // 
            this.availabilityChoiceComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Customers with 3 or more rentals in a year",
            "Car\'s over due",
            "Rentals approvals pending",
            "Rentals with free upgrades, no membership",
            "Rentals with free upgrades, gold members"});
            this.availabilityChoiceComboBox.FormattingEnabled = true;
            this.availabilityChoiceComboBox.Location = new System.Drawing.Point(396, 133);
            this.availabilityChoiceComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.availabilityChoiceComboBox.Name = "availabilityChoiceComboBox";
            this.availabilityChoiceComboBox.Size = new System.Drawing.Size(134, 33);
            this.availabilityChoiceComboBox.TabIndex = 16;
            this.availabilityChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.availabilitychoiceComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Gray;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(357, 533);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(225, 75);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Emp_ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1124, 608);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.availabilityChoiceComboBox);
            this.Controls.Add(this.branchNameLbL);
            this.Controls.Add(this.branchNameComboBox);
            this.Controls.Add(this.reportsComboBox);
            this.Controls.Add(this.reportListbox);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.reportLblText);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emp_ReportsForm";
            this.Text = "With";
            this.Load += new System.EventHandler(this.Emp_Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportLblText;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.ListBox reportListbox;
        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.ComboBox branchNameComboBox;
        private System.Windows.Forms.Label branchNameLbL;
        private System.Windows.Forms.ComboBox availabilityChoiceComboBox;
        private System.Windows.Forms.Button clearButton;
    }
}*/