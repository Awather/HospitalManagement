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



        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (chkEmployee.Checked == true)
            {
                LoginStaff frmLoginStaff = new LoginStaff();
                frmLoginStaff.Show();

                this.Hide();
            }
            else if (chkPatient.Checked == true)
            {
                LoginTest frmLoginTest = new LoginTest();
                frmLoginTest.Show();

                this.Hide();
            }

        }

        private void chkEmployee_Click(object sender, EventArgs e)
        {
            chkEmployee.Checked = true;
            chkPatient.Checked = false;
        }

        private void chkPatient_Click(object sender, EventArgs e)
        {
            chkPatient.Checked = true;
            chkEmployee.Checked = false;
        }
    }
}
