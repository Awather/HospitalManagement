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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoPatient = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cmbPermissions = new System.Windows.Forms.ComboBox();
            this.btnCreateJournal = new System.Windows.Forms.Button();
            this.btnGetPatient = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnUpdPatJournal = new System.Windows.Forms.Button();
            this.txtPersNumber2CreatJour = new System.Windows.Forms.TextBox();
            this.txtPersNumber3 = new System.Windows.Forms.TextBox();
            this.txtPersNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCreatPatJournal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlCreatePatJournal = new System.Windows.Forms.Panel();
            this.lblRegisPatients = new System.Windows.Forms.Label();
            this.pnlRegisterPatients = new System.Windows.Forms.Panel();
            this.pnlEmpty = new System.Windows.Forms.Panel();
            this.pnlSetVisitHours = new System.Windows.Forms.Panel();
            this.lblUpdatePatient = new System.Windows.Forms.Label();
            this.txtPersonnummer = new System.Windows.Forms.TextBox();
            this.lblEmptyGetPat = new System.Windows.Forms.Label();
            this.pnlUpdPatients = new System.Windows.Forms.Panel();
            this.lblUpdPatJournal = new System.Windows.Forms.Label();
            this.txtPersnr = new System.Windows.Forms.TextBox();
            this.pnlUpdPatJournal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCreatePatJournal.SuspendLayout();
            this.pnlRegisterPatients.SuspendLayout();
            this.pnlSetVisitHours.SuspendLayout();
            this.pnlUpdPatients.SuspendLayout();
            this.pnlUpdPatJournal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 7;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedInAs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInAs.Location = new System.Drawing.Point(558, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(86, 17);
            this.lblLoggedInAs.TabIndex = 8;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // lblEmpty
            // 
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.Location = new System.Drawing.Point(650, 2);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(98, 20);
            this.lblEmpty.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.lblNoPatient);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.lblEmpty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLoggedInAs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(33, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 47);
            this.panel1.TabIndex = 11;
            // 
            // lblNoPatient
            // 
            this.lblNoPatient.AutoSize = true;
            this.lblNoPatient.Location = new System.Drawing.Point(277, 48);
            this.lblNoPatient.Name = "lblNoPatient";
            this.lblNoPatient.Size = new System.Drawing.Size(0, 13);
            this.lblNoPatient.TabIndex = 20;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 7);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(62, 16);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome";
            // 
            // cmbPermissions
            // 
            this.cmbPermissions.FormattingEnabled = true;
            this.cmbPermissions.Location = new System.Drawing.Point(21, 3);
            this.cmbPermissions.Name = "cmbPermissions";
            this.cmbPermissions.Size = new System.Drawing.Size(150, 21);
            this.cmbPermissions.TabIndex = 10;
            // 
            // btnCreateJournal
            // 
            this.btnCreateJournal.Location = new System.Drawing.Point(170, 51);
            this.btnCreateJournal.Name = "btnCreateJournal";
            this.btnCreateJournal.Size = new System.Drawing.Size(115, 23);
            this.btnCreateJournal.TabIndex = 19;
            this.btnCreateJournal.Text = "Create Journal";
            this.btnCreateJournal.UseVisualStyleBackColor = true;
            this.btnCreateJournal.Click += new System.EventHandler(this.btnCreateJournal_Click);
            // 
            // btnGetPatient
            // 
            this.btnGetPatient.Location = new System.Drawing.Point(195, 48);
            this.btnGetPatient.Name = "btnGetPatient";
            this.btnGetPatient.Size = new System.Drawing.Size(115, 23);
            this.btnGetPatient.TabIndex = 20;
            this.btnGetPatient.Text = "Get Patient";
            this.btnGetPatient.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(367, 3);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(115, 23);
            this.btnChoose.TabIndex = 21;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnUpdPatJournal
            // 
            this.btnUpdPatJournal.Location = new System.Drawing.Point(237, 49);
            this.btnUpdPatJournal.Name = "btnUpdPatJournal";
            this.btnUpdPatJournal.Size = new System.Drawing.Size(115, 23);
            this.btnUpdPatJournal.TabIndex = 22;
            this.btnUpdPatJournal.Text = "Update Journal";
            this.btnUpdPatJournal.UseVisualStyleBackColor = true;
            this.btnUpdPatJournal.Click += new System.EventHandler(this.btnUppdPatJournal_Click);
            // 
            // txtPersNumber2CreatJour
            // 
            this.txtPersNumber2CreatJour.Location = new System.Drawing.Point(51, 51);
            this.txtPersNumber2CreatJour.Name = "txtPersNumber2CreatJour";
            this.txtPersNumber2CreatJour.Size = new System.Drawing.Size(100, 20);
            this.txtPersNumber2CreatJour.TabIndex = 23;
            // 
            // txtPersNumber3
            // 
            this.txtPersNumber3.Location = new System.Drawing.Point(510, 35);
            this.txtPersNumber3.Name = "txtPersNumber3";
            this.txtPersNumber3.Size = new System.Drawing.Size(100, 20);
            this.txtPersNumber3.TabIndex = 24;
            // 
            // txtPersNumber
            // 
            this.txtPersNumber.Location = new System.Drawing.Point(632, 35);
            this.txtPersNumber.Name = "txtPersNumber";
            this.txtPersNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPersNumber.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.pnlRegisterPatients);
            this.panel2.Controls.Add(this.pnlCreatePatJournal);
            this.panel2.Controls.Add(this.pnlUpdPatients);
            this.panel2.Controls.Add(this.pnlSetVisitHours);
            this.panel2.Controls.Add(this.pnlEmpty);
            this.panel2.Controls.Add(this.txtPersNumber);
            this.panel2.Controls.Add(this.txtPersNumber3);
            this.panel2.Controls.Add(this.btnChoose);
            this.panel2.Controls.Add(this.cmbPermissions);
            this.panel2.Controls.Add(this.pnlUpdPatJournal);
            this.panel2.Location = new System.Drawing.Point(33, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 450);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Set visiting hours";
            // 
            // lblCreatPatJournal
            // 
            this.lblCreatPatJournal.AutoSize = true;
            this.lblCreatPatJournal.Location = new System.Drawing.Point(16, 13);
            this.lblCreatPatJournal.Name = "lblCreatPatJournal";
            this.lblCreatPatJournal.Size = new System.Drawing.Size(112, 13);
            this.lblCreatPatJournal.TabIndex = 1;
            this.lblCreatPatJournal.Text = "Create patients journal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(326, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 4;
            // 
            // pnlCreatePatJournal
            // 
            this.pnlCreatePatJournal.BackColor = System.Drawing.Color.Violet;
            this.pnlCreatePatJournal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCreatePatJournal.Controls.Add(this.label9);
            this.pnlCreatePatJournal.Controls.Add(this.lblCreatPatJournal);
            this.pnlCreatePatJournal.Controls.Add(this.txtPersNumber2CreatJour);
            this.pnlCreatePatJournal.Controls.Add(this.btnCreateJournal);
            this.pnlCreatePatJournal.Location = new System.Drawing.Point(252, 84);
            this.pnlCreatePatJournal.Name = "pnlCreatePatJournal";
            this.pnlCreatePatJournal.Size = new System.Drawing.Size(656, 366);
            this.pnlCreatePatJournal.TabIndex = 29;
            // 
            // lblRegisPatients
            // 
            this.lblRegisPatients.AutoSize = true;
            this.lblRegisPatients.Location = new System.Drawing.Point(16, 13);
            this.lblRegisPatients.Name = "lblRegisPatients";
            this.lblRegisPatients.Size = new System.Drawing.Size(87, 13);
            this.lblRegisPatients.TabIndex = 1;
            this.lblRegisPatients.Text = "Register Patients";
            // 
            // pnlRegisterPatients
            // 
            this.pnlRegisterPatients.BackColor = System.Drawing.Color.Thistle;
            this.pnlRegisterPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegisterPatients.Controls.Add(this.lblRegisPatients);
            this.pnlRegisterPatients.Location = new System.Drawing.Point(252, 84);
            this.pnlRegisterPatients.Name = "pnlRegisterPatients";
            this.pnlRegisterPatients.Size = new System.Drawing.Size(660, 363);
            this.pnlRegisterPatients.TabIndex = 26;
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.BackColor = System.Drawing.Color.Red;
            this.pnlEmpty.Location = new System.Drawing.Point(252, 84);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.Size = new System.Drawing.Size(660, 363);
            this.pnlEmpty.TabIndex = 27;
            // 
            // pnlSetVisitHours
            // 
            this.pnlSetVisitHours.BackColor = System.Drawing.Color.HotPink;
            this.pnlSetVisitHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetVisitHours.Controls.Add(this.label5);
            this.pnlSetVisitHours.Location = new System.Drawing.Point(252, 84);
            this.pnlSetVisitHours.Name = "pnlSetVisitHours";
            this.pnlSetVisitHours.Size = new System.Drawing.Size(660, 366);
            this.pnlSetVisitHours.TabIndex = 8;
            // 
            // lblUpdatePatient
            // 
            this.lblUpdatePatient.AutoSize = true;
            this.lblUpdatePatient.Location = new System.Drawing.Point(16, 13);
            this.lblUpdatePatient.Name = "lblUpdatePatient";
            this.lblUpdatePatient.Size = new System.Drawing.Size(82, 13);
            this.lblUpdatePatient.TabIndex = 1;
            this.lblUpdatePatient.Text = "Update patients";
            // 
            // txtPersonnummer
            // 
            this.txtPersonnummer.Location = new System.Drawing.Point(52, 48);
            this.txtPersonnummer.Name = "txtPersonnummer";
            this.txtPersonnummer.Size = new System.Drawing.Size(137, 20);
            this.txtPersonnummer.TabIndex = 2;
            // 
            // lblEmptyGetPat
            // 
            this.lblEmptyGetPat.AutoSize = true;
            this.lblEmptyGetPat.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyGetPat.Location = new System.Drawing.Point(336, 51);
            this.lblEmptyGetPat.Name = "lblEmptyGetPat";
            this.lblEmptyGetPat.Size = new System.Drawing.Size(0, 13);
            this.lblEmptyGetPat.TabIndex = 4;
            // 
            // pnlUpdPatients
            // 
            this.pnlUpdPatients.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlUpdPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdPatients.Controls.Add(this.lblEmptyGetPat);
            this.pnlUpdPatients.Controls.Add(this.txtPersonnummer);
            this.pnlUpdPatients.Controls.Add(this.lblUpdatePatient);
            this.pnlUpdPatients.Controls.Add(this.btnGetPatient);
            this.pnlUpdPatients.Location = new System.Drawing.Point(252, 134);
            this.pnlUpdPatients.Name = "pnlUpdPatients";
            this.pnlUpdPatients.Size = new System.Drawing.Size(660, 366);
            this.pnlUpdPatients.TabIndex = 28;
            // 
            // lblUpdPatJournal
            // 
            this.lblUpdPatJournal.AutoSize = true;
            this.lblUpdPatJournal.Location = new System.Drawing.Point(16, 13);
            this.lblUpdPatJournal.Name = "lblUpdPatJournal";
            this.lblUpdPatJournal.Size = new System.Drawing.Size(115, 13);
            this.lblUpdPatJournal.TabIndex = 1;
            this.lblUpdPatJournal.Text = "Update Patient Journal";
            // 
            // txtPersnr
            // 
            this.txtPersnr.Location = new System.Drawing.Point(93, 49);
            this.txtPersnr.Name = "txtPersnr";
            this.txtPersnr.Size = new System.Drawing.Size(137, 20);
            this.txtPersnr.TabIndex = 2;
            // 
            // pnlUpdPatJournal
            // 
            this.pnlUpdPatJournal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlUpdPatJournal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdPatJournal.Controls.Add(this.txtPersnr);
            this.pnlUpdPatJournal.Controls.Add(this.lblUpdPatJournal);
            this.pnlUpdPatJournal.Controls.Add(this.btnUpdPatJournal);
            this.pnlUpdPatJournal.Location = new System.Drawing.Point(252, 84);
            this.pnlUpdPatJournal.Name = "pnlUpdPatJournal";
            this.pnlUpdPatJournal.Size = new System.Drawing.Size(660, 386);
            this.pnlUpdPatJournal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCreatePatJournal.ResumeLayout(false);
            this.pnlCreatePatJournal.PerformLayout();
            this.pnlRegisterPatients.ResumeLayout(false);
            this.pnlRegisterPatients.PerformLayout();
            this.pnlSetVisitHours.ResumeLayout(false);
            this.pnlSetVisitHours.PerformLayout();
            this.pnlUpdPatients.ResumeLayout(false);
            this.pnlUpdPatients.PerformLayout();
            this.pnlUpdPatJournal.ResumeLayout(false);
            this.pnlUpdPatJournal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNoPatient;
        private System.Windows.Forms.ComboBox cmbPermissions;
        private System.Windows.Forms.Button btnCreateJournal;
        private System.Windows.Forms.Button btnGetPatient;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnUpdPatJournal;
        private System.Windows.Forms.TextBox txtPersNumber2CreatJour;
        private System.Windows.Forms.TextBox txtPersNumber3;
        private System.Windows.Forms.TextBox txtPersNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlEmpty;
        private System.Windows.Forms.Panel pnlUpdPatients;
        private System.Windows.Forms.Panel pnlUpdPatJournal;
        private System.Windows.Forms.TextBox txtPersnr;
        private System.Windows.Forms.Label lblUpdPatJournal;
        private System.Windows.Forms.Label lblEmptyGetPat;
        private System.Windows.Forms.TextBox txtPersonnummer;
        private System.Windows.Forms.Label lblUpdatePatient;
        private System.Windows.Forms.Panel pnlSetVisitHours;
        private System.Windows.Forms.Panel pnlRegisterPatients;
        private System.Windows.Forms.Label lblRegisPatients;
        private System.Windows.Forms.Panel pnlCreatePatJournal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCreatPatJournal;
    }
}