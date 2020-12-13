using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_practice
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string mobile = textBoxPhoneNumber.Text;
           string orgName = textBoxOrgName.Text;
           String orgAddress = textBoxOrgAddress.Text;
           /* RadioButton temp = null;
            foreach (var rb in groupBoxGender.Controls)
            {
                if (rb.)
                {
                    another way was not shown
                }
            } */
            RadioButton b = groupBoxGender.Controls.OfType<RadioButton>().FirstOrDefault(n=> n.Checked);
             string gender = b.Text;
            String profession = comboBoxProf.SelectedItem.ToString();

            String output = String.Format("Name : {0} \n" +
                "Phone number :{1} \n" +
                "Gender :{2}\n" +
                "Profession: {3}\n"+
                "Organization name:{4}\n" +
                "Organization address : {5}", name, mobile,gender,profession,orgName,orgAddress);
           
            Output.Text = output;
            new DashBoard(name,mobile,gender,profession,orgName,orgAddress).Show();


        }
    }
}
