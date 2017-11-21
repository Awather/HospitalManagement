﻿namespace HospitalManagement
{
    partial class PatientGUI
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
            this.lblEmptyPatient = new System.Windows.Forms.Label();
            this.pnlTesting = new System.Windows.Forms.Panel();
            this.pnlResultCard = new System.Windows.Forms.Panel();
            this.lblResultCard = new System.Windows.Forms.Label();
            this.pnlResultCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmptyPatient
            // 
            this.lblEmptyPatient.AutoSize = true;
            this.lblEmptyPatient.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyPatient.Location = new System.Drawing.Point(31, 36);
            this.lblEmptyPatient.Name = "lblEmptyPatient";
            this.lblEmptyPatient.Size = new System.Drawing.Size(0, 13);
            this.lblEmptyPatient.TabIndex = 5;
            // 
            // pnlTesting
            // 
            this.pnlTesting.AutoScroll = true;
            this.pnlTesting.AutoSize = true;
            this.pnlTesting.BackColor = System.Drawing.Color.DimGray;
            this.pnlTesting.Location = new System.Drawing.Point(293, 12);
            this.pnlTesting.Name = "pnlTesting";
            this.pnlTesting.Size = new System.Drawing.Size(632, 504);
            this.pnlTesting.TabIndex = 1;
            // 
            // pnlResultCard
            // 
            this.pnlResultCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlResultCard.Controls.Add(this.lblResultCard);
            this.pnlResultCard.Location = new System.Drawing.Point(293, 12);
            this.pnlResultCard.Name = "pnlResultCard";
            this.pnlResultCard.Size = new System.Drawing.Size(592, 392);
            this.pnlResultCard.TabIndex = 0;
            // 
            // lblResultCard
            // 
            this.lblResultCard.AutoSize = true;
            this.lblResultCard.Location = new System.Drawing.Point(41, 24);
            this.lblResultCard.Name = "lblResultCard";
            this.lblResultCard.Size = new System.Drawing.Size(62, 13);
            this.lblResultCard.TabIndex = 0;
            this.lblResultCard.Text = "Result Card";
            // 
            // PatientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 528);
            this.Controls.Add(this.lblEmptyPatient);
            this.Controls.Add(this.pnlTesting);
            this.Controls.Add(this.pnlResultCard);
            this.Name = "PatientGUI";
            this.Text = "PatientGUI";
            this.Load += new System.EventHandler(this.PatientGUI_Load);
            this.pnlResultCard.ResumeLayout(false);
            this.pnlResultCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmptyPatient;
        private System.Windows.Forms.Panel pnlResultCard;
        private System.Windows.Forms.Label lblResultCard;
        protected internal System.Windows.Forms.Panel pnlTesting;
    }
}