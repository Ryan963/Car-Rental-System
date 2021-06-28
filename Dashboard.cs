using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateDeleteDash_button_Click(object sender, EventArgs e)
        {
            dashLblTitle.Text = "Employee_update";
            this.PnlFormLoader.Controls.Clear();
            Employee_update empUpdates_Vrb = new Employee_update() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            empUpdates_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(empUpdates_Vrb);
            empUpdates_Vrb.Show();
        }


        private void requestDash_button_Click(object sender, EventArgs e)
        {
            /* Finish Request Form */
            dashLblTitle.Text = "Requests";
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            dashLblTitle.Text = "Employee Reports";
            this.PnlFormLoader.Controls.Clear();
            Emp_ReportsForm empReports_Vrb = new Emp_ReportsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            empReports_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(empReports_Vrb);
            empReports_Vrb.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void closefrm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userNameLblDash_Click(object sender, EventArgs e)
        {
            //Databinding name = "lableusername"
            //lableusername = "emp_name"
        }

        private void logoutDash_button_Click(object sender, EventArgs e)
        {
            /*TODO link with employee login form when its ready */
        }
    }
}
