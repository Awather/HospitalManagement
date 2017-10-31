namespace HospitalManagement
{
    partial class UpdatePatient
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
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUpdatePatient = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNumer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPostalNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersnNumber = new System.Windows.Forms.TextBox();
            this.grpGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.chkFemale);
            this.grpGender.Controls.Add(this.chkMale);
            this.grpGender.Location = new System.Drawing.Point(123, 361);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(80, 47);
            this.grpGender.TabIndex = 85;
            this.grpGender.TabStop = false;
            // 
            // chkFemale
            // 
            this.chkFemale.AutoCheck = false;
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(13, 24);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(63, 17);
            this.chkFemale.TabIndex = 21;
            this.chkFemale.Text = "Woman";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.CheckedChanged += new System.EventHandler(this.chkFemale_CheckedChanged);
            // 
            // chkMale
            // 
            this.chkMale.AutoCheck = false;
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(13, 1);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(47, 17);
            this.chkMale.TabIndex = 19;
            this.chkMale.Text = "Man";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.CheckedChanged += new System.EventHandler(this.chkMale_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Gender :";
            // 
            // lblUpdatePatient
            // 
            this.lblUpdatePatient.AutoSize = true;
            this.lblUpdatePatient.Font = new System.Drawing.Font("Franklin Gothic Book", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePatient.Location = new System.Drawing.Point(131, 22);
            this.lblUpdatePatient.Name = "lblUpdatePatient";
            this.lblUpdatePatient.Size = new System.Drawing.Size(152, 25);
            this.lblUpdatePatient.TabIndex = 83;
            this.lblUpdatePatient.Text = "Update Patient";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(287, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 23);
            this.btnUpdate.TabIndex = 82;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(287, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 23);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Email : ";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(181, 325);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 20);
            this.txtEmail.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Phone-number";
            // 
            // txtPhoneNumer
            // 
            this.txtPhoneNumer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPhoneNumer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumer.Location = new System.Drawing.Point(181, 290);
            this.txtPhoneNumer.Name = "txtPhoneNumer";
            this.txtPhoneNumer.Size = new System.Drawing.Size(136, 20);
            this.txtPhoneNumer.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "City :";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(181, 252);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(152, 20);
            this.txtCity.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Postal-number :";
            // 
            // txtPostalNumber
            // 
            this.txtPostalNumber.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPostalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalNumber.Location = new System.Drawing.Point(181, 215);
            this.txtPostalNumber.Name = "txtPostalNumber";
            this.txtPostalNumber.Size = new System.Drawing.Size(77, 20);
            this.txtPostalNumber.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(181, 181);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 20);
            this.txtAddress.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Last name : ";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Location = new System.Drawing.Point(181, 147);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 20);
            this.txtLastName.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "First name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(181, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(111, 20);
            this.txtFirstName.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Personal Number";
            // 
            // txtPersnNumber
            // 
            this.txtPersnNumber.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPersnNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersnNumber.Location = new System.Drawing.Point(181, 77);
            this.txtPersnNumber.Name = "txtPersnNumber";
            this.txtPersnNumber.Size = new System.Drawing.Size(136, 20);
            this.txtPersnNumber.TabIndex = 65;
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(480, 463);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblUpdatePatient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhoneNumer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPostalNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersnNumber);
            this.Name = "UpdatePatient";
            this.Text = "UpdatePatient";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUpdatePatient;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneNumer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPostalNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersnNumber;
    }
}