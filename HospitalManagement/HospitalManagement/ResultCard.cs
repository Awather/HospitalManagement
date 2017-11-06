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
    public partial class ResultCard : Form
    {
        public ResultCard()
        {
            InitializeComponent();
        }

        private void ResultCard_Load(object sender, EventArgs e)
        {

            //DataSet ds = new DataSet();
            //ds = DBAccess.GetDoctorsNotes(Form1.myPatient.PersonNumber);

            //foreach (DataRow dr in ds.Tables[0].Rows)

            //{
            //    txtResultCardNotes.Text = txtResultCardNotes.Text + Environment.NewLine + dr[0].ToString().Substring(0, 10)
            //    + " " + dr[1].ToString().Substring(0, 5) + Environment.NewLine + dr[2].ToString() + Environment.NewLine;

            //}




        }
    }
}
