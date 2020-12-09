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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        private void btnclickEU(object sender, EventArgs e)
        {
            new Registration().Show();
        }
    }
}
