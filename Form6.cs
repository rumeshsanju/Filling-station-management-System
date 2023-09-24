using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filling_station_project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1KG4E74;Initial Catalog=Filling_Station_Management_system;Integrated Security=True");
            float current, update;
            String input = cmbFuel.Text;
            if (input == "petrol(92 Octane)")
            {
                //retrive current value
                SqlCommand cmd1 = new SqlCommand("select * from Stock where FID =@para", con);
                cmd1.Parameters.AddWithValue("@para", "F01");
                SqlDataReader reader1;
                con.Open();
                reader1 = cmd1.ExecuteReader();
                reader1.Read();
                current = float.Parse(reader1.GetValue(2).ToString());
                con.Close();

                //update stock
                update = current + (float.Parse(txtReceived.Text) - float.Parse(txtAmount.Text));

                //Save remaining stocks
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update Stock set Stock_Leters=@stock where FID =@para", con);
                cmd2.Parameters.AddWithValue("@para", "F01");
                cmd2.Parameters.AddWithValue("@stock", update);

                cmd2.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("succesfully update the stock", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                txtReceived.Clear();
            }
            if (input =="petrol(95 Octane)") 
            {
                //retrive current value
                SqlCommand cmd1 = new SqlCommand("select * from Stock where FID =@para", con);
                cmd1.Parameters.AddWithValue("@para", "F02");
                SqlDataReader reader1;
                con.Open();
                reader1 = cmd1.ExecuteReader();
                reader1.Read();
                current = float.Parse(reader1.GetValue(2).ToString());
                con.Close();

                //update stock
                update = current + (float.Parse(txtReceived.Text) - float.Parse(txtAmount.Text));

                //Save remaining stocks
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update Stock set Stock_Leters=@stock where FID =@para", con);
                cmd2.Parameters.AddWithValue("@para", "F02");
                cmd2.Parameters.AddWithValue("@stock", update);

                cmd2.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("succesfully update the stock", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                txtReceived.Clear();
            }
            else if (input == "Diesel") 
            {
                //retrive current value
                SqlCommand cmd1 = new SqlCommand("select * from Stock where FID =@para", con);
                cmd1.Parameters.AddWithValue("@para", "F03");
                SqlDataReader reader1;
                con.Open();
                reader1 = cmd1.ExecuteReader();
                reader1.Read();
                current = float.Parse(reader1.GetValue(2).ToString());
                con.Close();

                //update stock
                update = current + (float.Parse(txtReceived.Text) - float.Parse(txtAmount.Text));

                //Save remaining stocks
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update Stock set Stock_Leters=@stock where FID =@para", con);
                cmd2.Parameters.AddWithValue("@para", "F03");
                cmd2.Parameters.AddWithValue("@stock", update);

                cmd2.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("succesfully update the stock", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                txtReceived.Clear();
            }
            else if (input == "Kerosene") 
            {
                //retrive current value
                SqlCommand cmd1 = new SqlCommand("select * from Stock where FID =@para", con);
                cmd1.Parameters.AddWithValue("@para", "F04");
                SqlDataReader reader1;
                con.Open();
                reader1 = cmd1.ExecuteReader();
                reader1.Read();
                current = float.Parse(reader1.GetValue(2).ToString());
                con.Close();

                //update stock
                update = current + (float.Parse(txtReceived.Text) - float.Parse(txtAmount.Text));

                //Save remaining stocks
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update Stock set Stock_Leters=@stock where FID =@para", con);
                cmd2.Parameters.AddWithValue("@para", "F04");
                cmd2.Parameters.AddWithValue("@stock", update);

                cmd2.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("succesfully update the stock", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                txtReceived.Clear();

            }




        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            stock1.Clear();
            sqlDataAdapter1.Fill(stock1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
