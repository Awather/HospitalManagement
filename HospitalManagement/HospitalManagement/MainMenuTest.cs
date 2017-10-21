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
    public partial class MainMenuTest : Form
    {
        private DataSet dsPermissions = new DataSet();

        public MainMenuTest()
        {
            InitializeComponent();
        }

        //private void MainMenu_Load(object sender, EventArgs e)
        //{
        //    lblEmpty.Text = Convert.ToString(Login.userID);  // Data placeras i label
        //}

        private void MainMenuTest_Load(object sender, EventArgs e)
        {
            lblEmpty.Text = Convert.ToString(LoginTest.userID);   // Data placeras i labelxx
                                                              //label2.Text = Login.skurk.FName;   //fångar upp data från LoginForm
                                                              //label3.Text = Login.sjuk.bilen.Fabrikat;  //fångar upp data från LoginForm


            //Databasacccess här för att hämta info om inloggad
            DataSet dsUserInfo = new DataSet();
            dsUserInfo = DBAccess.GetUserInformation(LoginTest.userID);
            label2.Text = Convert.ToString(dsUserInfo.Tables[0].Rows[0][0]) + " " + Convert.ToString(dsUserInfo.Tables[0].Rows[0][1]);
            label3.Text = Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]) + " at " + Convert.ToString(dsUserInfo.Tables[0].Rows[0][3]);



            // AWE - Dropdown box for staff permissions - Change to MenuStrip

            //Databasaccess här för att hämta permissions för denna user och lägga i en dropdown eller i annat
            //Här fylls en dropdown med permissions för denna user
            //cmbPermissions.Items.Clear();

            dsPermissions = DBAccess.GetRolesPermission(Convert.ToString(dsUserInfo.Tables[0].Rows[0][2]));
            //cmbPermissions.DataSource = menuStrpRolePermission.Tables[0];
            //cmbPermissions.DisplayMember = "Permission";
            ////vill ha blankrad som första rad
            //DataRow row = menuStrpRolePermission.Tables[0].NewRow();
            //row["Permission"] = "-- Select --";                     //insert a blank row - you can even write something like = "Please select bellow...";
            //menuStrpRolePermission.Tables[0].Rows.InsertAt(row, 0); //insert new row to index 0 (on top=0)
            //cmbPermissions.SelectedIndex = 0;


            MenuStrip menuStrpRolePermission = new MenuStrip();

            this.MainMenuStrip = menuStrpRolePermission;
            Controls.Add(menuStrpRolePermission);

            MainMenuStrip.Name = "menuStrip2";

            ToolStripMenuItem FileMenu = new ToolStripMenuItem("File");

           


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
        }

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

