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
    public partial class LoginTest : Form
    {

        public static string Patient; // Global variabel

        public LoginTest()
        {
            InitializeComponent();
        }
        //private void BtnLogin_Click(object sender, EventArgs e)
        //{
        //    // Database access here

        //    if (DBAccess.IsUserIdPassWdOK(txtUsername.Text, txtPassword.Text))

        //    {
        //        userID = txtUsername.Text; // Värdet som ska skickas

        //        MainMenu frmMainMenu = new MainMenu();
        //        frmMainMenu.Show();

        //        this.Hide();
        //    }
        //    else
        //    {
        //        Application.Exit();
        //    }

        //}

        private void txtForgotPass_Click(object sender, EventArgs e)
        {
            txtForgotPassPatient.Text = "";


        }


        private void btnLoginPatient_Click(object sender, EventArgs e)
        {

            if (DBAccess.PatientLogin(txtUsernamePatient.Text, txtPasswordPatient.Text))

            {
                Patient = txtUsernamePatient.Text; // Värdet som ska skickas


                ResultCard frmResultCard = new ResultCard();
                frmResultCard.Show();

                //PatientJournal frmPatientGUI = new PatientJournal();
                //frmPatientGUI.Show();
            }

        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {

            // Application is canceled
            Application.Exit();

        }

        private void txtForgotPassPatient_Click(object sender, EventArgs e)
        {
            txtForgotPassPatient.Text = "";
        }

        private void btnBackPatient_Click(object sender, EventArgs e)
        {
            Welcome frmWelcome = new Welcome();
            frmWelcome.Show();


            this.Hide();
        }
    }
}
