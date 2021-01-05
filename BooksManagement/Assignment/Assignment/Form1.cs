using Assignment.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            dynamic result1 = BookController.GetAllBook2(id);
            if (result1 != null)
            {
                dataGridView.DataSource = result1;
            }
            else
            {
                MessageBox.Show("No Books found");
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
