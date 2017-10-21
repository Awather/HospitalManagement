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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

            {
                lblEmpty.Text = Convert.ToString(LoginTest.userID);   // Data placeras i labelxx
                                                                      //label2.Text = Login.skurk.FName;   //fångar upp data från LoginForm
                                                                      //label3.Text = Login.sjuk.bilen.Fabrikat;  //fångar upp data från LoginForm

                //pnlNull.BringToFront();

                //Databasacccess här för att hämta info om inloggad
                DataSet dsUserInfo = new DataSet();
                dsUserInfo = DBAccess.GetUserInformation(LoginTest.userID);
                label2.Text = Convert.ToString(dsUserInfo.Tables[0].Rows[0][0]) + " " + Convert.ToString(dsUserInfo.Tables[0].Rows[0][1]);
                label3.Text = Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]) + " at " + Convert.ToString(dsUserInfo.Tables[0].Rows[0][3]);
            }
    }
}
