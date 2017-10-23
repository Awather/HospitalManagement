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
    public partial class RegisterPatients : Form
    {
        const int LeastPersNumber = 19000101;
        const int MaxPersNumber = 20171231;

        private string errorMessage = "GET OUT";
        Control objct;


        public RegisterPatients()
        {
            InitializeComponent();
        }

        //private void btnRegistrera_Click(object sender, EventArgs e)
        //{
        //    //kod här för att kolla indata
        //    if (TestingIndata())
        //    {
        //        MessageBox.Show(errorMessage);
        //        objct.Focus();
        //    }
        //    else
        //    {
        //        char gender;
        //        if (chkFemale.Checked)
        //        {
        //            gender = 'F';
        //        }
        //        else
        //        {
        //            if (chkMale.Checked)
        //            {
        //                gender = 'M';
        //            }
        //            else
        //            {
        //                gender = '-';
        //            }
        //        }


        //        //här kan jag gå till db och registrera en patient
        //        Patient newPatient = new Patient(txtPersnNumber.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCity.Text, txtPhoneNumer.Text, txtEmail.Text, gender);
        //        if (DBAccess.InsertUpdatePatient(newPatient,'R'))
        //        {
        //            MessageBox.Show("Registration completed!");
        //            btnRegister.Enabled = false;
        //        }
        //        else

        //        {
        //            MessageBox.Show("Registration failed!");
        //        }


        //    }

        //}

        //// Double checks information that user types in such as person number. 

        ////private bool TestingIndata()
        ////{
        ////    bool felIfyllt = false;

        ////    //här följer en serie kontroller av personnummer
        ////    string personnummer = txtPersNr.Text;
        ////    if (personnummer.Length != 13)
        ////    {
        ////        felIfyllt = true;
        ////        felMedd = "Personnummer fel ifyllt! \nAnvänd formatet: ÅÅÅÅMMDD-XXXX";
        ////        obj = txtPersNr;
        ////        return felIfyllt;
        ////    }

        ////    string delPersNr1, delPersNr2, bindeStreck;
        ////    delPersNr1 = txtPersNr.Text.Substring(0, 8);
        ////    bindeStreck = txtPersNr.Text.Substring(8, 1);


        //    //    if (bindeStreck != "-")
        //    //    {
        //    //        felIfyllt = true;
        //    //        felMedd = "Personnummer fel ifyllt! \nAnvänd formatet: ÅÅÅÅMMDD-XXXX";
        //    //        obj = txtPersNr;
        //    //        return felIfyllt;
        //    //    }

        //    //    int dummy;
        //    //    if (InputUtility.GetInteger(delPersNr1, out dummy, MinPersNr, MaxPersNr))
        //    //    {

        //    //    }
        //    //    else
        //    //    {
        //    //        felIfyllt = true;
        //    //        felMedd = "Personnummer fel ifyllt! \nAnvänd formatet: ÅÅÅÅMMDD-XXXX";
        //    //        obj = txtPersNr;
        //    //        return felIfyllt;
        //    //    }

        //    //    delPersNr2 = txtPersNr.Text.Substring(9, 4);

        //    //    if (InputUtility.GetInteger(delPersNr2, out dummy, 0001, 9999))
        //    //    {

        //    //    }
        //    //    else
        //    //    {
        //    //        felIfyllt = true;
        //    //        felMedd = "Personnummer fel ifyllt! \nAnvänd formatet: ÅÅÅÅMMDD-XXXX";
        //    //        obj = txtPersNr;
        //    //        return felIfyllt;
        //    //    }
        //    //    return felIfyllt;
        //    //}
        //    //private void btnAvbryt_Click(object sender, EventArgs e)
        //    //{


        //    //    RegisterPatients.ActiveForm.Close();
        //    //}


        //private void chkMale_Click(object sender, EventArgs e)
        //{

        //    if (chkMale.Checked)
        //    {
        //        chkMale.Checked = false;
        //        chkFemale.Checked = true;
        //    }
        //    else
        //    {
        //        chkMale.Checked = true;
        //        chkFemale.Checked = false;
        //    }

        //}

        //private void chkFemail_Click(object sender, EventArgs e)
        //{
        //    if (chkFemale.Checked)
        //    {
        //        chkFemale.Checked = false;
        //        chkMale.Checked = true;
        //    }
        //    else
        //    {
        //        chkFemale.Checked = true;
        //        chkMale.Checked = false;
        //    }
        //}

    }
}
