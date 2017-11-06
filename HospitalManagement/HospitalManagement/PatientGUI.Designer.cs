namespace HospitalManagement
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
            this.pnlResultCard = new System.Windows.Forms.Panel();
            this.pnlTesting = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlResultCard
            // 
            this.pnlResultCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlResultCard.Location = new System.Drawing.Point(146, 12);
            this.pnlResultCard.Name = "pnlResultCard";
            this.pnlResultCard.Size = new System.Drawing.Size(573, 347);
            this.pnlResultCard.TabIndex = 0;
            // 
            // pnlTesting
            // 
            this.pnlTesting.BackColor = System.Drawing.Color.Transparent;
            this.pnlTesting.Location = new System.Drawing.Point(146, 12);
            this.pnlTesting.Name = "pnlTesting";
            this.pnlTesting.Size = new System.Drawing.Size(573, 347);
            this.pnlTesting.TabIndex = 1;
            // 
            // PatientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.pnlTesting);
            this.Controls.Add(this.pnlResultCard);
            this.Name = "PatientGUI";
            this.Text = "PatientGUI";
            this.Load += new System.EventHandler(this.PatientGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResultCard;
        private System.Windows.Forms.Panel pnlTesting;
    }
}