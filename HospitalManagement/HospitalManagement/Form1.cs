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
            dsPermissions = DBAccess.GetRolesPermission("Doctor");
            int posts = dsPermissions.Tables[0].Rows.Count;

            for (int i = 0; i < posts; i++)
            {
                Button btnPermissionBtn = new Button();
                btnPermissionBtn.Size = new Size(130, 23);
                btnPermissionBtn.Location = new Point(160, 30 * i + 10);
                btnPermissionBtn.Click += new EventHandler(ButtonClickOneEvent); // Ask jan about this
                btnPermissionBtn.Tag = i; // Ask Jan about this
                btnPermissionBtn.Text = dsPermissions.Tables[0].Rows[i][0].ToString(); // MORE QUESTIONS!
                this.Controls.Add(btnPermissionBtn);

            }


        }



        private void Form1_Load(object sender, EventArgs e)

        {
            lblEmpty.Text = Convert.ToString(LoginStaff.userID);   // Data placeras i labelxx
                                                                  //label2.Text = Login.skurk.FName;   //fångar upp data från LoginForm
                                                                  //label3.Text = Login.sjuk.bilen.Fabrikat;  //fångar upp data från LoginForm

            /*pnlEmpty.BringToFront();*/ //-- Create empty panel as front.
                                         //Comment in other panels aswell when GUI is set

            //Databasacccess här för att hämta info om inloggad
            DataSet dsUserInfo = new DataSet();
            dsUserInfo = DBAccess.GetUserInformation(LoginStaff.userID);
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
            row["Permission"] = "";                     //insert a blank row - you can even write something like = "Please select bellow...";
            dsPermissions.Tables[0].Rows.InsertAt(row, 0); //insert new row to index 0 (on top=0)
            cmbPermissions.SelectedIndex = 0;


            lblNoPatient.Text = "";  // --Comment in

            //Gör en Person-patient-personal klass
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
                case "Set Visiting Hours":
                    //pnlEmpty.SendToBack();
                    pnlSetVisitingHours.BringToFront();
                    break;
                case "Set Appointment Hours":
                    //pnlEmpty.SendToBack();
                    pnlSetAppointHour.BringToFront();
                    break;
                case "Update Patients Journal":
                    //pnlEmpty.SendToBack();
                    pnlUppPatJournal.BringToFront();
                    break;
                case "Register Patients":
                    //pnlEmpty.SendToBack();
                    pnlRegisPatient.BringToFront();
                    break;
                case "Update Patients Information":
                    //pnlEmpty.SendToBack();
                    pnlUpptPatient.BringToFront();
                    break;
                case "Create Patients Journal":
                    //pnlEmpty.SendToBack();
                    pnlCreatePatJournal.BringToFront();
                    break;
            }



        }

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


        }

        private void btnRegisPatient_Click(object sender, EventArgs e)
        {
            RegisterPatients frmRegisterPatients = new RegisterPatients();
            frmRegisterPatients.Show();

        }

        void ButtonClickOneEvent(object sender, EventArgs e)
        {
            Button btnPermissionBtn = sender as Button;
            if (btnPermissionBtn != null)
            {
                //switch ((int)btnPermissionBtn.Tag) // ??
                //{
                //    case 0:
                //        //pnlEmpty.SendToBack();
                //        pnlSetVisitingHours.BringToFront();
                //        break;
                //    case 1:
                //        //pnlEmpty.SendToBack();
                //        pnlSetAppointHour.BringToFront();
                //        break;
                //    case 2:
                //        //pnlEmpty.SendToBack();
                //        pnlUppPatJournal.BringToFront();
                //        break;
                //    case 3:
                //        //pnlEmpty.SendToBack();
                //        pnlRegisPatient.BringToFront();
                //        break;
                //    case 4:
                //        //pnlEmpty.SendToBack();
                //        pnlUpptPatient.BringToFront();
                //        break;
                //    case 5:
                //        //pnlEmpty.SendToBack();
                //        pnlCreatePatJournal.BringToFront();
                //        break;


                //}

                switch ((int)btnPermissionBtn.Tag) // ??
                {
                    case 1:
                        //pnlEmpty.SendToBack();
                        panel3.BringToFront();
                        break;
                    case 2:
                        //pnlEmpty.SendToBack();
                        panel9.BringToFront();
                        break;
                    case 3:
                        //pnlEmpty.SendToBack();
                        panel7.BringToFront();
                        break;
                    case 4:
                        //pnlEmpty.SendToBack();
                        panel4.BringToFront();
                        break;
                    //case "Patient":
                    //    //pnlEmpty.SendToBack();
                    //    pnlUpptPatient.BringToFront();
                    //    break;
                    //case 5:
                    //    //pnlEmpty.SendToBack();
                    //    pnlCreatePatJournal.BringToFront();
                    //    break;


                }
            }
        }





        // FAILED ATTEMPTS


        //MenuStrip menuStrpRolePermission = new MenuStrip();

        //toolStripMenuItem1 = toolStripMenuItem1;
        //Controls.Add(menuStrpRolePermission);

        //MainMenuStrip.Name = "menuStrip2";

        //ToolStripMenuItem FileMenu = new ToolStripMenuItem("File");




        //menuStrpRolePermission.

        //List<string> menuItems = DBAccess.GetRolesPermission(Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]));
        //ContextMenuStrip menuStrpRolePermission = new ContextMenuStrip();

        //foreach (var menuItem in menuItems)
        //{
        //    MenuItem item = new MenuItem(menuItem);
        //    item.Text = menuItem;
        //    item.Click += new EventHandler(item_Click);// item_click is event handler name
        //                                                item.MenuItems.Add(); you could use this to add sub items
        //}

        //panel1.Controls.Add(menu);


        //Gör en Person-patient-personal klass



        //cmbPermissions.Items.Clear();

        //dsPermissions = DBAccess.GetRolesPermission(Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]));
        //cmbPermissions.DataSource = dsPermissions.Tables[0];
        //cmbPermissions.DisplayMember = "Permission";

        //    public void PrintPermissions(DataSet dsPermissions)
        //    {
        //        // For each table in the DataSet, print the values of each row.
        //        foreach (DataTable menStrpPermissions in dsPermissions.Tables)
        //        {
        //            // For each row, print the values of each column.
        //            foreach (DataRow toolStripComboBox in menStrpPermissions.Rows)
        //            {
        //                foreach (DataColumn column in menStrpPermissions.Columns)
        //                {
        //                    Console.WriteLine(toolStripComboBox[column]);
        //                }
        //            }
        //        }
        //    }

        //    public void AddARow(DataSet dsPermissions)
        //    {
        //        DataTable table;
        //        table = dsPermissions.Tables["Permissions"];
        //        // Use the NewRow method to create a DataRow with 
        //        // the table's schema.
        //        DataRow newRow = table.NewRow();

        //        // Set values in the columns:
        //        newRow["Permission"] = DBAccess.GetRolesPermission(Convert.ToString(dsPermissions.Tables[0].Rows[0][2])); 
        //        newRow["CompanyName"] = "NewCompanyName";

        //        // Add the row to the rows collection.
        //        table.Rows.Add(newRow);
        //    }

        //}

        //public void PrintPermissions(DataSet dsPermissions)
        //{
        //    string menStrpPermissions = "Permission";




        //    // For each table in the DataSet, print the values of each row.
        //    foreach (string p in dsPermissions.Tables[0].Rows) /*ToolStripItem.ToolStripItemAccessibleObject.DropDownI)*/
        //    {
        //        // For each row, print the values of each column.
        //        //foreach (DataRow toolStripComboBox in menStrpPermissions.Rows)
        //        //{
        //        //    //foreach (DataColumn column in menStrpPermissions.Columns)
        //        //    //{
        //        //    //    Console.WriteLine(toolStripComboBox[column]);
        //        //    //}
        //        //}
        //    }
        //}


        //private void BtnChoose_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //        string choice = Convert.ToString(cmbPermissions.SelectedValue);

        //private void btnChoose_Click(object sender, EventArgs e)
        //{
        //    string choice = (cmbPermissions.Text);

        //    if (choice == "Set Appointment Hours") //"Set Visiting Hours" Ändra till korrekt om rätt
        //        {
        //            PnlDoc1.BringToFront();
        //            //pnlDoc01.Visible = false;s
        //            //pnlDoc02.Visible = true;
        //        }
        //        if (choice == "Register Patients")
        //        {
        //            PnlDoc2.BringToFront();
        //            //pnlDoc02.Visible = false;
        //            //pnlDoc01.Visible = true;
        //        }
        //        if (choice == "Create Patients Journal") // "Update patients journal" Ändra till korrekt om rätt
        //    {
        //            PnlDoc3.BringToFront();
        //            //pnlDoc02.Visible = false;
        //            //pnlDoc01.Visible = true;
        //        }
        //    }

        // AWE - Different View panelt. - ALTER and put into current design

        //// Test for Receptionist
        //private void btnChoose_Click(object sender, EventArgs e)
        //{
        //    string choice = (cmbPermissions.Text);

        //    if ((choice == "Register Patients") || (choice == "Create Patients Journal") || (choice == "Release Patients"))
        //    {
        //        PnlDoc1.BringToFront();
        //        //pnlDoc01.Visible = false;s
        //        //pnlDoc02.Visible = true;
        //    }
        //    if ((choice == "Set Patient’s Appointments With Doctors") || (choice == "Search All The Doctors") || (choice == "Search All The Patients And Their Status"))
        //    {
        //        PnlDoc2.BringToFront();
        //        //pnlDoc02.Visible = false;
        //        //pnlDoc01.Visible = true;
        //    }
        //    if ((choice == "View The Prescriptions") || (choice == "View The Duty Schedule") || (choice == "View Patients Room"))
        //    {
        //        PnlDoc3.BringToFront();
        //        //pnlDoc02.Visible = false;
        //        //pnlDoc01.Visible = true;
        //    }
        //    if ((choice == "Register Patients"))
        //    {
        //        PnlDoc4.BringToFront();
        //        //pnlDoc02.Visible = false;
        //        //pnlDoc01.Visible = true;
        //    }
        //}

    }

}



