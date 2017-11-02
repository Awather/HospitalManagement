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
    public partial class DoctorNotes : Form
    {
        public DoctorNotes()
        {
            InitializeComponent();
        }

        private void btnSaveDrComment_Click(object sender, EventArgs e)
        {

            //DoctorNotes newDoctorNotes = new DoctorNotes(txtDoctorComments.Text.Insert);
            //if (DBAccess.InsertDoctorsNotes(newDoctorNotes.im))

            DataSet ds = new DataSet();
            //ds = DBAccess.InsertDoctorsNotes(DBAccess.InsertDoctorsNotes(notes, 'U'));
            /*DoctorNotes newNotes = new DoctorNotes(txtDoctorComments.Text)*/;

            //foreach (DataRow dr in ds.Tables[0].Rows)

            //{
            //    txtDoctorComments.Text = txtDoctorComments.Text + Environment.NewLine + dr[0].ToString().Substring(0, 10)
            //    + " " + dr[1].ToString().Substring(0, 5) + Environment.NewLine + dr[5].ToString() + Environment.NewLine;

            //}

            //DoctorNotes newNotes = new DoctorNotes(txtPersnNumber.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPostalNumber.Text, txtCity.Text, txtPhoneNumer.Text, txtEmail.Text, gender);
            //DoctorNotes newDoctorNotes = new DoctorNotes();
            if (DBAccess.InsertDoctorsNotes(txtDoctorComments.Text, LoginStaff.userID, Form1.myPatient.PersonNumber))
            //(DBAccess.InsertDoctorsNotes(txtDoctorComments.Text))
            {
                MessageBox.Show("Comment saved successfully!");
                btnSaveDrComment.Enabled = false;
            }
            else

            {
                MessageBox.Show("Comment was not saved!");
            }

        }
    }
}
