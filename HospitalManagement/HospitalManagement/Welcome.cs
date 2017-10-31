using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void chkEmployee_Click(object sender, EventArgs e)
        {

            //if (chkEmployee.Checked)
            //{
            //    LoginStaff frmLoginStaff = new LoginStaff();
            //    frmLoginStaff.Show();
            //}

            //else;


        }


        private void chkPatient_Click(object sender, EventArgs e)
        {
            //LoginTest frmLoginTest = new LoginTest();
            //frmLoginTest.Show();

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (chkEmployee.Checked == true)
            {
                LoginStaff frmLoginStaff = new LoginStaff();
                frmLoginStaff.Show();
            }
            else if (chkPatient.Checked == true)
            {
                LoginTest frmLoginTest = new LoginTest();
                frmLoginTest.Show();
            }

        }
    }
}
