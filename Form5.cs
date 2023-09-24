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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double[] sellPrice = new double[4];
            double[] purePrice = new double[4];
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1KG4E74;Initial Catalog=Filling_Station_Management_system;Integrated Security=True");
       
            SqlCommand cmd1 = new SqlCommand("select * from FuelDetails where FID =@para1", con);
            cmd1.Parameters.AddWithValue("@para1", "F01");
            SqlDataReader reader1;
            con.Open();
            reader1 = cmd1.ExecuteReader();
            reader1.Read();
            sellPrice[0] = double.Parse(reader1.GetValue(2).ToString());
            purePrice[0] = double.Parse(reader1.GetValue(3).ToString());
            con.Close();

            //data retreving from data base separetly
            SqlCommand cmd2 = new SqlCommand("select * from FuelDetails where FID=@para2", con);
            con.Open();
            cmd2.Parameters.AddWithValue("@para2", "F02");
            reader1 =cmd2.ExecuteReader();
            reader1.Read();
            sellPrice[1] = double.Parse(reader1.GetValue(2).ToString());
            purePrice[1] = Double.Parse(reader1.GetValue(3).ToString());
            con.Close ();

            SqlCommand cmd3 = new SqlCommand("select * from FuelDetails where FID=@para3", con);
            con.Open();
            cmd3.Parameters.AddWithValue("@para3", "F03");
            reader1 = cmd3.ExecuteReader();
            reader1.Read();
            sellPrice[2] = double.Parse(reader1.GetValue(2).ToString());
            purePrice[2] = Double.Parse(reader1.GetValue(3).ToString());
            con.Close () ;

            SqlCommand cmd4 = new SqlCommand("select * from FuelDetails where FID=@para4", con);
            con.Open();
            cmd4.Parameters.AddWithValue("@para4", "F04");
            reader1 = cmd4.ExecuteReader();
            reader1.Read();
            sellPrice[3] = double.Parse(reader1.GetValue(2).ToString());
            purePrice[3] = Double.Parse(reader1.GetValue(3).ToString());
            con.Close();

            //perform calculation using database value
            double[] income = new double[4];
            double[] expendture = new double[4];

            income[0] = (double.Parse(txtP92.Text))*sellPrice[0];
            income [1] = (double.Parse(txtP95.Text))*sellPrice[1];
            income[2] = (double.Parse(txtDi.Text)) * sellPrice[2];
            income[3] = (double.Parse(txtKer.Text)) * sellPrice[3];

            expendture[0] = (double.Parse(txtP92.Text)) * purePrice[0];
            expendture[1] = (double.Parse(txtP95.Text)) * purePrice[1];
            expendture[2] = (double.Parse(txtDi.Text)) * purePrice[2];
            expendture[3] = (double.Parse(txtKer.Text)) * purePrice[3];

            double sum1=0 ,sum2=0 ;
            for(int i=0; i < income.Length; i++)
            {
                sum1 =sum1+income[i];
            }

            for (int i = 0; i < expendture.Length; i++)
            {
                sum2 =sum2+expendture[i];
            }

            lblIn.Text = sum1.ToString();
            lblExp.Text = sum2.ToString();
            lblProfit.Text = (sum1-sum2).ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
