namespace HospitalManagement
{
    partial class LoginStaff
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameStaff = new System.Windows.Forms.TextBox();
            this.txtPasswordStaff = new System.Windows.Forms.TextBox();
            this.txtForgotPassStaff = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Label();
            this.btnLoginStaff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelStaff = new System.Windows.Forms.Button();
            this.btnBackStaff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.btnCancelStaff);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsernameStaff);
            this.panel1.Controls.Add(this.txtPasswordStaff);
            this.panel1.Controls.Add(this.txtForgotPassStaff);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.btnLoginStaff);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(263, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 250);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login";
            // 
            // txtUsernameStaff
            // 
            this.txtUsernameStaff.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsernameStaff.Location = new System.Drawing.Point(142, 62);
            this.txtUsernameStaff.Name = "txtUsernameStaff";
            this.txtUsernameStaff.Size = new System.Drawing.Size(110, 20);
            this.txtUsernameStaff.TabIndex = 8;
            // 
            // txtPasswordStaff
            // 
            this.txtPasswordStaff.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPasswordStaff.Location = new System.Drawing.Point(142, 94);
            this.txtPasswordStaff.Margin = new System.Windows.Forms.Padding(0);
            this.txtPasswordStaff.Name = "txtPasswordStaff";
            this.txtPasswordStaff.Size = new System.Drawing.Size(110, 20);
            this.txtPasswordStaff.TabIndex = 9;
            this.txtPasswordStaff.UseSystemPasswordChar = true;
            // 
            // txtForgotPassStaff
            // 
            this.txtForgotPassStaff.AutoSize = true;
            this.txtForgotPassStaff.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForgotPassStaff.ForeColor = System.Drawing.Color.Blue;
            this.txtForgotPassStaff.Location = new System.Drawing.Point(105, 217);
            this.txtForgotPassStaff.Name = "txtForgotPassStaff";
            this.txtForgotPassStaff.Size = new System.Drawing.Size(91, 15);
            this.txtForgotPassStaff.TabIndex = 15;
            this.txtForgotPassStaff.Text = "Forgot Password?";
            this.txtForgotPassStaff.Click += new System.EventHandler(this.txtForgotPassStaff_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(54, 62);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(65, 17);
            this.txtLogin.TabIndex = 10;
            this.txtLogin.Text = "Username";
            // 
            // btnLoginStaff
            // 
            this.btnLoginStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoginStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginStaff.Location = new System.Drawing.Point(57, 134);
            this.btnLoginStaff.Name = "btnLoginStaff";
            this.btnLoginStaff.Size = new System.Drawing.Size(195, 34);
            this.btnLoginStaff.TabIndex = 14;
            this.btnLoginStaff.Text = "Login";
            this.btnLoginStaff.UseVisualStyleBackColor = false;
            this.btnLoginStaff.Click += new System.EventHandler(this.btnLoginStaff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // btnCancelStaff
            // 
            this.btnCancelStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelStaff.Location = new System.Drawing.Point(57, 174);
            this.btnCancelStaff.Name = "btnCancelStaff";
            this.btnCancelStaff.Size = new System.Drawing.Size(195, 34);
            this.btnCancelStaff.TabIndex = 16;
            this.btnCancelStaff.Text = "Cancel";
            this.btnCancelStaff.UseVisualStyleBackColor = false;
            this.btnCancelStaff.Click += new System.EventHandler(this.btnCancelStaff_Click);
            // 
            // btnBackStaff
            // 
            this.btnBackStaff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBackStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackStaff.Location = new System.Drawing.Point(12, 12);
            this.btnBackStaff.Name = "btnBackStaff";
            this.btnBackStaff.Size = new System.Drawing.Size(75, 23);
            this.btnBackStaff.TabIndex = 17;
            this.btnBackStaff.Text = "Back";
            this.btnBackStaff.UseVisualStyleBackColor = false;
            this.btnBackStaff.Click += new System.EventHandler(this.btnBackStaff_Click);
            // 
            // LoginStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(821, 443);
            this.Controls.Add(this.btnBackStaff);
            this.Controls.Add(this.panel1);
            this.Name = "LoginStaff";
            this.Text = "LoginStaff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameStaff;
        private System.Windows.Forms.TextBox txtPasswordStaff;
        private System.Windows.Forms.Label txtForgotPassStaff;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Button btnLoginStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelStaff;
        private System.Windows.Forms.Button btnBackStaff;
    }
}