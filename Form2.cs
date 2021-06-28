using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _291_Project
{
    public partial class Form2 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Form2()
        {
            InitializeComponent();
            String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes;";


            /* Starting the connection */
            SqlConnection myConnection = new SqlConnection("user id=Juanacon;" + // Username
                                        "password=Tails1;" + // Password
                                        "server=localhost;" + // IP for the server
                                                              //"Trusted_Connection=yes;" +
                                        "database= cmpt291-proj; " + // Database to connect to
                                        "connection timeout=30"); // Timeout in seconds */

            myConnection = new SqlConnection(connectionString); // Timeout in seconds

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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
      new System.Data.SqlClient.SqlConnection("user id=Juanacon;" + // Username
                                   "password=Tails1;" + // Password
                                   "server=localhost;" + // IP for the server
                                                         //"Trusted_Connection=yes;" +
                                   "database= cmpt291-proj; " + // Database to connect to
                                   "connection timeout=30"); // Timeout in seconds */
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Employee values ('" + ID.Text +
                             "','" + Fname.Text + "','" + Lname.Text + "','" + Sname.Text + "','" + Snum.Text + "','" + Aptnum.Text + "'" +
                             ",'" + City.Text + "','" + Zip.Text + "','" + Prov.Text + "','" + Count.Text + "','" + Cnum.Text + "','" + Onum.Text + "','" + DOB.Text + "','" + Branch.Text + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void Count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
