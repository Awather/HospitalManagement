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

            //DoctorNotes newDoctorNotes = new DoctorNotes(txtDoctorComments.Text);
            //if (DBAccess.GetDoctorsNotes(newDoctorNotes, 'C'))
            //{
            //    MessageBox.Show("Comment OK");
            //    btnSaveDrComment.Enabled = false;
            //}
            //else
            //{
            //    MessageBox.Show("Comment Not OK!");
            //}

        }
    }
}
