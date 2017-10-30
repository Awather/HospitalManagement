namespace HospitalManagement
{
    partial class DoctorNotes
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
            this.btnCancelDrComment = new System.Windows.Forms.Button();
            this.btnSaveDrComment = new System.Windows.Forms.Button();
            this.txtDoctorComments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelDrComment
            // 
            this.btnCancelDrComment.Location = new System.Drawing.Point(426, 319);
            this.btnCancelDrComment.Name = "btnCancelDrComment";
            this.btnCancelDrComment.Size = new System.Drawing.Size(92, 23);
            this.btnCancelDrComment.TabIndex = 8;
            this.btnCancelDrComment.Text = "Cancel";
            this.btnCancelDrComment.UseVisualStyleBackColor = true;
            // 
            // btnSaveDrComment
            // 
            this.btnSaveDrComment.Location = new System.Drawing.Point(308, 319);
            this.btnSaveDrComment.Name = "btnSaveDrComment";
            this.btnSaveDrComment.Size = new System.Drawing.Size(92, 23);
            this.btnSaveDrComment.TabIndex = 7;
            this.btnSaveDrComment.Text = "Save";
            this.btnSaveDrComment.UseVisualStyleBackColor = true;
            this.btnSaveDrComment.Click += new System.EventHandler(this.btnSaveDrComment_Click);
            // 
            // txtDoctorComments
            // 
            this.txtDoctorComments.BackColor = System.Drawing.Color.Lavender;
            this.txtDoctorComments.Location = new System.Drawing.Point(88, 39);
            this.txtDoctorComments.Multiline = true;
            this.txtDoctorComments.Name = "txtDoctorComments";
            this.txtDoctorComments.Size = new System.Drawing.Size(411, 265);
            this.txtDoctorComments.TabIndex = 6;
            // 
            // DoctorNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(606, 381);
            this.Controls.Add(this.btnCancelDrComment);
            this.Controls.Add(this.btnSaveDrComment);
            this.Controls.Add(this.txtDoctorComments);
            this.Name = "DoctorNotes";
            this.Text = "DoctorNotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelDrComment;
        private System.Windows.Forms.Button btnSaveDrComment;
        private System.Windows.Forms.TextBox txtDoctorComments;
    }
}