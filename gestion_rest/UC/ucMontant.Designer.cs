namespace gestion_rest.UC
{
    partial class ucMontant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMontant = new System.Windows.Forms.Label();
            this.mnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontant.Location = new System.Drawing.Point(25, 25);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(170, 30);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "Montant total :";
            // 
            // mnt
            // 
            this.mnt.AutoSize = true;
            this.mnt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnt.Location = new System.Drawing.Point(257, 25);
            this.mnt.Name = "mnt";
            this.mnt.Size = new System.Drawing.Size(76, 30);
            this.mnt.TabIndex = 1;
            this.mnt.Text = "label1";
            // 
            // ucMontant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.mnt);
            this.Controls.Add(this.lblMontant);
            this.Name = "ucMontant";
            this.Size = new System.Drawing.Size(429, 76);
            this.Load += new System.EventHandler(this.ucMontant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblMontant;
        public Label mnt;
    }
}
