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

        private DataSet dsPermissions = new DataSet();
        const int MinPersNr = 19000101;
        const int MaxPersNr = 20171231;

        private string felMedd = "";
        Control obj;


        //bool notRunFirstTime;
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

                //Databasaccess här för att hämta permissions för denna user och lägga i en dropdown eller i annat
                //Här fylls en dropdown med permissions för denna user
                cmbPermissions.Items.Clear();

                dsPermissions = DBAccess.GetRolesPermission(Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]));
                cmbPermissions.DataSource = dsPermissions.Tables[0];
                cmbPermissions.DisplayMember = "Permission";
                //vill ha blankrad som första rad
                DataRow row = dsPermissions.Tables[0].NewRow();
                row["Permission"] = "";                     //insert a blank row - you can even write something like = "Please select bellow...";
                dsPermissions.Tables[0].Rows.InsertAt(row, 0); //insert new row to index 0 (on top=0)
                cmbPermissions.SelectedIndex = 0;

                //notRunFirstTime = false;

                //Gör en Person-patient-personal klass
        }

    }
}

