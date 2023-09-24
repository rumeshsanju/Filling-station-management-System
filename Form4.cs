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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            suppliers1.Clear();
            sqlDataAdapter1.Fill(suppliers1);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gold;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(suppliers1);
            dataGridView1.ReadOnly = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete this row ? ", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    sqlDataAdapter1.Update(suppliers1);
                }
            }
            catch
            {
                MessageBox.Show("Please select the whole row instead of a cell");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
        }
    }
}
