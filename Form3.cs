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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            fsStaff1.Clear();
                sqlDataAdapter1.Fill(fsStaff1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            btn_save.Enabled = true;
            btn_add.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(fsStaff1);
            dataGridView1.ReadOnly = true;
            btn_save.Enabled = false;
            btn_add.Enabled = true;
            btn_delete.Enabled = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete this row ? ", "Delete", MessageBoxButtons.YesNo);
               if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    sqlDataAdapter1.Update(fsStaff1);
                }
            }
            catch
            {
                MessageBox.Show("Please select the whole row instead of a cell");
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
            
        }
    }
}
