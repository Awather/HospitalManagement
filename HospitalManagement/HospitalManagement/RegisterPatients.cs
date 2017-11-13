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
        const int MiniPersNumber = 19000101;
        const int MaxPersNumber = 20171231;

        private string errorMessage = "";
        Control objct;


        public RegisterPatients()
        {
            InitializeComponent();
        }

        private void RegisterPatients_Load(object sender, EventArgs e)
        {

            //lblRubrik.Text = "Registrera patient";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //kod här för att kolla indata
            if (TestingInData())
            {
                MessageBox.Show(errorMessage);
                objct.Focus();
            }
            else
            {
                char gender;
                if (chkFemale.Checked)
                {
                    gender = 'F';
                }
                else
                {
                    if (chkMale.Checked)
                    {
                        gender = 'M';
                    }
                    else
                    {
                        gender = '-';
                    }
                }


                //här kan jag gå till db och registrera en patient
                Patient newPatient = new Patient(txtPersnNumber.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPostalNumber.Text, txtCity.Text, txtPhoneNumer.Text, txtEmail.Text, gender);
                if (DBAccess.InsertUpdatePatient(newPatient, 'R'))
                {
                    MessageBox.Show("Registration completed!");
                    btnRegister.Enabled = false;
                }
                else

                {
                    MessageBox.Show("Registration failed!");
                }

                this.Hide();
            }

        }

        //Double checks personnumber that user types in. 

        private bool TestingInData()
        {
            bool wrongWritten = false;

            //här följer en serie kontroller av personnummer
            string personnummer = txtPersnNumber.Text;
            if (personnummer.Length != 13)
            {
                wrongWritten = true;
                errorMessage = "Person-number is wrongly typed! \nUse format: ÅÅÅÅMMDD-XXXX";
                objct = txtPersnNumber;
                return wrongWritten;
            }

            string partPersNumb1, partPersNumb2, dashedLine;
            partPersNumb1 = txtPersnNumber.Text.Substring(0, 8);
            dashedLine = txtPersnNumber.Text.Substring(8, 1);


            if (dashedLine != "-")
            {
                wrongWritten = true;
                errorMessage = "Person-number is wrongly typed! \nUse format: YYYYMMDD-XXXX";
                objct = txtPersnNumber;
                return wrongWritten;
            }

            int dummyTesting;
            if (InputUtility.GetInteger(partPersNumb1, out dummyTesting, MiniPersNumber, MaxPersNumber))  // InputUtility vill ej funka
            {

            }
            else
            {
                wrongWritten = true;
                errorMessage = "Person-number is wrongly typed! \nUse format: YYYYMMDD-XXXX";
                objct = txtPersnNumber;
                return wrongWritten;
            }

            partPersNumb2 = txtPersnNumber.Text.Substring(9, 4);

            if (InputUtility.GetInteger(partPersNumb2, out dummyTesting, 0001, 9999))
            {

            }
            else
            {
                wrongWritten = true;
                errorMessage = "Person-number is typed wrong! \nUse format: YYYYMMDD-XXXX";
                objct = txtPersnNumber;
                return wrongWritten;
            }
            //return wrongWritten;

            if (txtFirstName.Text == "")
            {
                wrongWritten = true;
                errorMessage = "There must be a firstname dummy!";
                objct = txtFirstName;
                return wrongWritten;
            }

            if (txtLastName.Text == "")
            {
                wrongWritten = true;
                errorMessage = "There must be a lastname aswell idiot!";
                objct = txtLastName;
                return wrongWritten;
            }

            if (txtAddress.Text == "")
            {
                wrongWritten = true;
                errorMessage = "Address not filled in!";
                objct = txtAddress;
                return wrongWritten;
            }

            if (txtPostalNumber.Text == "")
            {
                wrongWritten = true;
                errorMessage = "Postal-number not filled in!";
                objct = txtPostalNumber;
                return wrongWritten;
            }

            if (txtCity.Text == "")
            {
                wrongWritten = true;
                errorMessage = "City not filled in!";
                objct = txtCity;
                return wrongWritten;
            }

            if (txtPhoneNumer.Text == "")
            {
                wrongWritten = true;
                errorMessage = "txtPhonenumer not filled in!";
                objct = txtPhoneNumer;
                return wrongWritten;
            }

            return wrongWritten;

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            RegisterPatients.ActiveForm.Close();
        }


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

        //private void chkFemale_Click(object sender, EventArgs e)
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

        private void chkMale_Click(object sender, EventArgs e)
        {
            chkMale.Checked = true;
            chkFemale.Checked = false;
        }

        private void chkFemale_Click(object sender, EventArgs e)
        {
            chkFemale.Checked = true;
            chkMale.Checked = false;
        }
    }
}
