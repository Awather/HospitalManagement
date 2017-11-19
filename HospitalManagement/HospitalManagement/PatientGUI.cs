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
    public partial class PatientGUI : Form
    {
        private DataSet dsPatientPermission = new DataSet();
        public static Patient myPatient;

        public PatientGUI()
        {
            InitializeComponent();
        }

        private void PatientGUI_Load(object sender, EventArgs e)
        {
            //*************************************************************************************************

            //To get information of the patient logged on. 

            DataSet dsPatientSignedInfo = new DataSet();
            lblEmptyPatient.Text = Convert.ToString(LoginTest.PatientID); // Patient ID is showing. Goal: Patient name isntead of ID
           //dsPatientSignedInfo = DBAccess.PatientLogin(LoginTest.PatientID);
           //lblEmptyPatient.Text = Convert.ToString(dsPatientSignedInfo.Tables[0].Rows[2][0]) + " " + Convert.ToString(dsPatientSignedInfo.Tables[0].Rows[0][3]); // Hides menu-buttons for some reason
            


            //*************************************************************************************
            //DataSet ds = new DataSet();
            //ds = DBAccess.GetDoctorsNotes(Form1.myPatient.PersonNumber);

            //foreach (DataRow dr in ds.Tables[0].Rows)

            //{
            //    textDoctorNotesPatGUI.Text = textDoctorNotesPatGUI.Text + Environment.NewLine + dr[0].ToString().Substring(0, 10)
            //    + " " + dr[1].ToString().Substring(0, 5) + Environment.NewLine + dr[2].ToString() + Environment.NewLine;

            //}

            //pnlResultCard.BringToFront();
            dsPatientPermission = DBAccess.GetPatientPermission("");  // DataSet dsPatientTabs = new DataSet();
            int patientPosts = dsPatientPermission.Tables[0].Rows.Count;

            for (int i = 0; i < patientPosts; i++)
            {
                Button btnPatientTabsBtn = new Button();
                btnPatientTabsBtn.Size = new Size(130, 30);
                btnPatientTabsBtn.Location = new Point(70, 30 * i + 40); //(40, 30 * i + 50);   //(160 = x(hor), 30 * i + 10 = y(ver)); 
                // btnPermissionBtn.Parent.Controls.GetChildIndex(btnPermissionBtn);
                btnPatientTabsBtn.ForeColor = Color.DarkRed;
                btnPatientTabsBtn.Click += new EventHandler(ButtonClickOneEvent); // Ask jan about this
                btnPatientTabsBtn.Tag = i; // Ask Jan about this
                btnPatientTabsBtn.Text = dsPatientPermission.Tables[0].Rows[i][0].ToString(); // MORE QUESTIONS!
                this.Controls.Add(btnPatientTabsBtn);

            }

        }

        void ButtonClickOneEvent(object sender, EventArgs e)
        {
            //DataSet dsPatientSignInfo = new DataSet();
            //dsPatientSignInfo = DBAccess.GetPatientPermission(LoginTest.PatientID);

            //Button btnPatientTabsBtn = sender as Button;

            //dsPatientPermission = DBAccess.GetRolesPermission(Convert.ToString(dsPatientSignInfo.Tables[0].Rows[1]));
            //int posts = dsPatientPermission.Tables[0].Rows.Count;
            //Button btnPatientTabsBtn = sender as Button;

            //    string roleTitle = lblStaffPosition.Text;

            // btnPermissionBtn.BringToFront();
            //if (btnPatientTabsBtn != null)
            if (sender is Button btnPatientTabsBtn)
            {
                switch ((int)btnPatientTabsBtn.Tag) // ??
                {
                    case 0:
                        //pnlEmpty.SendToBack();
                        pnlTesting.BringToFront();
                        break;                    
                    case 1:
                        //pnlEmpty.SendToBack();
                        pnlResultCard.BringToFront();
                        //break;
                        //PatientJournal pnlResultCard = new PatientJournal();
                        //pnlResultCard.BringToFront();
                        break;

                }
            }
        }
    }
}