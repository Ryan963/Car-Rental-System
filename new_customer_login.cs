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
    public partial class new_customer_login : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public new_customer_login()
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
        private void continue_btn_Click(object sender, EventArgs e)
        {

            if (Fname.Text.Trim() == "" || Lname.Text.Trim() == "" || Cnum.Text.Trim() == "" ||
                Snum.Text.Trim() == "" || Sname.Text.Trim() == "" || Prov.Text.Trim() == "" || Count.Text.Trim() == "" || membership.Text.Trim() == "" || lable.Text.Trim() == ""
                || City.Text.Trim() == "" || Zip.Text.Trim() == "")
            {
                MessageBox.Show("All Fields are required", "Error");
            }
            else
            {
                try
                {
                    Random r = new Random();
                    int randNum = r.Next(1000000);
                    string sixDigitNumber = randNum.ToString("D6");
                    myCommand.CommandText = "insert into customer values (" + sixDigitNumber + ", '"
                                    + Fname.Text + "','" + Lname.Text + "','" + Sname.Text + "','" + Snum.Text + "','" + Aptnum.Text + "'" +
                             ",'" + City.Text + "','" + Zip.Text + "','" + Prov.Text + "','" + Count.Text + "','" + Cnum.Text + "','" + Onum.Text + "','" + membership.Text + "','" + lable.Text + "')";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _291_Project.Customer_introPage f1 = new _291_Project.Customer_introPage();
            this.Hide();
            f1.Show();
        }



    }
}
