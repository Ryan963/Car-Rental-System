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
    public partial class Form3 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Form3()
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "delete from Rental where RentalId = ('" + textBox1.Text + "') ";
            MessageBox.Show(myCommand.CommandText);
            myCommand.ExecuteNonQuery();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes;";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand("select * from rental where approved = '0'", myConnection);
            myReader = myCommand.ExecuteReader();
            Rental.Rows.Clear();
            while (myReader.Read())
            {
                Rental.Rows.Add(myReader["RentalID"].ToString(), myReader["Pickup_date"].ToString(), myReader["Return_date"].ToString(),
                    myReader["Actual_date"].ToString(), myReader["price"].ToString(), myReader["approved"].ToString());


            }
            myReader.Close();*/


            String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes;";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string v = "SELECT[RentalID],[fName],[LName],[Pickup_date],[Return_date],[price] FROM [Rental],[Customer] WHERE Rental.CustomerID = Customer.ID and approved = '0'";
            myCommand = new SqlCommand(v, myConnection);
            myReader = myCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (myReader.Read())
            {
                dataGridView1.Rows.Add(myReader["RentalID"].ToString(),myReader["fName"].ToString(), myReader["LName"].ToString(),
                    myReader["Pickup_date"].ToString(), myReader["Return_date"].ToString(), myReader["price"].ToString());


            }
            myReader.Close();






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "update Rental set approved = 1 where RentalId = ('" + textBox1.Text + "') ";
            MessageBox.Show(myCommand.CommandText);

            myCommand.ExecuteNonQuery();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard Db = new Dashboard();
            this.Hide();
            Db.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
