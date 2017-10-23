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
        public static string userID; // Global variabel
        public static string Patient;

        public LoginTest()
        {
            InitializeComponent();
        }

        //private void LoginTest_Load(object sender, EventArgs e)
        //{

        //}

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application is canceled
            Application.Exit();
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
            txtForgotPass.Text = "You're Fired!";


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Database access here

            if (DBAccess.IsUserIdPassWdOK(txtUsername.Text, txtPassword.Text))

            {
                userID = txtUsername.Text; // Värdet som ska skickas


                Form1 frmForm1 = new Form1();
                frmForm1.Show();

                //MainMenuTest frmMainMenuTest = new MainMenuTest();
                //frmMainMenuTest.Show();

                this.Hide();

                }

                else

                {

                if (DBAccess.PatientLogin(txtUsername.Text, txtPassword.Text))

                {
                    Patient = txtUsername.Text; // Värdet som ska skickas


                    PatientGUI frmPatientGUI = new PatientGUI();
                    frmPatientGUI.Show();
                }

                else

                {
                    Application.Exit();
                }



            }
        }
    }
}
