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
    public partial class DashBoard : Form
    {
        public DashBoard(String name,String mobile,String gender,String profession,String orgName,String orgAddress )
        {
            InitializeComponent();
            String output= String.Format("Name : {0} \n" +
                "Phone number :{1} \n" +
                "Gender :{2}\n" +
                "Profession: {3}\n" +
                "Organization name:{4}\n" +
                "Organization address : {5}", name, mobile, gender, profession, orgName, orgAddress);

            rTOutput.Text = output;

        }
    }
}
