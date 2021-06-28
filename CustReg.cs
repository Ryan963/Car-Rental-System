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
    public partial class CustReg : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public CustReg()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes;";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand("select Vin,make,model,year,color from car", myConnection);
            myReader = myCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (myReader.Read())
            {
                dataGridView1.Rows.Add(myReader["VIN"].ToString(), myReader["Make"].ToString(), myReader["Model"].ToString(),
                    myReader["Year"].ToString(), myReader["Color"].ToString());


            }
            myReader.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyyMMdd";
            dateTimePicker1.CustomFormat = "yyyyMMdd";
            cmd.CommandText = "insert into Rental values ('" + textBox4.Text +
                             "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + "20010908" + "','" + textBox3.Text + "','" + "12" + "','" + textBox4.Text + "'" +
                             ",'" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + "40" + "','" + "0" + "')";
            cmd.Connection = sqlConnection1;
            MessageBox.Show(dateTimePicker1.Text.ToString(), "Error");
            
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
