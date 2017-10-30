namespace HospitalManagement
{
    partial class PatientJournal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoPatient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDoctorNotes = new System.Windows.Forms.TextBox();
            this.lblMedStatCommnt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPlannedVisits = new System.Windows.Forms.Label();
            this.btnNewStmtCommnt = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.lblNoPatient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEmpty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLoggedInAs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 47);
            this.panel1.TabIndex = 12;
            // 
            // lblNoPatient
            // 
            this.lblNoPatient.AutoSize = true;
            this.lblNoPatient.Location = new System.Drawing.Point(277, 48);
            this.lblNoPatient.Name = "lblNoPatient";
            this.lblNoPatient.Size = new System.Drawing.Size(0, 13);
            this.lblNoPatient.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome";
            // 
            // lblEmpty
            // 
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.Location = new System.Drawing.Point(889, 2);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(98, 20);
            this.lblEmpty.TabIndex = 9;
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
            this.lblLoggedInAs.Location = new System.Drawing.Point(797, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(86, 17);
            this.lblLoggedInAs.TabIndex = 8;
            this.lblLoggedInAs.Text = "Logged in as:";
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
            // textDoctorNotes
            // 
            this.textDoctorNotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textDoctorNotes.Location = new System.Drawing.Point(110, 39);
            this.textDoctorNotes.Multiline = true;
            this.textDoctorNotes.Name = "textDoctorNotes";
            this.textDoctorNotes.ReadOnly = true;
            this.textDoctorNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDoctorNotes.Size = new System.Drawing.Size(308, 140);
            this.textDoctorNotes.TabIndex = 1;
            this.textDoctorNotes.TabStop = false;
            // 
            // lblMedStatCommnt
            // 
            this.lblMedStatCommnt.AutoSize = true;
            this.lblMedStatCommnt.Location = new System.Drawing.Point(107, 23);
            this.lblMedStatCommnt.Name = "lblMedStatCommnt";
            this.lblMedStatCommnt.Size = new System.Drawing.Size(148, 13);
            this.lblMedStatCommnt.TabIndex = 2;
            this.lblMedStatCommnt.Text = "Medical statement / Comment";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnNewStmtCommnt);
            this.panel2.Controls.Add(this.lblPlannedVisits);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblMedStatCommnt);
            this.panel2.Controls.Add(this.textDoctorNotes);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 442);
            this.panel2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lavender;
            this.textBox1.Location = new System.Drawing.Point(670, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(308, 140);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            // 
            // lblPlannedVisits
            // 
            this.lblPlannedVisits.AutoSize = true;
            this.lblPlannedVisits.Location = new System.Drawing.Point(667, 23);
            this.lblPlannedVisits.Name = "lblPlannedVisits";
            this.lblPlannedVisits.Size = new System.Drawing.Size(98, 13);
            this.lblPlannedVisits.TabIndex = 4;
            this.lblPlannedVisits.Text = "Planned visitations:";
            // 
            // btnNewStmtCommnt
            // 
            this.btnNewStmtCommnt.Location = new System.Drawing.Point(248, 185);
            this.btnNewStmtCommnt.Name = "btnNewStmtCommnt";
            this.btnNewStmtCommnt.Size = new System.Drawing.Size(170, 23);
            this.btnNewStmtCommnt.TabIndex = 5;
            this.btnNewStmtCommnt.Text = "New Statment / Comment";
            this.btnNewStmtCommnt.UseVisualStyleBackColor = true;
            this.btnNewStmtCommnt.Click += new System.EventHandler(this.btnNewStmtCommnt_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(670, 185);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // PatientJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PatientJournal";
            this.Text = "PatientJournal";
            this.Load += new System.EventHandler(this.PatientJournal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNoPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDoctorNotes;
        private System.Windows.Forms.Label lblMedStatCommnt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNewStmtCommnt;
        private System.Windows.Forms.Label lblPlannedVisits;
        private System.Windows.Forms.TextBox textBox1;
    }
}