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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage Wp = new WelcomePage();
            this.Hide();
            Wp.ShowDialog();
        }
    }
}
