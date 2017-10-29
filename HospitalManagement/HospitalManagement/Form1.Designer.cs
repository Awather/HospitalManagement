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
            this.cmbPermissions = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNoPatient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPersNumber = new System.Windows.Forms.TextBox();
            this.txtPersNumber3 = new System.Windows.Forms.TextBox();
            this.txtPersNumber2 = new System.Windows.Forms.TextBox();
            this.btnUppdPatJournal = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnGetPatient = new System.Windows.Forms.Button();
            this.btnCreateJournal = new System.Windows.Forms.Button();
            this.pnlSetVisitingHours = new System.Windows.Forms.Panel();
            this.pnlSetAppointHour = new System.Windows.Forms.Panel();
            this.pnlUppdtPatient = new System.Windows.Forms.Panel();
            this.pnlCreatePatJournal = new System.Windows.Forms.Panel();
            this.pnlUppPatJournal = new System.Windows.Forms.Panel();
            this.pnlEmpty = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSetVisitingHours.SuspendLayout();
            this.pnlSetAppointHour.SuspendLayout();
            this.pnlUppdtPatient.SuspendLayout();
            this.pnlCreatePatJournal.SuspendLayout();
            this.menuStrip2.SuspendLayout();
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
            // cmbPermissions
            // 
            this.cmbPermissions.FormattingEnabled = true;
            this.cmbPermissions.Location = new System.Drawing.Point(97, 0);
            this.cmbPermissions.Name = "cmbPermissions";
            this.cmbPermissions.Size = new System.Drawing.Size(150, 21);
            this.cmbPermissions.TabIndex = 10;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.txtPersNumber);
            this.panel2.Controls.Add(this.txtPersNumber3);
            this.panel2.Controls.Add(this.txtPersNumber2);
            this.panel2.Controls.Add(this.btnUppdPatJournal);
            this.panel2.Controls.Add(this.btnChoose);
            this.panel2.Controls.Add(this.btnGetPatient);
            this.panel2.Controls.Add(this.btnCreateJournal);
            this.panel2.Controls.Add(this.pnlSetVisitingHours);
            this.panel2.Controls.Add(this.pnlEmpty);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.cmbPermissions);
            this.panel2.Location = new System.Drawing.Point(33, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 332);
            this.panel2.TabIndex = 12;
            // 
            // txtPersNumber
            // 
            this.txtPersNumber.Location = new System.Drawing.Point(632, 35);
            this.txtPersNumber.Name = "txtPersNumber";
            this.txtPersNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPersNumber.TabIndex = 25;
            // 
            // txtPersNumber3
            // 
            this.txtPersNumber3.Location = new System.Drawing.Point(632, 120);
            this.txtPersNumber3.Name = "txtPersNumber3";
            this.txtPersNumber3.Size = new System.Drawing.Size(100, 20);
            this.txtPersNumber3.TabIndex = 24;
            // 
            // txtPersNumber2
            // 
            this.txtPersNumber2.Location = new System.Drawing.Point(632, 73);
            this.txtPersNumber2.Name = "txtPersNumber2";
            this.txtPersNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtPersNumber2.TabIndex = 23;
            // 
            // btnUppdPatJournal
            // 
            this.btnUppdPatJournal.Location = new System.Drawing.Point(97, 229);
            this.btnUppdPatJournal.Name = "btnUppdPatJournal";
            this.btnUppdPatJournal.Size = new System.Drawing.Size(115, 23);
            this.btnUppdPatJournal.TabIndex = 22;
            this.btnUppdPatJournal.Text = "Uppdate Patient";
            this.btnUppdPatJournal.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(97, 186);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(115, 23);
            this.btnChoose.TabIndex = 21;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            // 
            // btnGetPatient
            // 
            this.btnGetPatient.Location = new System.Drawing.Point(97, 145);
            this.btnGetPatient.Name = "btnGetPatient";
            this.btnGetPatient.Size = new System.Drawing.Size(115, 23);
            this.btnGetPatient.TabIndex = 20;
            this.btnGetPatient.Text = "Get Patient";
            this.btnGetPatient.UseVisualStyleBackColor = true;
            // 
            // btnCreateJournal
            // 
            this.btnCreateJournal.Location = new System.Drawing.Point(97, 106);
            this.btnCreateJournal.Name = "btnCreateJournal";
            this.btnCreateJournal.Size = new System.Drawing.Size(115, 23);
            this.btnCreateJournal.TabIndex = 19;
            this.btnCreateJournal.Text = "Create Journal";
            this.btnCreateJournal.UseVisualStyleBackColor = true;
            // 
            // pnlSetVisitingHours
            // 
            this.pnlSetVisitingHours.Controls.Add(this.pnlSetAppointHour);
            this.pnlSetVisitingHours.Location = new System.Drawing.Point(258, 73);
            this.pnlSetVisitingHours.Name = "pnlSetVisitingHours";
            this.pnlSetVisitingHours.Size = new System.Drawing.Size(330, 193);
            this.pnlSetVisitingHours.TabIndex = 11;
            // 
            // pnlSetAppointHour
            // 
            this.pnlSetAppointHour.BackColor = System.Drawing.Color.Orange;
            this.pnlSetAppointHour.Controls.Add(this.pnlUppdtPatient);
            this.pnlSetAppointHour.Location = new System.Drawing.Point(0, 0);
            this.pnlSetAppointHour.Name = "pnlSetAppointHour";
            this.pnlSetAppointHour.Size = new System.Drawing.Size(330, 193);
            this.pnlSetAppointHour.TabIndex = 12;
            // 
            // pnlUppdtPatient
            // 
            this.pnlUppdtPatient.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlUppdtPatient.Controls.Add(this.pnlCreatePatJournal);
            this.pnlUppdtPatient.Location = new System.Drawing.Point(0, 0);
            this.pnlUppdtPatient.Name = "pnlUppdtPatient";
            this.pnlUppdtPatient.Size = new System.Drawing.Size(330, 193);
            this.pnlUppdtPatient.TabIndex = 14;
            // 
            // pnlCreatePatJournal
            // 
            this.pnlCreatePatJournal.BackColor = System.Drawing.Color.Olive;
            this.pnlCreatePatJournal.Controls.Add(this.pnlUppPatJournal);
            this.pnlCreatePatJournal.Location = new System.Drawing.Point(3, 3);
            this.pnlCreatePatJournal.Name = "pnlCreatePatJournal";
            this.pnlCreatePatJournal.Size = new System.Drawing.Size(324, 187);
            this.pnlCreatePatJournal.TabIndex = 15;
            // 
            // pnlUppPatJournal
            // 
            this.pnlUppPatJournal.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlUppPatJournal.Location = new System.Drawing.Point(-3, -3);
            this.pnlUppPatJournal.Name = "pnlUppPatJournal";
            this.pnlUppPatJournal.Size = new System.Drawing.Size(330, 193);
            this.pnlUppPatJournal.TabIndex = 13;
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.Location = new System.Drawing.Point(258, 73);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.Size = new System.Drawing.Size(330, 193);
            this.pnlEmpty.TabIndex = 11;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4,
            this.toolStripTextBox5,
            this.toolStripTextBox6,
            this.toolStripTextBox7});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip2.Size = new System.Drawing.Size(92, 332);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.BackColor = System.Drawing.Color.OldLace;
            this.toolStripTextBox4.Margin = new System.Windows.Forms.Padding(1, 0, -1, 0);
            this.toolStripTextBox4.MergeIndex = -5;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(91, 23);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.BackColor = System.Drawing.Color.OldLace;
            this.toolStripTextBox5.Margin = new System.Windows.Forms.Padding(1, 0, -1, 0);
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(91, 23);
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.BackColor = System.Drawing.Color.OldLace;
            this.toolStripTextBox6.Margin = new System.Windows.Forms.Padding(1, 0, -1, 0);
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(91, 23);
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.BackColor = System.Drawing.Color.OldLace;
            this.toolStripTextBox7.Margin = new System.Windows.Forms.Padding(1, 0, -1, 0);
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(91, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSetVisitingHours.ResumeLayout(false);
            this.pnlSetAppointHour.ResumeLayout(false);
            this.pnlUppdtPatient.ResumeLayout(false);
            this.pnlCreatePatJournal.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.ComboBox cmbPermissions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.Panel pnlEmpty;
        private System.Windows.Forms.Panel pnlSetVisitingHours;
        private System.Windows.Forms.Panel pnlSetAppointHour;
        private System.Windows.Forms.Panel pnlUppdtPatient;
        private System.Windows.Forms.Panel pnlCreatePatJournal;
        private System.Windows.Forms.Panel pnlUppPatJournal;
        private System.Windows.Forms.Button btnCreateJournal;
        private System.Windows.Forms.Label lblNoPatient;
        private System.Windows.Forms.Button btnGetPatient;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnUppdPatJournal;
        private System.Windows.Forms.TextBox txtPersNumber3;
        private System.Windows.Forms.TextBox txtPersNumber2;
        private System.Windows.Forms.TextBox txtPersNumber;
    }
}