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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_4(object sender, EventArgs e)
        {

        }

        private void label2_Click_5(object sender, EventArgs e)
        {

        }

        private void labelAI_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClicked(object sender, EventArgs e)
        {
            string fname = textBoxFN.Text;
            string lname = textBoxLN.Text;
            string month = comboBoxMonth.SelectedItem.ToString();
            string day = comboBoxDay.SelectedItem.ToString();
            string year = comboBoxYear.SelectedItem.ToString();
            string gender = comboBoxGender.SelectedItem.ToString();

            string email = textBoxEmail.Text;
            string remail = textBoxREmail.Text;
            string pass = textBoxPassword.Text;
            string rpass = textBoxrpass.Text;
            string sq = comboBoxSQ.SelectedItem.ToString();
            string sa = textBoxSA.Text;

            string address = textBoxAddress.Text;
            string city = textBoxCity.Text;
            string state = comboBoxState.SelectedItem.ToString();
            string zip = textBoxZC.Text;
            string phone = textBoxPhone.Text;
            string phntype = comboBoxPhone.SelectedItem.ToString();

            string output = String.Format("First Name : {0}" +
                "\nLast Name : {1}" +
                "\nDate of Birth : {2}-{3}-{4}" +
                "\nGender : {5}" +
                "\nEmail : {6}" +
                "\nAddress : {7}" +
                "\nCity : {8}" +
                "\nState : {9}" +
                "\nZip : {10}" +
                "\nPhone : {11} => {12}",fname,lname,month,day,year,gender,email,address,city,state,zip,phntype,phone);

            richTextBoxOutput.Text = output;
        }
    }
}
