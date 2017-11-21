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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlUpdPatientRecep = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnLogoutStaff = new System.Windows.Forms.Button();
            this.pnlRegisPatientRecep = new System.Windows.Forms.Panel();
            this.pnlPatientsRecep = new System.Windows.Forms.Panel();
            this.lblUpptPatient = new System.Windows.Forms.Label();
            this.btnGetPatient = new System.Windows.Forms.Button();
            this.txtPersN1UpdPat = new System.Windows.Forms.TextBox();
            this.lblGetPatStatusRecep = new System.Windows.Forms.Label();
            this.btnRegisPatient = new System.Windows.Forms.Button();
            this.pnlEmpty = new System.Windows.Forms.Panel();
            this.pnlMedicalHistory = new System.Windows.Forms.Panel();
            this.pnlSetVisitingHours = new System.Windows.Forms.Panel();
            this.pnlSetAppointHour = new System.Windows.Forms.Panel();
            this.pnlPrescriptions = new System.Windows.Forms.Panel();
            this.lblPrescriptions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSetVisitHour = new System.Windows.Forms.Label();
            this.lblMedicalHistory = new System.Windows.Forms.Label();
            this.lblUppdPatJournal = new System.Windows.Forms.Label();
            this.txtPersN2UpdJour = new System.Windows.Forms.TextBox();
            this.btnUppdPatJournal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPatientsDoctor = new System.Windows.Forms.Panel();
            this.lblPatInfoRecep = new System.Windows.Forms.Label();
            this.txtGetPatStatus = new System.Windows.Forms.TextBox();
            this.lblGetPerscriptionRecep = new System.Windows.Forms.Label();
            this.txtGetPerscripInfoRecep = new System.Windows.Forms.TextBox();
            this.btnGetPerscripInfoRecep = new System.Windows.Forms.Button();
            this.btnGetPatStatus = new System.Windows.Forms.Button();
            this.txtRecepPatDecsrip = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlPatientsRecep.SuspendLayout();
            this.pnlEmpty.SuspendLayout();
            this.pnlMedicalHistory.SuspendLayout();
            this.pnlSetVisitingHours.SuspendLayout();
            this.pnlSetAppointHour.SuspendLayout();
            this.pnlPrescriptions.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPatientsDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStaffPosition
            // 
            this.lblStaffPosition.AutoSize = true;
            this.lblStaffPosition.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPosition.Location = new System.Drawing.Point(21, 29);
            this.lblStaffPosition.Name = "lblStaffPosition";
            this.lblStaffPosition.Size = new System.Drawing.Size(0, 18);
            this.lblStaffPosition.TabIndex = 7;
            this.lblStaffPosition.UseCompatibleTextRendering = true;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(21, 8);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(0, 15);
            this.lblStaffName.TabIndex = 6;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedInAs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(736, 8);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(86, 17);
            this.lblLoggedInAs.TabIndex = 8;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // lblEmpty
            // 
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.Location = new System.Drawing.Point(819, 7);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(82, 20);
            this.lblEmpty.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblStaffName);
            this.panel1.Controls.Add(this.lblStaffPosition);
            this.panel1.Controls.Add(this.btnLogoutStaff);
            this.panel1.Controls.Add(this.lblLoggedInAs);
            this.panel1.Controls.Add(this.lblEmpty);
            this.panel1.Location = new System.Drawing.Point(24, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 58);
            this.panel1.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(901, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 20);
            this.lblTime.TabIndex = 29;
            // 
            // pnlUpdPatientRecep
            // 
            this.pnlUpdPatientRecep.BackColor = System.Drawing.Color.Bisque;
            this.pnlUpdPatientRecep.Location = new System.Drawing.Point(331, 44);
            this.pnlUpdPatientRecep.Name = "pnlUpdPatientRecep";
            this.pnlUpdPatientRecep.Size = new System.Drawing.Size(504, 471);
            this.pnlUpdPatientRecep.TabIndex = 27;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(740, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 20);
            this.lblDate.TabIndex = 28;
            // 
            // btnLogoutStaff
            // 
            this.btnLogoutStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutStaff.Location = new System.Drawing.Point(904, 5);
            this.btnLogoutStaff.Name = "btnLogoutStaff";
            this.btnLogoutStaff.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutStaff.TabIndex = 0;
            this.btnLogoutStaff.Text = "Log out";
            this.btnLogoutStaff.UseVisualStyleBackColor = true;
            this.btnLogoutStaff.Click += new System.EventHandler(this.btnLogoutStaff_Click);
            // 
            // pnlRegisPatientRecep
            // 
            this.pnlRegisPatientRecep.BackColor = System.Drawing.Color.Bisque;
            this.pnlRegisPatientRecep.Location = new System.Drawing.Point(331, 44);
            this.pnlRegisPatientRecep.Name = "pnlRegisPatientRecep";
            this.pnlRegisPatientRecep.Size = new System.Drawing.Size(504, 471);
            this.pnlRegisPatientRecep.TabIndex = 26;
            // 
            // pnlPatientsRecep
            // 
            this.pnlPatientsRecep.BackColor = System.Drawing.Color.Bisque;
            this.pnlPatientsRecep.Controls.Add(this.txtRecepPatDecsrip);
            this.pnlPatientsRecep.Controls.Add(this.pnlRegisPatientRecep);
            this.pnlPatientsRecep.Controls.Add(this.btnGetPatStatus);
            this.pnlPatientsRecep.Controls.Add(this.pnlUpdPatientRecep);
            this.pnlPatientsRecep.Controls.Add(this.btnGetPerscripInfoRecep);
            this.pnlPatientsRecep.Controls.Add(this.txtGetPerscripInfoRecep);
            this.pnlPatientsRecep.Controls.Add(this.lblGetPerscriptionRecep);
            this.pnlPatientsRecep.Controls.Add(this.txtGetPatStatus);
            this.pnlPatientsRecep.Controls.Add(this.lblPatInfoRecep);
            this.pnlPatientsRecep.Controls.Add(this.lblUpptPatient);
            this.pnlPatientsRecep.Controls.Add(this.btnGetPatient);
            this.pnlPatientsRecep.Controls.Add(this.txtPersN1UpdPat);
            this.pnlPatientsRecep.Controls.Add(this.lblGetPatStatusRecep);
            this.pnlPatientsRecep.Controls.Add(this.btnRegisPatient);
            this.pnlPatientsRecep.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlPatientsRecep.Location = new System.Drawing.Point(141, 3);
            this.pnlPatientsRecep.Name = "pnlPatientsRecep";
            this.pnlPatientsRecep.Size = new System.Drawing.Size(838, 527);
            this.pnlPatientsRecep.TabIndex = 16;
            // 
            // lblUpptPatient
            // 
            this.lblUpptPatient.AutoSize = true;
            this.lblUpptPatient.Location = new System.Drawing.Point(26, 230);
            this.lblUpptPatient.Name = "lblUpptPatient";
            this.lblUpptPatient.Size = new System.Drawing.Size(84, 13);
            this.lblUpptPatient.TabIndex = 25;
            this.lblUpptPatient.Text = "Uppdate Patient";
            // 
            // btnGetPatient
            // 
            this.btnGetPatient.Location = new System.Drawing.Point(205, 243);
            this.btnGetPatient.Name = "btnGetPatient";
            this.btnGetPatient.Size = new System.Drawing.Size(104, 23);
            this.btnGetPatient.TabIndex = 20;
            this.btnGetPatient.Text = "Get Patient";
            this.btnGetPatient.UseVisualStyleBackColor = true;
            this.btnGetPatient.Click += new System.EventHandler(this.btnGetPatient_Click);
            // 
            // txtPersN1UpdPat
            // 
            this.txtPersN1UpdPat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPersN1UpdPat.Location = new System.Drawing.Point(29, 246);
            this.txtPersN1UpdPat.Name = "txtPersN1UpdPat";
            this.txtPersN1UpdPat.Size = new System.Drawing.Size(170, 20);
            this.txtPersN1UpdPat.TabIndex = 25;
            // 
            // lblGetPatStatusRecep
            // 
            this.lblGetPatStatusRecep.AutoSize = true;
            this.lblGetPatStatusRecep.Location = new System.Drawing.Point(29, 321);
            this.lblGetPatStatusRecep.Name = "lblGetPatStatusRecep";
            this.lblGetPatStatusRecep.Size = new System.Drawing.Size(111, 13);
            this.lblGetPatStatusRecep.TabIndex = 24;
            this.lblGetPatStatusRecep.Text = "Get status for patient: ";
            // 
            // btnRegisPatient
            // 
            this.btnRegisPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisPatient.Location = new System.Drawing.Point(26, 38);
            this.btnRegisPatient.Name = "btnRegisPatient";
            this.btnRegisPatient.Size = new System.Drawing.Size(110, 40);
            this.btnRegisPatient.TabIndex = 24;
            this.btnRegisPatient.TabStop = false;
            this.btnRegisPatient.Text = "Register New Patient";
            this.btnRegisPatient.UseVisualStyleBackColor = true;
            this.btnRegisPatient.Click += new System.EventHandler(this.btnRegisPatient_Click);
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
            // pnlSetAppointHour
            // 
            this.pnlSetAppointHour.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlSetAppointHour.Controls.Add(this.label4);
            this.pnlSetAppointHour.Location = new System.Drawing.Point(3, 43);
            this.pnlSetAppointHour.Name = "pnlSetAppointHour";
            this.pnlSetAppointHour.Size = new System.Drawing.Size(610, 312);
            this.pnlSetAppointHour.TabIndex = 12;
            // 
            // pnlPrescriptions
            // 
            this.pnlPrescriptions.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlPrescriptions.Controls.Add(this.lblPrescriptions);
            this.pnlPrescriptions.Location = new System.Drawing.Point(148, 536);
            this.pnlPrescriptions.Name = "pnlPrescriptions";
            this.pnlPrescriptions.Size = new System.Drawing.Size(835, 515);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Set Appointement Hours";
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
            // lblMedicalHistory
            // 
            this.lblMedicalHistory.AutoSize = true;
            this.lblMedicalHistory.Location = new System.Drawing.Point(52, 16);
            this.lblMedicalHistory.Name = "lblMedicalHistory";
            this.lblMedicalHistory.Size = new System.Drawing.Size(79, 13);
            this.lblMedicalHistory.TabIndex = 27;
            this.lblMedicalHistory.Text = "Medical History";
            // 
            // lblUppdPatJournal
            // 
            this.lblUppdPatJournal.AutoSize = true;
            this.lblUppdPatJournal.Location = new System.Drawing.Point(24, 25);
            this.lblUppdPatJournal.Name = "lblUppdPatJournal";
            this.lblUppdPatJournal.Size = new System.Drawing.Size(121, 13);
            this.lblUppdPatJournal.TabIndex = 2;
            this.lblUppdPatJournal.Text = "Uppdate Patient Journal";
            // 
            // txtPersN2UpdJour
            // 
            this.txtPersN2UpdJour.Location = new System.Drawing.Point(25, 55);
            this.txtPersN2UpdJour.Name = "txtPersN2UpdJour";
            this.txtPersN2UpdJour.Size = new System.Drawing.Size(100, 20);
            this.txtPersN2UpdJour.TabIndex = 23;
            // 
            // btnUppdPatJournal
            // 
            this.btnUppdPatJournal.Location = new System.Drawing.Point(145, 53);
            this.btnUppdPatJournal.Name = "btnUppdPatJournal";
            this.btnUppdPatJournal.Size = new System.Drawing.Size(104, 23);
            this.btnUppdPatJournal.TabIndex = 22;
            this.btnUppdPatJournal.Text = "Uppdate Journal";
            this.btnUppdPatJournal.UseVisualStyleBackColor = true;
            this.btnUppdPatJournal.Click += new System.EventHandler(this.btnUppdPatJournal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.pnlPatientsDoctor);
            this.panel2.Controls.Add(this.pnlPrescriptions);
            this.panel2.Controls.Add(this.pnlPatientsRecep);
            this.panel2.Location = new System.Drawing.Point(24, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 591);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlPatientsDoctor
            // 
            this.pnlPatientsDoctor.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlPatientsDoctor.Controls.Add(this.lblUppdPatJournal);
            this.pnlPatientsDoctor.Controls.Add(this.txtPersN2UpdJour);
            this.pnlPatientsDoctor.Controls.Add(this.btnUppdPatJournal);
            this.pnlPatientsDoctor.Location = new System.Drawing.Point(998, 286);
            this.pnlPatientsDoctor.Name = "pnlPatientsDoctor";
            this.pnlPatientsDoctor.Size = new System.Drawing.Size(611, 313);
            this.pnlPatientsDoctor.TabIndex = 27;
            // 
            // lblPatInfoRecep
            // 
            this.lblPatInfoRecep.AutoSize = true;
            this.lblPatInfoRecep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatInfoRecep.Location = new System.Drawing.Point(275, 12);
            this.lblPatInfoRecep.Name = "lblPatInfoRecep";
            this.lblPatInfoRecep.Size = new System.Drawing.Size(212, 29);
            this.lblPatInfoRecep.TabIndex = 26;
            this.lblPatInfoRecep.Text = "Patient Information";
            // 
            // txtGetPatStatus
            // 
            this.txtGetPatStatus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtGetPatStatus.Location = new System.Drawing.Point(29, 337);
            this.txtGetPatStatus.Name = "txtGetPatStatus";
            this.txtGetPatStatus.Size = new System.Drawing.Size(170, 20);
            this.txtGetPatStatus.TabIndex = 27;
            // 
            // lblGetPerscriptionRecep
            // 
            this.lblGetPerscriptionRecep.AutoSize = true;
            this.lblGetPerscriptionRecep.Location = new System.Drawing.Point(26, 411);
            this.lblGetPerscriptionRecep.Name = "lblGetPerscriptionRecep";
            this.lblGetPerscriptionRecep.Size = new System.Drawing.Size(188, 13);
            this.lblGetPerscriptionRecep.TabIndex = 28;
            this.lblGetPerscriptionRecep.Text = "Get perscription information for patient:";
            // 
            // txtGetPerscripInfoRecep
            // 
            this.txtGetPerscripInfoRecep.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtGetPerscripInfoRecep.Location = new System.Drawing.Point(26, 427);
            this.txtGetPerscripInfoRecep.Name = "txtGetPerscripInfoRecep";
            this.txtGetPerscripInfoRecep.Size = new System.Drawing.Size(170, 20);
            this.txtGetPerscripInfoRecep.TabIndex = 29;
            // 
            // btnGetPerscripInfoRecep
            // 
            this.btnGetPerscripInfoRecep.Location = new System.Drawing.Point(205, 425);
            this.btnGetPerscripInfoRecep.Name = "btnGetPerscripInfoRecep";
            this.btnGetPerscripInfoRecep.Size = new System.Drawing.Size(104, 23);
            this.btnGetPerscripInfoRecep.TabIndex = 30;
            this.btnGetPerscripInfoRecep.Text = "Get Perscriptions";
            this.btnGetPerscripInfoRecep.UseVisualStyleBackColor = true;
            // 
            // btnGetPatStatus
            // 
            this.btnGetPatStatus.Location = new System.Drawing.Point(205, 334);
            this.btnGetPatStatus.Name = "btnGetPatStatus";
            this.btnGetPatStatus.Size = new System.Drawing.Size(104, 23);
            this.btnGetPatStatus.TabIndex = 31;
            this.btnGetPatStatus.Text = "Get Status";
            this.btnGetPatStatus.UseVisualStyleBackColor = true;
            // 
            // txtRecepPatDecsrip
            // 
            this.txtRecepPatDecsrip.BackColor = System.Drawing.Color.Bisque;
            this.txtRecepPatDecsrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecepPatDecsrip.Location = new System.Drawing.Point(26, 119);
            this.txtRecepPatDecsrip.Multiline = true;
            this.txtRecepPatDecsrip.Name = "txtRecepPatDecsrip";
            this.txtRecepPatDecsrip.Size = new System.Drawing.Size(261, 62);
            this.txtRecepPatDecsrip.TabIndex = 33;
            this.txtRecepPatDecsrip.Text = "Perform all tasks related to Patients";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1300, 686);
            this.Controls.Add(this.pnlEmpty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPatientsRecep.ResumeLayout(false);
            this.pnlPatientsRecep.PerformLayout();
            this.pnlEmpty.ResumeLayout(false);
            this.pnlMedicalHistory.ResumeLayout(false);
            this.pnlMedicalHistory.PerformLayout();
            this.pnlSetVisitingHours.ResumeLayout(false);
            this.pnlSetVisitingHours.PerformLayout();
            this.pnlSetAppointHour.ResumeLayout(false);
            this.pnlSetAppointHour.PerformLayout();
            this.pnlPrescriptions.ResumeLayout(false);
            this.pnlPrescriptions.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlPatientsDoctor.ResumeLayout(false);
            this.pnlPatientsDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStaffPosition;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlEmpty;
        private System.Windows.Forms.Label lblUpptPatient;
        private System.Windows.Forms.TextBox txtPersN1UpdPat;
        private System.Windows.Forms.Button btnGetPatient;
        private System.Windows.Forms.Panel pnlPatientsRecep;
        private System.Windows.Forms.Label lblGetPatStatusRecep;
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
        private System.Windows.Forms.Panel pnlRegisPatientRecep;
        private System.Windows.Forms.Button btnLogoutStaff;
        private System.Windows.Forms.Panel pnlUpdPatientRecep;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPatInfoRecep;
        private System.Windows.Forms.Button btnGetPerscripInfoRecep;
        private System.Windows.Forms.TextBox txtGetPerscripInfoRecep;
        private System.Windows.Forms.Label lblGetPerscriptionRecep;
        private System.Windows.Forms.TextBox txtGetPatStatus;
        private System.Windows.Forms.Button btnGetPatStatus;
        private System.Windows.Forms.TextBox txtRecepPatDecsrip;
    }
}