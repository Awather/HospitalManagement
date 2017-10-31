namespace HospitalManagement
{
    partial class ResultCard
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
            this.txtResultCardNotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultCardNotes
            // 
            this.txtResultCardNotes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtResultCardNotes.Location = new System.Drawing.Point(186, 127);
            this.txtResultCardNotes.Multiline = true;
            this.txtResultCardNotes.Name = "txtResultCardNotes";
            this.txtResultCardNotes.ReadOnly = true;
            this.txtResultCardNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultCardNotes.Size = new System.Drawing.Size(308, 140);
            this.txtResultCardNotes.TabIndex = 3;
            this.txtResultCardNotes.TabStop = false;
            // 
            // ResultCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 394);
            this.Controls.Add(this.txtResultCardNotes);
            this.Name = "ResultCard";
            this.Text = "ResultCard";
            this.Load += new System.EventHandler(this.ResultCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultCardNotes;
    }
}