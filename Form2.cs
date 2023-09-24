using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Filling_station_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Enter the Admine id");

            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-1KG4E74;Initial Catalog=Filling_Station_Management_system;Integrated Security=True");
                    SqlCommand cmd =new SqlCommand("select * from login where AdmineID = @AdmineId and password =@password",con) ;
                    cmd.Parameters.AddWithValue("@AdmineId", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        this.Hide();
                        Form1 myForm = new Form1();
                        myForm.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Admine_Id or password is invalid");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
