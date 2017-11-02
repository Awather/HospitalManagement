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
    public partial class PatientJournal : Form
    {
        public PatientJournal()
        {
            InitializeComponent();
        }

        private void PatientJournal_Load(object sender, EventArgs e)
        {
            // PatientsJournal.ActiveForm.Text = "Patient Journal för :" + "Janne Zandstra 19601015-1234";

            DataSet ds = new DataSet();
            ds = DBAccess.GetDoctorsNotes(Form1.myPatient.PersonNumber);

            foreach (DataRow dr in ds.Tables[0].Rows)

            {
                textDoctorNotes.Text = textDoctorNotes.Text + Environment.NewLine + dr[0].ToString().Substring(0, 10)
                + " " + dr[1].ToString().Substring(0, 5) + Environment.NewLine + dr[2].ToString() + Environment.NewLine;

            }
        }

        private void PatientJournal_Activated(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = DBAccess.GetUserInformation(LoginStaff.userID);

            PatientJournal.ActiveForm.Text = "This journal is for: " + Form1.myPatient.FirstName + " " + Form1.myPatient.LastName + 
            " By doctor: " + ds.Tables[0].Rows[0][0] + " " + ds.Tables[0].Rows[0][1];

        }

        private void btnNewStmtCommnt_Click(object sender, EventArgs e)
        {


            DoctorNotes frmDoctorNotes = new DoctorNotes();
            frmDoctorNotes.Show();
        }
    }
}
