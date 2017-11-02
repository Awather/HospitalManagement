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
    public partial class LoginStaff : Form
    {
        public static string userID; // Global variabel

        public LoginStaff()
        {
            InitializeComponent();
        }

        private void btnLoginStaff_Click(object sender, EventArgs e)
        {

            // Database access here

            if (DBAccess.IsUserIdPassWdOK(txtUsernameStaff.Text, txtPasswordStaff.Text))

            {
                userID = txtUsernameStaff.Text; // Värdet som ska skickas


                Form1 frmForm1 = new Form1();
                frmForm1.Show();

                //MainMenuTest frmMainMenuTest = new MainMenuTest();
                //frmMainMenuTest.Show();

                this.Hide();

            }


            else
            {
                CompSaysNo frmCompSaysNo = new CompSaysNo();
                frmCompSaysNo.ShowDialog();

                //MessageBox.Show("Incorrect User Identification / Password!");

                //Application.Exit();
            }
        }

        private void btnCancelStaff_Click(object sender, EventArgs e)
        {
            // Application is canceled
            Application.Exit();
        }

        private void txtForgotPassStaff_Click(object sender, EventArgs e)
        {
            txtForgotPassStaff.Text = "";
        }

        private void btnBackStaff_Click(object sender, EventArgs e)
        {

            Welcome frmWelcome = new Welcome();
            frmWelcome.Show();


            this.Hide();
        }
    }

}