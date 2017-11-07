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



        //bool notRunFirstTime;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            lblEmpty.Text = Convert.ToString(LoginStaff.userID);   // Data placeras i labelxx
                                                                   //label2.Text = Login.skurk.FName;   //fångar upp data från LoginForm
                                                                   //label3.Text = Login.sjuk.bilen.Fabrikat;  //fångar upp data från LoginForm

            pnlEmpty.BringToFront(); //-- Create empty panel as front.
                                     //Comment in other panels aswell when GUI is set

            //Databasacccess här för att hämta info om inloggad
            DataSet dsUserInfo = new DataSet();
            dsUserInfo = DBAccess.GetUserInformation(LoginStaff.userID);
            lblStaffName.Text = Convert.ToString(dsUserInfo.Tables[0].Rows[0][0]) + " " + Convert.ToString(dsUserInfo.Tables[0].Rows[0][1]);
            lblStaffPosition.Text = Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]) + " at " + Convert.ToString(dsUserInfo.Tables[0].Rows[0][3]);




            // Testing buttons on the Load-placement

            DataSet dsPermissions = new DataSet();
            dsPermissions = DBAccess.GetRolesPermission(Convert.ToString(dsUserInfo.Tables[0].Rows[0][2])); // ("Doctor")
            //dsPermissions = DBAccess.GetRolesPermission(LoginStaff.userID);


            int posts = dsPermissions.Tables[0].Rows.Count;

            for (int i = 0; i < posts; i++)
            {
                Button btnPermissionBtn = new Button();
                btnPermissionBtn.Size = new Size(130, 30);
                btnPermissionBtn.Location = new Point(40, 30 * i + 50);   //(160 = y, 30 * i + 10 = x); 
                // btnPermissionBtn.Parent.Controls.GetChildIndex(btnPermissionBtn);
                //btnPermissionBtn.FlatAppearance.BorderSize{ }
                btnPermissionBtn.FlatStyle = FlatStyle.Popup;
                btnPermissionBtn.ForeColor = Button.DefaultBackColor;
                btnPermissionBtn.ForeColor = Color.Black;
                btnPermissionBtn.Click += new EventHandler(ButtonClickOneEvent); // Ask jan about this
                btnPermissionBtn.Tag = i; // Ask Jan about this
                btnPermissionBtn.Text = dsPermissions.Tables[0].Rows[i][0].ToString(); // MORE QUESTIONS!
                this.Controls.Add(btnPermissionBtn);

            }


            //Databasaccess här för att hämta permissions för denna user och lägga i en dropdown eller i annat
            //Här fylls en dropdown med permissions för denna user

 // *********************************
            // DROPDOWN BOX

            //cmbPermissions.Items.Clear();

            //dsPermissions = DBAccess.GetRolesPermission(Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]));
            //cmbPermissions.DataSource = dsPermissions.Tables[0];
            //cmbPermissions.DisplayMember = "Permission";





            ////vill ha blankrad som första rad
            //DataRow row = dsPermissions.Tables[0].NewRow();
            //row["Permission"] = "";                     //insert a blank row - you can even write something like = "Please select bellow...";
            //dsPermissions.Tables[0].Rows.InsertAt(row, 0); //insert new row to index 0 (on top=0)
            //cmbPermissions.SelectedIndex = 0;


            //lblNoPatient.Text = "";  // --Comment in

