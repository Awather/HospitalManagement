namespace HospitalManagement
{
    partial class Welcome
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
            this.chkEmployee = new System.Windows.Forms.CheckBox();
            this.chkPatient = new System.Windows.Forms.CheckBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkEmployee
            // 
            this.chkEmployee.AutoSize = true;
            this.chkEmployee.Location = new System.Drawing.Point(268, 174);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Size = new System.Drawing.Size(72, 17);
            this.chkEmployee.TabIndex = 0;
            this.chkEmployee.Text = "Employee";
            this.chkEmployee.UseVisualStyleBackColor = true;
            this.chkEmployee.Click += new System.EventHandler(this.chkEmployee_Click);
            // 
            // chkPatient
            // 
            this.chkPatient.AutoSize = true;
            this.chkPatient.Location = new System.Drawing.Point(268, 225);
            this.chkPatient.Name = "chkPatient";
            this.chkPatient.Size = new System.Drawing.Size(59, 17);
            this.chkPatient.TabIndex = 1;
            this.chkPatient.Text = "Patient";
            this.chkPatient.UseVisualStyleBackColor = true;
            this.chkPatient.Click += new System.EventHandler(this.chkPatient_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(277, 97);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinue.Location = new System.Drawing.Point(248, 308);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(142, 23);
            this.btnContinue.TabIndex = 62;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 371);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.chkPatient);
            this.Controls.Add(this.chkEmployee);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEmployee;
        private System.Windows.Forms.CheckBox chkPatient;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnContinue;
    }
}