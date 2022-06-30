namespace gestion_rest.UC
{
    partial class ucTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTable));
            this.nameTable = new System.Windows.Forms.Label();
            this.nbPlace = new System.Windows.Forms.Label();
            this.btnReserver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTable
            // 
            this.nameTable.AutoSize = true;
            this.nameTable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTable.Location = new System.Drawing.Point(74, 11);
            this.nameTable.Name = "nameTable";
            this.nameTable.Size = new System.Drawing.Size(125, 30);
            this.nameTable.TabIndex = 0;
            this.nameTable.Text = "nameTable";
            // 
            // nbPlace
            // 
            this.nbPlace.AutoSize = true;
            this.nbPlace.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nbPlace.Location = new System.Drawing.Point(74, 75);
            this.nbPlace.Name = "nbPlace";
            this.nbPlace.Size = new System.Drawing.Size(95, 30);
            this.nbPlace.TabIndex = 1;
            this.nbPlace.Text = "nbPlace";
            // 
            // btnReserver
            // 
            this.btnReserver.BackColor = System.Drawing.Color.DarkCyan;
            this.btnReserver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReserver.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReserver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReserver.Location = new System.Drawing.Point(315, 46);
            this.btnReserver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(122, 34);
            this.btnReserver.TabIndex = 2;
            this.btnReserver.Text = "Réserver";
            this.btnReserver.UseVisualStyleBackColor = false;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 11);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // ucTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.nbPlace);
            this.Controls.Add(this.nameTable);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 3, 8);
            this.Name = "ucTable";
            this.Size = new System.Drawing.Size(525, 126);
            this.Load += new System.EventHandler(this.ucTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label nameTable;
        public Label nbPlace;
        public Button btnReserver;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
    }
}
