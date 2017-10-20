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
    public partial class Login : Form
    {
        public static string userID; // Global variabel

        public Login()
        {
            InitializeComponent();
        }

        

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application is canceled
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Database access here

            if (DBAccess.IsUserIdPassWdOK(txtUsername.Text, txtPassword.Text))

            {
                userID = txtUsername.Text; // Värdet som ska skickas

                MainMenu frmMainMenu = new MainMenu();
                frmMainMenu.Show();

                this.Hide();
            }
            else
            {
                Application.Exit();
            }

        }

        private void txtForgotPass_Click(object sender, EventArgs e)
        {
            txtForgotPass.Text = "You're Fired!"; 

            
        }
    }
}
