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
    public partial class UpdatePatient : Form
    {
        Patient updatePatient = new Patient();

        const int MiniPersNumber = 19000101;
        const int MaxPersNumber = 20171231;

        private string errorMessage = "";
        Control objct;


        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {
            updatePatient = Form1.myPatient;

            txtPersnNumber.Text = updatePatient.PersonNumber; // Borde inte den vara icke-updaterbar? Att inte inkludera i listan. El göra dess knapp inactive.
            txtFirstName.Text = updatePatient.FirstName;
            txtLastName.Text = updatePatient.LastName;
            txtAddress.Text = updatePatient.Address;
            txtPostalNumber.Text = updatePatient.PostalNumber;
            txtCity.Text = updatePatient.City;
            txtPhoneNumer.Text = updatePatient.PhoneNumber;
            txtEmail.Text = updatePatient.EMail;

            if (updatePatient.Gender == 'M')
            {
                chkMale.Checked = true;
                chkFemale.Checked = false;
            }
            else
            {
                chkFemale.Checked = true;
                chkMale.Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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

                updatePatient.FirstName = txtFirstName.Text;
                updatePatient.LastName = txtLastName.Text;
                updatePatient.Address = txtAddress.Text;
                updatePatient.PostalNumber = txtPostalNumber.Text;
                updatePatient.City = txtCity.Text;
                updatePatient.PhoneNumber = txtPhoneNumer.Text;
                updatePatient.EMail = txtEmail.Text;

                if (DBAccess.InsertUpdatePatient(updatePatient, 'U'))
                {
                    MessageBox.Show("Patient updated successfully!");
                }
                else
                {
                    MessageBox.Show("Computer says No..."); // -- Failed to update patient.
                }
            }

        }

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
                errorMessage = "Person-number is wrongly typed! \nUse format: ÅÅÅÅMMDD-XXXX";
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
                errorMessage = "Person-number is wrongly typed! \nUse format: ÅÅÅÅMMDD-XXXX";
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
                errorMessage = "Person-number is wrongly typed! \nUse format: ÅÅÅÅMMDD-XXXX";
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
    }
}
