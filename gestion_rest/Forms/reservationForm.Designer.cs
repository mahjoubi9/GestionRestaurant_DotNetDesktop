namespace gestion_rest.Forms
{
    partial class reservationForm
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
            this.cmdTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nbPerson = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnAjt = new System.Windows.Forms.Button();
            this.nomServeur = new System.Windows.Forms.Label();
            this.comboServeurs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdTitre
            // 
            this.cmdTitre.AutoSize = true;
            this.cmdTitre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdTitre.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmdTitre.Location = new System.Drawing.Point(227, 23);
            this.cmdTitre.Name = "cmdTitre";
            this.cmdTitre.Size = new System.Drawing.Size(70, 28);
            this.cmdTitre.TabIndex = 0;
            this.cmdTitre.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de personnes:";
            // 
            // nbPerson
            // 
            this.nbPerson.Location = new System.Drawing.Point(300, 82);
            this.nbPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbPerson.Name = "nbPerson";
            this.nbPerson.Size = new System.Drawing.Size(149, 23);
            this.nbPerson.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "mode de pay:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 188);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(68, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date de la commande:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(286, 135);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(218, 23);
            this.date.TabIndex = 7;
            // 
            // btnAjt
            // 
            this.btnAjt.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAjt.Location = new System.Drawing.Point(212, 302);
            this.btnAjt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(103, 26);
            this.btnAjt.TabIndex = 8;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = true;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // nomServeur
            // 
            this.nomServeur.AutoSize = true;
            this.nomServeur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomServeur.Location = new System.Drawing.Point(68, 240);
            this.nomServeur.Name = "nomServeur";
            this.nomServeur.Size = new System.Drawing.Size(67, 19);
            this.nomServeur.TabIndex = 9;
            this.nomServeur.Text = "Serveur:";
            // 
            // comboServeurs
            // 
            this.comboServeurs.FormattingEnabled = true;
            this.comboServeurs.Location = new System.Drawing.Point(300, 236);
            this.comboServeurs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboServeurs.Name = "comboServeurs";
            this.comboServeurs.Size = new System.Drawing.Size(149, 23);
            this.comboServeurs.TabIndex = 10;
            // 
            // reservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(533, 336);
            this.Controls.Add(this.comboServeurs);
            this.Controls.Add(this.nomServeur);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdTitre);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "reservationForm";
            this.Text = "reservationForm";
            this.Load += new System.EventHandler(this.reservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cmdTitre;
        private Label label1;
        private NumericUpDown nbPerson;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker date;
        private Button btnAjt;
        private Label nomServeur;
        private ComboBox comboServeurs;
    }
}