// *********************************

            //Gör en Person-patient-personal klass
        }

        private void BtnPermissionBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnUppdPatJournal_Click(object sender, EventArgs e)
        {
            myPatient = DBAccess.GetPatientInformation(txtPersN2UpdJour.Text); // txtPersN2UpdJour - For updating journals

            if (myPatient.PersonNumber == null)

            {
                lblNoPatient.Text = "Patients does not exsist in the registry!";
            }
            else
            {

                PatientJournal frmPatientJournal = new PatientJournal();
                frmPatientJournal.Show();
            }
        }

    //***************************************************
    // SWITCH - CASE  for  DROPDOWN BOX

        // Choose button 
        //private void btnChoose_Click(object sender, EventArgs e)
        //{
        //    string choice = (cmbPermissions.Text);
        //    pnlEmpty.BringToFront();
        //    switch (choice)
        //    {
        //        case "Set Visiting Hours":
        //            pnlEmpty.SendToBack();
        //            pnlSetVisitingHours.BringToFront();
        //            break;
        //        case "Set Appointment Hours":
        //            pnlEmpty.SendToBack();
        //            pnlSetAppointHour.BringToFront();
        //            break;
        //        case "Update Patients Journal":
        //            pnlEmpty.SendToBack();
        //            pnlUppPatJournal.BringToFront();
        //            break;
        //        case "Register Patients":
        //            pnlEmpty.SendToBack();
        //            pnlRegisPatient.BringToFront();
        //            break;
        //        case "Update Patients Information":
        //            pnlEmpty.SendToBack();
        //            pnlUpptPatient.BringToFront();
        //            break;
        //        case "Create Patients Journal":
        //            pnlEmpty.SendToBack();
        //            pnlCreatePatJournal.BringToFront();
        //            break;
        //    }
        //}
    //**************************************************



        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            //DataSet dsPatientInfo = new DataSet();
            //dsPatientInfo = dbAccess.GetPatientInfo(txtPersonnummer.Text);
            //string vcd = Convert.ToString(dsPatientInfo.Tables[0].Rows[0][0]);

            myPatient = DBAccess.GetPatientInformation(txtPersN1UpdPat.Text);

            //
            if (myPatient.PersonNumber == null)
            {
                lblNoPatient.Text = "Patients does not exsist in the registry!";
            }
            else
            {
                // if personnumber is in the database
                UpdatePatient frmUpdatePatients = new UpdatePatient();
                frmUpdatePatients.Show();
            }


        }

        private void btnCreateJournal_Click(object sender, EventArgs e)

        {
            //DataSet dsPatientInfo = new DataSet();
            //dsPatientInfo = dbAccess.GetPatientInfo(txtPersonnummer.Text);
            //string vcd = Convert.ToString(dsPatientInfo.Tables[0].Rows[0][0]);

            myPatient = DBAccess.GetPatientInformation(txtPersN1UpdPat.Text);

            //
            if (myPatient.PersonNumber == null)
            {
                lblNoPatient.Text = "Patients does not exsist in the registry!";
            }
            else
            {
                // if personnumber is in the database
                PatientJournal frmPatientJournal = new PatientJournal();
                frmPatientJournal.Show();
            }
        }

        private void btnRegisPatient_Click(object sender, EventArgs e)
        {
            RegisterPatients frmRegisterPatients = new RegisterPatients();
            frmRegisterPatients.Show();

        }



        void ButtonClickOneEvent(object sender, EventArgs e)

        {
            Button btnPermissionBtn = sender as Button;

            //int posts = dsPermissions.Tables[0].Rows.Count;

            // DataSet dsPermissions = new DataSet();
            //dsPermissions = DBAccess.GetRolesPermission("Receptionist");
            //dsPermissions = DBAccess.GetRolesPermission("Doctor");


            string roleTitle = lblStaffPosition.Text;
            //string roleTitle1 = "Doctor";
            //string roleTitle2 = "Nurse";

            // dsPermissions = DBAccess.GetRolesPermission(Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]));

            //int posts = dsPermissions.Tables[0].Rows.Count;

            if (btnPermissionBtn != null)

                //switch (roleTitle)
                //{
                //case "Doctor":
                //    {
                //        dsPermissions = DBAccess.GetRolesPermission("Doctor");
                //        int posts = dsPermissions.Tables[0].Rows.Count;
                //        if (btnPermissionBtn != null) break;

                switch ((int)btnPermissionBtn.Tag) // ??
                        {
                            case 0:
                                //pnlEmpty.SendToBack();
                                pnlSetVisitingHours.BringToFront();
                                break;
                            case 1:
                                //pnlEmpty.SendToBack();
                                pnlSetAppointHour.BringToFront();
                                break;
                            case 2:
                                //pnlEmpty.SendToBack();
                                pnlUppPatJournal.BringToFront();
                                break;
                            case 3:
                                //pnlEmpty.SendToBack();
                                pnlRegisPatient.BringToFront();
                                break;
                            //case 4:
                            //    //pnlEmpty.SendToBack();
                            //    pnlUpptPatient.BringToFront();
                            //    break;
                            //case 5:
                            //    //pnlEmpty.SendToBack();
                            //    pnlCreatePatJournal.BringToFront();
                            //    break;


                        }
                    }

        private void panel2_Paint(object sender, PaintEventArgs e) // Background panel-colour must be SendToBack here, or else it does not work. 
        {
            panel2.SendToBack();
        }
    }

}



