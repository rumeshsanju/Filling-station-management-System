using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filling_station_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 myForm = new Form3();
            myForm.ShowDialog();
            this.Close();

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 myForm = new Form4();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 myForm = new Form5();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 myForm = new Form6();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 myForm = new Form7();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
