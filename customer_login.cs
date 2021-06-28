using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer_login
{
    public partial class customer_login : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public customer_login()
        {
            InitializeComponent();
            String connectionString = "Server = LAPTOP-TLPH3ASA; Database = 291_proj; Trusted_Connection = yes;";
            /*SqlConnection myConnection = new SqlConnection("user id=group1;" + // Username
                                       "password=group_1;" + // Password
                                       "server=localhost;" + // IP for the server
                                                             //"Trusted_Connection=yes;" +
                                       "database=cmpt291_proj; " + // Database to connect to
                                       "connection timeout=30"); // Timeout in seconds*/
            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select (fName +' '+ LName) from Customer as fullName where (fName +' '+ LName) = '" +
                customer_name.Text + "'";

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "error");
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                if (!myReader.Read())
                {
                    MessageBox.Show("Your Name does not exist in the system, Please sign up as a new Customer");
                    new_customer_login f = new new_customer_login();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    this.Hide();
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }
    }
}
