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
        public static Patient myPatient;

        private string errorMessage = "";
        Control objct;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

            {
                lblEmpty.Text = Convert.ToString(LoginTest.userID);   // Data placeras i labelxx
                                                                      //label2.Text = Login.skurk.FName;   //fångar upp data från LoginForm
                                                                      //label3.Text = Login.sjuk.bilen.Fabrikat;  //fångar upp data från LoginForm

            pnlEmpty.BringToFront(); //-- Create empty panel as front.
                                     //Comment in other panels aswell when GUI is set

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
            row["Permission"] = "Empty";      // Remove "Empty" when working  //insert a blank row - you can even write something like = "Please select bellow...";
            dsPermissions.Tables[0].Rows.InsertAt(row, 0); //insert new row to index 0 (on top=0)
            cmbPermissions.SelectedIndex = 0;

            lblNoPatient.Text = "";  // --Comment in

            //Gör en Person-patient-personal klass
        }

        private void btnUppdPatJournal_Click(object sender, EventArgs e)
        {

            //if (TestaIndata())
            //{
            //    MessageBox.Show(felMedd);
            //    obj.Focus();
            //}
            //else
            //{
            //    //här kan jag gå till db och hämta upp data om en patient

            //}

        }


        private void btnChoose_Click(object sender, EventArgs e)
        {
            string choice = (cmbPermissions.Text);
            //pnlEmpty.BringToFront();
            switch (choice)
            {
                case "Register Patients":  // Remove when panels work
                    pnlRegisPatients.BringToFront();
                    break;
                case "Create Patients Journal":
                    pnlCreatePatJournal.BringToFront();
                    break;
            }
        }

        //private void btnChoose_Click(object sender, EventArgs e)
        //{
        //    string choice = (cmbPermissions.Text);
            
        //    if ( choice == ("Empty"))
        //    {
        //        pnlEmpty.BringToFront();
        //    }
        //    else
        //        if ( choice == ("Update Patients Journal"))
        //    {
        //        pnlUppPatJournal.BringToFront();
        //    }

        //}

        private void btnGetPatient_Click(object sender, EventArgs e)
        {

        }


        private void btnCreateJournal_Click(object sender, EventArgs e)
        {
            myPatient = DBAccess.GetPatientInformation(txtPersNumber2.Text);

            if (myPatient.PersonNumber == null)

            {
                lblNoPatient.Text = "Patients does not exsist in the registry!";
            }
            else
            {

                PatientJournal frmPatienttJournal = new PatientJournal();
                frmPatienttJournal.Show();
            }

        }
    }
}



