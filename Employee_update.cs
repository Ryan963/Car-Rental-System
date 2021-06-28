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
    public partial class Employee_update : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;


        public Employee_update()
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

        private void insert_button_Click(object sender, EventArgs e)
        {
            if (insert_vin.Text.Trim().Length == 0 || insert_Class.Text.Trim().Length == 0 || insert_make.Text.Length == 0 ||
                insert_model.Text.Length == 0 || year.Text.Length == 0 || insert_BranchName.Text == "Branch Name")
            {
                MessageBox.Show("All Fields are required", "Error");
            }
            else
            {
                try
                {

                    myCommand.CommandText = "insert into Car values (" + "'" + insert_vin.Text +
                        "','" + insert_make.Text + "','" + insert_model.Text + "'," + year.Text + ",'" + insert_color.Text + "','" + insert_license_plate.Text
                        + "'," + "(select ID from Branch where Branch.Name = '"+insert_BranchName.Text + "'),'" + insert_Class.Text + "')";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (delete_vin.Text.Length == 0)
            {
                MessageBox.Show("Please Enter the vin of the car to be deleted", "Error");
            }
            else
            {
                try
                {
                    myCommand.CommandText = "Delete from Car where Car.vin = '" + delete_vin.Text + "'";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");

                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (vin_update.Text.Trim() == "")
            {
                MessageBox.Show("You need to Enter the vin Number in order to update a Field");
            }
            else if (branch_id_update.Text == "" && license_plate_update.Text == "")
            {
                MessageBox.Show("Please Enter the new updates to the field you would like to update");
            }
            else if (branch_id_update.Text == "" && license_plate_update.Text != "")
            {
                try
                {
                    myCommand.CommandText = "Update Car Set License_plate = '" + license_plate_update.Text
                        + "' where Car.vin = '" + vin_update.Text + "'";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");

                }
            }
            else if (branch_id_update.Text != "" && license_plate_update.Text == "")
            {
                try
                {
                    myCommand.CommandText = "Update Car Set BranchID = " + branch_id_update.Text
                        + " where Car.vin = '" + vin_update.Text + "'";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");

                }
            }
            else {
                try
                {
                    myCommand.CommandText = "Update car Set Branch_ID = '" + branch_id_update.Text
                        + "' ,License_plate = '" + license_plate_update.Text + "' where car.vin = '" + vin_update.Text + "'";
                    MessageBox.Show(myCommand.CommandText);
                    myCommand.ExecuteNonQuery();

                }
                catch(Exception e3) {
                    MessageBox.Show(e3.ToString(), "Error");    
                }
            }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Car ";
            TextBox[] filters = { filter_make, filter_model, filter_year, filter_color};
            for (int i = 0; i < 4; i++) {
                if (filters[i].Text != "") {
                    if (filters[i].PlaceholderText == "Year")
                    {
                        if (myCommand.CommandText == "select * from Car ")
                        {
                            myCommand.CommandText += "where " + filters[i].PlaceholderText + " = " + filters[i].Text+ " ";
                        }
                        else
                        {
                            myCommand.CommandText += " and " + filters[i].PlaceholderText + " = " + filters[i].Text + " ";
                        }

                    }
                    else
                    {
                        if (myCommand.CommandText == "select * from Car ")
                        {
                            myCommand.CommandText += "where " + filters[i].PlaceholderText + " = '" + filters[i].Text + "'";
                        }
                        else
                        {
                            myCommand.CommandText += " and " + filters[i].PlaceholderText + " = '" + filters[i].Text + "'";
                        }
                    }
                }
            }
            if (filter_class.Text != filter_class.ValueMember && myCommand.CommandText != "select * from Car ")
            {
                myCommand.CommandText += "and " + filter_class.ValueMember + " = '" + filter_class.Text + "'";
            }
            else if (filter_class.Text != filter_class.ValueMember) {
                myCommand.CommandText += "where " + filter_class.ValueMember + " = '" + filter_class.Text + "'";
            }
            if (filter_Branch.Text != filter_Branch.ValueMember && myCommand.CommandText != "select * from Car ")
            {
                myCommand.CommandText += " and branchID" + " = (select ID from Branch where Branch.Name = '" + filter_Branch.Text + "')";
            }
            else if (filter_Branch.Text != filter_Branch.ValueMember)
            {
                myCommand.CommandText += "where branchID" + " = (select ID from Branch where Branch.Name = '" + filter_Branch.Text + "')";
            }
            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                filter_BranchName.Rows.Clear();
                while (myReader.Read())
                {
                    filter_BranchName.Rows.Add(myReader["Vin"].ToString(), myReader["make"].ToString(), myReader["model"].ToString(), myReader["year"].ToString(),
                        myReader["color"].ToString(), myReader["BranchID"].ToString(), myReader["CarClass"].ToString(), myReader["license_plate"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
