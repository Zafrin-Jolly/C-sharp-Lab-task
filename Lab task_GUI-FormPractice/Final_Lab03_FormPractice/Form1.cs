using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Lab03_FormPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClicked(object sender, EventArgs e)
        {
            string user = textBoxUsername.Text;
            string pass = textBoxPassword.Text;

            if (user.Equals("Tahsin Adiba Nijum") && pass.Equals("19-40428-1"))
            {
                new Form2().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
