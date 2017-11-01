namespace HospitalManagement
{
    partial class CompSaysNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompSaysNo));
            this.pnlOk = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlOk
            // 
            this.pnlOk.BackColor = System.Drawing.Color.Transparent;
            this.pnlOk.Location = new System.Drawing.Point(159, 403);
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.Size = new System.Drawing.Size(595, 85);
            this.pnlOk.TabIndex = 0;
            this.pnlOk.Click += new System.EventHandler(this.pnlOk_Click);
            // 
            // CompSaysNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(870, 490);
            this.Controls.Add(this.pnlOk);
            this.Name = "CompSaysNo";
            this.Text = "CompSaysNo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOk;
    }
}