using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Purpose: Form that allows user to runs pre-generated stored procedures with desired customizations, no visible sql code
 *      Loads all the current Branch names from database 
 *  
 *  Parameters:None
 *  Returns: None
 *  (2021-06-06)
 * 
 */

namespace _291_Project
{

    public partial class Emp_ReportsForm : Form
    {

        List<Customer> customers = new List<Customer>();
        List<Car> cars = new List<Car>();
        List<string> branches = new List<string>();


        public Emp_ReportsForm()
        {
            InitializeComponent();
            branchNameLbL.Visible = false;
            branchNameComboBox.Visible = false;
            availabilityChoiceComboBox.Visible = false;
        }

        private void Emp_Reports_Load(object sender, EventArgs e)
        {


            /* Stored Prodedure Reports */
            reportsComboBox.Items.Add("Customers who rented 3 or more times");
            reportsComboBox.Items.Add("Car's Avalable");
            reportsComboBox.Items.Add("Branches by number of free upgrades");
            reportsComboBox.Items.Add("Gold members");

            /* TODO: Not working - code in DataAccess class
             */
            availabilityChoiceComboBox.Items.Add("Coming soon");
            //availabilityChoiceComboBox.Items.Add("No");
          

            /* Load all branch names from DB to comboBox */
            DataAccess db = new DataAccess();
            branches = db.GetBranches();
            foreach (string s in branches)
            {
                branchNameComboBox.Items.Add(s);
            }
        }

        private void clear_reports()
        {
            reportsComboBox.SelectedItem = null;
            availabilityChoiceComboBox.SelectedItem = null;
            branchNameComboBox.SelectedItem = null;
            reportListbox.DataSource = null;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (reportsComboBox.Text == "Gold members")
            {
                customers = db.GoldMembers();
                reportListbox.DataSource = customers;
                reportListbox.DisplayMember = "FullInfo";
            }
            else if (reportsComboBox.Text == "Car's Avalable")
            {
                cars = db.Availability(branchNameComboBox.Text);
                reportListbox.DataSource = cars;
                reportListbox.DisplayMember = "FullInfo";
            }
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void firstNameInsLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            branchNameLbL.Visible = false;
            branchNameComboBox.Visible = false;
            if (reportsComboBox.Text == "Car's Avalable")
            {
                branchNameComboBox.Visible = true;
                branchNameLbL.Visible = true;
            }
        }

        private void peopleFoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void availabilitychoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            branchNameLbL.Visible = false;
            branchNameComboBox.Visible = false;
            clear_reports();
        }

        private void branchNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void branchNameLbL_Click(object sender, EventArgs e)
        {

        }
    }
}
