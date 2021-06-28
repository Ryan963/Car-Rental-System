using Customer_login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class Customer_introPage : Form
    {
        public Customer_introPage()
        {
            InitializeComponent();
        }
        private void existantCustomers_btn_Click(object sender, EventArgs e)
        {
            customer_login f = new customer_login();
            f.Show();
            this.Hide();

        }

        private void newCustomers_btn_Click(object sender, EventArgs e)
        {
            new_customer_login f = new new_customer_login();
            f.Show();
            this.Hide();

        }
    }
}
