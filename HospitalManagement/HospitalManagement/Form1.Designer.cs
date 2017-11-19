namespace HospitalManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStaffPosition = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.cmbPermissions = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoPatient = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblWelcomeStaff = new System.Windows.Forms.Label();
            this.pnlEmpty = new System.Windows.Forms.Panel();
            this.lblUpptPatient = new System.Windows.Forms.Label();
            this.txtPersN1UpdPat = new System.Windows.Forms.TextBox();
            this.btnGetPatient = new System.Windows.Forms.Button();
            this.pnlSetVisitingHours = new System.Windows.Forms.Panel();
            this.lblSetVisitHour = new System.Windows.Forms.Label();
            this.pnlPatientsRecep = new System.Windows.Forms.Panel();
            this.lblRegisPatient = new System.Windows.Forms.Label();
            this.btnRegisPatient = new System.Windows.Forms.Button();
            this.lblUppdPatJournal = new System.Windows.Forms.Label();
            this.txtPersN2UpdJour = new System.Windows.Forms.TextBox();
            this.btnUppdPatJournal = new System.Windows.Forms.Button();
            this.pnlSetAppointHour = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMedicalHistory = new System.Windows.Forms.Panel();
            this.pnlPrescriptions = new System.Windows.Forms.Panel();
            this.lblPrescriptions = new System.Windows.Forms.Label();
            this.lblMedicalHistory = new System.Windows.Forms.Label();
            this.pnlPatientsDoctor = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRegisPatTest = new System.Windows.Forms.Label();
            this.pnlRegisPatientRecep = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlEmpty.SuspendLayout();
            this.pnlSetVisitingHours.SuspendLayout();
            this.pnlPatientsRecep.SuspendLayout();
            this.pnlSetAppointHour.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMedicalHistory.SuspendLayout();
            this.pnlPrescriptions.SuspendLayout();
            this.pnlPatientsDoctor.SuspendLayout();
            this.pnlRegisPatientRecep.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStaffPosition
            // 
            this.lblStaffPosition.AutoSize = true;
            this.lblStaffPosition.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPosition.Location = new System.Drawing.Point(174, 8);
            this.lblStaffPosition.Name = "lblStaffPosition";
            this.lblStaffPosition.Size = new System.Drawing.Size(0, 18);
            this.lblStaffPosition.TabIndex = 7;
            this.lblStaffPosition.UseCompatibleTextRendering = true;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(71, 11);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(0, 15);
            this.lblStaffName.TabIndex = 6;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedInAs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(789, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(86, 17);
            this.lblLoggedInAs.TabIndex = 8;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // lblEmpty
            // 
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.Location = new System.Drawing.Point(881, -3);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(98, 20);
            this.lblEmpty.TabIndex = 9;
            // 
            // cmbPermissions
            // 
            this.cmbPermissions.FormattingEnabled = true;
            this.cmbPermissions.Location = new System.Drawing.Point(864, 84);
            this.cmbPermissions.Name = "cmbPermissions";
            this.cmbPermissions.Size = new System.Drawing.Size(173, 21);
            this.cmbPermissions.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblNoPatient);
            this.panel1.Controls.Add(this.lblLoggedInAs);
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.lblWelcomeStaff);
            this.panel1.Controls.Add(this.cmbPermissions);
            this.panel1.Controls.Add(this.lblEmpty);
            this.panel1.Controls.Add(this.lblStaffName);
            this.panel1.Controls.Add(this.lblStaffPosition);
            this.panel1.Location = new System.Drawing.Point(24, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 47);
            this.panel1.TabIndex = 11;
            // 
            // lblNoPatient
            // 
            this.lblNoPatient.AutoSize = true;
            this.lblNoPatient.Location = new System.Drawing.Point(861, 122);
            this.lblNoPatient.Name = "lblNoPatient";
            this.lblNoPatient.Size = new System.Drawing.Size(0, 13);
            this.lblNoPatient.TabIndex = 20;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(864, 55);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(115, 23);
            this.btnChoose.TabIndex = 21;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // lblWelcomeStaff
            // 
            this.lblWelcomeStaff.AutoSize = true;
            this.lblWelcomeStaff.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeStaff.Location = new System.Drawing.Point(3, 8);
            this.lblWelcomeStaff.Name = "lblWelcomeStaff";
            this.lblWelcomeStaff.Size = new System.Drawing.Size(62, 16);
            this.lblWelcomeStaff.TabIndex = 10;
            this.lblWelcomeStaff.Text = "Welcome";
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlEmpty.Controls.Add(this.pnlMedicalHistory);
            this.pnlEmpty.Location = new System.Drawing.Point(1040, 1);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.Size = new System.Drawing.Size(615, 318);
            this.pnlEmpty.TabIndex = 11;
            // 
            // lblUpptPatient
            // 
            this.lblUpptPatient.AutoSize = true;
            this.lblUpptPatient.Location = new System.Drawing.Point(26, 131);
            this.lblUpptPatient.Name = "lblUpptPatient";
            this.lblUpptPatient.Size = new System.Drawing.Size(84, 13);
            this.lblUpptPatient.TabIndex = 25;
            this.lblUpptPatient.Text = "Uppdate Patient";
            // 
            // txtPersN1UpdPat
            // 
            this.txtPersN1UpdPat.Location = new System.Drawing.Point(29, 158);
            this.txtPersN1UpdPat.Name = "txtPersN1UpdPat";
            this.txtPersN1UpdPat.Size = new System.Drawing.Size(100, 20);
            this.txtPersN1UpdPat.TabIndex = 25;
            // 
            // btnGetPatient
            // 
            this.btnGetPatient.Location = new System.Drawing.Point(145, 155);
            this.btnGetPatient.Name = "btnGetPatient";
            this.btnGetPatient.Size = new System.Drawing.Size(115, 23);
            this.btnGetPatient.TabIndex = 20;
            this.btnGetPatient.Text = "Get Patient";
            this.btnGetPatient.UseVisualStyleBackColor = true;
            this.btnGetPatient.Click += new System.EventHandler(this.btnGetPatient_Click);
            // 
            // pnlSetVisitingHours
            // 
            this.pnlSetVisitingHours.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlSetVisitingHours.Controls.Add(this.pnlSetAppointHour);
            this.pnlSetVisitingHours.Controls.Add(this.lblSetVisitHour);
            this.pnlSetVisitingHours.Location = new System.Drawing.Point(2, 48);
            this.pnlSetVisitingHours.Name = "pnlSetVisitingHours";
            this.pnlSetVisitingHours.Size = new System.Drawing.Size(610, 312);
            this.pnlSetVisitingHours.TabIndex = 11;
            // 
            // lblSetVisitHour
            // 
            this.lblSetVisitHour.AutoSize = true;
            this.lblSetVisitHour.Location = new System.Drawing.Point(30, 14);
            this.lblSetVisitHour.Name = "lblSetVisitHour";
            this.lblSetVisitHour.Size = new System.Drawing.Size(90, 13);
            this.lblSetVisitHour.TabIndex = 0;
            this.lblSetVisitHour.Text = "Set Visiting Hours";
            // 
            // pnlPatientsRecep
            // 
            this.pnlPatientsRecep.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlPatientsRecep.Controls.Add(this.lblUpptPatient);
            this.pnlPatientsRecep.Controls.Add(this.txtPersN1UpdPat);
            this.pnlPatientsRecep.Controls.Add(this.btnGetPatient);
            this.pnlPatientsRecep.Controls.Add(this.lblRegisPatient);
            this.pnlPatientsRecep.Controls.Add(this.btnRegisPatient);
            this.pnlPatientsRecep.Location = new System.Drawing.Point(264, 21);
            this.pnlPatientsRecep.Name = "pnlPatientsRecep";
            this.pnlPatientsRecep.Size = new System.Drawing.Size(611, 313);
            this.pnlPatientsRecep.TabIndex = 16;
            // 
            // lblRegisPatient
            // 
            this.lblRegisPatient.AutoSize = true;
            this.lblRegisPatient.Location = new System.Drawing.Point(28, 16);
            this.lblRegisPatient.Name = "lblRegisPatient";
            this.lblRegisPatient.Size = new System.Drawing.Size(82, 13);
            this.lblRegisPatient.TabIndex = 24;
            this.lblRegisPatient.Text = "Register Patient";
            // 
            // btnRegisPatient
            // 
            this.btnRegisPatient.Location = new System.Drawing.Point(31, 57);
            this.btnRegisPatient.Name = "btnRegisPatient";
            this.btnRegisPatient.Size = new System.Drawing.Size(104, 23);
            this.btnRegisPatient.TabIndex = 24;
            this.btnRegisPatient.Text = "Register Patient";
            this.btnRegisPatient.UseVisualStyleBackColor = true;
            this.btnRegisPatient.Click += new System.EventHandler(this.btnRegisPatient_Click);
            // 
            // lblUppdPatJournal
            // 
            this.lblUppdPatJournal.AutoSize = true;
            this.lblUppdPatJournal.Location = new System.Drawing.Point(28, 122);
            this.lblUppdPatJournal.Name = "lblUppdPatJournal";
            this.lblUppdPatJournal.Size = new System.Drawing.Size(121, 13);
            this.lblUppdPatJournal.TabIndex = 2;
            this.lblUppdPatJournal.Text = "Uppdate Patient Journal";
            // 
            // txtPersN2UpdJour
            // 
            this.txtPersN2UpdJour.Location = new System.Drawing.Point(29, 152);
            this.txtPersN2UpdJour.Name = "txtPersN2UpdJour";
            this.txtPersN2UpdJour.Size = new System.Drawing.Size(100, 20);
            this.txtPersN2UpdJour.TabIndex = 23;
            // 
            // btnUppdPatJournal
            // 
            this.btnUppdPatJournal.Location = new System.Drawing.Point(149, 150);
            this.btnUppdPatJournal.Name = "btnUppdPatJournal";
            this.btnUppdPatJournal.Size = new System.Drawing.Size(104, 23);
            this.btnUppdPatJournal.TabIndex = 22;
            this.btnUppdPatJournal.Text = "Uppdate Journal";
            this.btnUppdPatJournal.UseVisualStyleBackColor = true;
            this.btnUppdPatJournal.Click += new System.EventHandler(this.btnUppdPatJournal_Click);
            // 
            // pnlSetAppointHour
            // 
            this.pnlSetAppointHour.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlSetAppointHour.Controls.Add(this.pnlPrescriptions);
            this.pnlSetAppointHour.Controls.Add(this.label4);
            this.pnlSetAppointHour.Location = new System.Drawing.Point(3, 43);
            this.pnlSetAppointHour.Name = "pnlSetAppointHour";
            this.pnlSetAppointHour.Size = new System.Drawing.Size(610, 312);
            this.pnlSetAppointHour.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Set Appointement Hours";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.pnlPatientsRecep);
            this.panel2.Controls.Add(this.pnlPatientsDoctor);
            this.panel2.Controls.Add(this.pnlRegisPatientRecep);
            this.panel2.Location = new System.Drawing.Point(24, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 436);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlMedicalHistory
            // 
            this.pnlMedicalHistory.BackColor = System.Drawing.Color.Orange;
            this.pnlMedicalHistory.Controls.Add(this.pnlSetVisitingHours);
            this.pnlMedicalHistory.Controls.Add(this.lblMedicalHistory);
            this.pnlMedicalHistory.Location = new System.Drawing.Point(3, 34);
            this.pnlMedicalHistory.Name = "pnlMedicalHistory";
            this.pnlMedicalHistory.Size = new System.Drawing.Size(615, 318);
            this.pnlMedicalHistory.TabIndex = 12;
            // 
            // pnlPrescriptions
            // 
            this.pnlPrescriptions.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlPrescriptions.Controls.Add(this.lblPrescriptions);
            this.pnlPrescriptions.Location = new System.Drawing.Point(0, 65);
            this.pnlPrescriptions.Name = "pnlPrescriptions";
            this.pnlPrescriptions.Size = new System.Drawing.Size(615, 318);
            this.pnlPrescriptions.TabIndex = 12;
            // 
            // lblPrescriptions
            // 
            this.lblPrescriptions.AutoSize = true;
            this.lblPrescriptions.Location = new System.Drawing.Point(46, 31);
            this.lblPrescriptions.Name = "lblPrescriptions";
            this.lblPrescriptions.Size = new System.Drawing.Size(67, 13);
            this.lblPrescriptions.TabIndex = 0;
            this.lblPrescriptions.Text = "Prescriptions";
            // 
            // lblMedicalHistory
            // 
            this.lblMedicalHistory.AutoSize = true;
            this.lblMedicalHistory.Location = new System.Drawing.Point(52, 16);
            this.lblMedicalHistory.Name = "lblMedicalHistory";
            this.lblMedicalHistory.Size = new System.Drawing.Size(79, 13);
            this.lblMedicalHistory.TabIndex = 27;
            this.lblMedicalHistory.Text = "Medical History";
            // 
            // pnlPatientsDoctor
            // 
            this.pnlPatientsDoctor.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlPatientsDoctor.Controls.Add(this.lblUppdPatJournal);
            this.pnlPatientsDoctor.Controls.Add(this.txtPersN2UpdJour);
            this.pnlPatientsDoctor.Controls.Add(this.btnUppdPatJournal);
            this.pnlPatientsDoctor.Location = new System.Drawing.Point(693, 355);
            this.pnlPatientsDoctor.Name = "pnlPatientsDoctor";
            this.pnlPatientsDoctor.Size = new System.Drawing.Size(611, 313);
            this.pnlPatientsDoctor.TabIndex = 27;
            // 
            // lblRegisPatTest
            // 
            this.lblRegisPatTest.AutoSize = true;
            this.lblRegisPatTest.Location = new System.Drawing.Point(28, 16);
            this.lblRegisPatTest.Name = "lblRegisPatTest";
            this.lblRegisPatTest.Size = new System.Drawing.Size(248, 13);
            this.lblRegisPatTest.TabIndex = 24;
            this.lblRegisPatTest.Text = "Testing Register Patient in panel instead of window";
            // 
            // pnlRegisPatientRecep
            // 
            this.pnlRegisPatientRecep.BackColor = System.Drawing.Color.Tan;
            this.pnlRegisPatientRecep.Controls.Add(this.lblRegisPatTest);
            this.pnlRegisPatientRecep.Location = new System.Drawing.Point(335, 21);
            this.pnlRegisPatientRecep.Name = "pnlRegisPatientRecep";
            this.pnlRegisPatientRecep.Size = new System.Drawing.Size(611, 313);
            this.pnlRegisPatientRecep.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1300, 686);
            this.Controls.Add(this.pnlEmpty);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEmpty.ResumeLayout(false);
            this.pnlSetVisitingHours.ResumeLayout(false);
            this.pnlSetVisitingHours.PerformLayout();
            this.pnlPatientsRecep.ResumeLayout(false);
            this.pnlPatientsRecep.PerformLayout();
            this.pnlSetAppointHour.ResumeLayout(false);
            this.pnlSetAppointHour.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlMedicalHistory.ResumeLayout(false);
            this.pnlMedicalHistory.PerformLayout();
            this.pnlPrescriptions.ResumeLayout(false);
            this.pnlPrescriptions.PerformLayout();
            this.pnlPatientsDoctor.ResumeLayout(false);
            this.pnlPatientsDoctor.PerformLayout();
            this.pnlRegisPatientRecep.ResumeLayout(false);
            this.pnlRegisPatientRecep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStaffPosition;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.ComboBox cmbPermissions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcomeStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNoPatient;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Panel pnlEmpty;
        private System.Windows.Forms.Label lblUpptPatient;
        private System.Windows.Forms.TextBox txtPersN1UpdPat;
        private System.Windows.Forms.Button btnGetPatient;
        private System.Windows.Forms.Panel pnlPatientsRecep;
        private System.Windows.Forms.Label lblRegisPatient;
        private System.Windows.Forms.Button btnRegisPatient;
        private System.Windows.Forms.Label lblUppdPatJournal;
        private System.Windows.Forms.TextBox txtPersN2UpdJour;
        private System.Windows.Forms.Button btnUppdPatJournal;
        private System.Windows.Forms.Panel pnlSetAppointHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSetVisitingHours;
        private System.Windows.Forms.Label lblSetVisitHour;
        private System.Windows.Forms.Panel pnlPatientsDoctor;
        private System.Windows.Forms.Panel pnlMedicalHistory;
        private System.Windows.Forms.Label lblMedicalHistory;
        private System.Windows.Forms.Panel pnlPrescriptions;
        private System.Windows.Forms.Label lblPrescriptions;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlRegisPatientRecep;
        private System.Windows.Forms.Label lblRegisPatTest;
    }
}