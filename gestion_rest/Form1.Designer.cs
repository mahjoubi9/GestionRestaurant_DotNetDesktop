namespace gestion_rest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nb_place = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.titre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnCommande = new System.Windows.Forms.Button();
            this.gPlat = new System.Windows.Forms.Button();
            this.gServeur = new System.Windows.Forms.Button();
            this.gTable = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.textNomServeur = new System.Windows.Forms.TextBox();
            this.textPrenomServeur = new System.Windows.Forms.TextBox();
            this.btnAjouterServeur = new System.Windows.Forms.Button();
            this.prixLbl = new System.Windows.Forms.Label();
            this.libelleLbl = new System.Windows.Forms.Label();
            this.typePlatLbl = new System.Windows.Forms.Label();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnAjouterPlat = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAnnuer2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPlat = new System.Windows.Forms.ComboBox();
            this.qteLbl = new System.Windows.Forms.Label();
            this.numQte = new System.Windows.Forms.NumericUpDown();
            this.ajtPlatComm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowDetails = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).BeginInit();
            this.SuspendLayout();
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(294, 58);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(577, 409);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // nb_place
            // 
            this.nb_place.AutoSize = true;
            this.nb_place.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nb_place.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nb_place.Location = new System.Drawing.Point(954, 139);
            this.nb_place.Name = "nb_place";
            this.nb_place.Size = new System.Drawing.Size(159, 25);
            this.nb_place.TabIndex = 1;
            this.nb_place.Text = "nombre de place:";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.Location = new System.Drawing.Point(1059, 177);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 26);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Location = new System.Drawing.Point(1128, 141);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(13, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 23);
            this.numericUpDown1.TabIndex = 3;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titre.Location = new System.Drawing.Point(909, 58);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(329, 47);
            this.titre.TabIndex = 4;
            this.titre.Text = "Gestion des tables:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnCommande);
            this.panel1.Controls.Add(this.gPlat);
            this.panel1.Controls.Add(this.gServeur);
            this.panel1.Controls.Add(this.gTable);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 466);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 339);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 257);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 182);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(34, 100);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // btnCommande
            // 
            this.btnCommande.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCommande.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCommande.Location = new System.Drawing.Point(10, 325);
            this.btnCommande.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCommande.Size = new System.Drawing.Size(270, 64);
            this.btnCommande.TabIndex = 3;
            this.btnCommande.Text = "Les commandes";
            this.btnCommande.UseVisualStyleBackColor = false;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // gPlat
            // 
            this.gPlat.BackColor = System.Drawing.Color.CadetBlue;
            this.gPlat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gPlat.Location = new System.Drawing.Point(13, 241);
            this.gPlat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gPlat.Name = "gPlat";
            this.gPlat.Size = new System.Drawing.Size(270, 64);
            this.gPlat.TabIndex = 2;
            this.gPlat.Text = "Les plats";
            this.gPlat.UseVisualStyleBackColor = false;
            this.gPlat.Click += new System.EventHandler(this.gPlat_Click);
            // 
            // gServeur
            // 
            this.gServeur.BackColor = System.Drawing.Color.CadetBlue;
            this.gServeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gServeur.Location = new System.Drawing.Point(13, 163);
            this.gServeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gServeur.Name = "gServeur";
            this.gServeur.Size = new System.Drawing.Size(270, 64);
            this.gServeur.TabIndex = 1;
            this.gServeur.Text = "Les serveurs";
            this.gServeur.UseVisualStyleBackColor = false;
            this.gServeur.Click += new System.EventHandler(this.gServeur_Click);
            // 
            // gTable
            // 
            this.gTable.BackColor = System.Drawing.Color.CadetBlue;
            this.gTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gTable.ForeColor = System.Drawing.Color.Black;
            this.gTable.Location = new System.Drawing.Point(13, 80);
            this.gTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gTable.Name = "gTable";
            this.gTable.Size = new System.Drawing.Size(270, 71);
            this.gTable.TabIndex = 0;
            this.gTable.Text = "Les tables";
            this.gTable.UseVisualStyleBackColor = false;
            this.gTable.Click += new System.EventHandler(this.gTable_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomLabel.Location = new System.Drawing.Point(954, 142);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(58, 25);
            this.nomLabel.TabIndex = 6;
            this.nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenomLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prenomLabel.Location = new System.Drawing.Point(954, 192);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(83, 25);
            this.prenomLabel.TabIndex = 7;
            this.prenomLabel.Text = "Prenom:";
            // 
            // textNomServeur
            // 
            this.textNomServeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNomServeur.Location = new System.Drawing.Point(1059, 141);
            this.textNomServeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNomServeur.Name = "textNomServeur";
            this.textNomServeur.Size = new System.Drawing.Size(187, 29);
            this.textNomServeur.TabIndex = 8;
            // 
            // textPrenomServeur
            // 
            this.textPrenomServeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textPrenomServeur.Location = new System.Drawing.Point(1059, 192);
            this.textPrenomServeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPrenomServeur.Name = "textPrenomServeur";
            this.textPrenomServeur.Size = new System.Drawing.Size(187, 29);
            this.textPrenomServeur.TabIndex = 9;
            // 
            // btnAjouterServeur
            // 
            this.btnAjouterServeur.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouterServeur.Location = new System.Drawing.Point(1102, 232);
            this.btnAjouterServeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouterServeur.Name = "btnAjouterServeur";
            this.btnAjouterServeur.Size = new System.Drawing.Size(100, 26);
            this.btnAjouterServeur.TabIndex = 10;
            this.btnAjouterServeur.Text = "Ajouter";
            this.btnAjouterServeur.UseVisualStyleBackColor = false;
            this.btnAjouterServeur.Click += new System.EventHandler(this.btnAjouterServeur_Click);
            // 
            // prixLbl
            // 
            this.prixLbl.AutoSize = true;
            this.prixLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prixLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prixLbl.Location = new System.Drawing.Point(954, 247);
            this.prixLbl.Name = "prixLbl";
            this.prixLbl.Size = new System.Drawing.Size(55, 25);
            this.prixLbl.TabIndex = 12;
            this.prixLbl.Text = "Prix :";
            // 
            // libelleLbl
            // 
            this.libelleLbl.AutoSize = true;
            this.libelleLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.libelleLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.libelleLbl.Location = new System.Drawing.Point(954, 161);
            this.libelleLbl.Name = "libelleLbl";
            this.libelleLbl.Size = new System.Drawing.Size(72, 25);
            this.libelleLbl.TabIndex = 13;
            this.libelleLbl.Text = "Libelle:";
            // 
            // typePlatLbl
            // 
            this.typePlatLbl.AutoSize = true;
            this.typePlatLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typePlatLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typePlatLbl.Location = new System.Drawing.Point(954, 206);
            this.typePlatLbl.Name = "typePlatLbl";
            this.typePlatLbl.Size = new System.Drawing.Size(120, 25);
            this.typePlatLbl.TabIndex = 14;
            this.typePlatLbl.Text = "type du plat:";
            // 
            // textlibelle
            // 
            this.textlibelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textlibelle.Location = new System.Drawing.Point(1087, 160);
            this.textlibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(184, 29);
            this.textlibelle.TabIndex = 15;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(1090, 251);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(180, 23);
            this.numericUpDown2.TabIndex = 18;
            // 
            // btnAjouterPlat
            // 
            this.btnAjouterPlat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterPlat.Location = new System.Drawing.Point(1061, 286);
            this.btnAjouterPlat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouterPlat.Name = "btnAjouterPlat";
            this.btnAjouterPlat.Size = new System.Drawing.Size(116, 27);
            this.btnAjouterPlat.TabIndex = 20;
            this.btnAjouterPlat.Text = "Ajouter";
            this.btnAjouterPlat.UseVisualStyleBackColor = true;
            this.btnAjouterPlat.Click += new System.EventHandler(this.btnAjouterPlat_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(1102, 262);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 22);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Entrée",
            "Viande",
            "dessert"});
            this.comboBox1.Location = new System.Drawing.Point(1087, 207);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // btnAnnuer2
            // 
            this.btnAnnuer2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnnuer2.Location = new System.Drawing.Point(1061, 317);
            this.btnAnnuer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuer2.Name = "btnAnnuer2";
            this.btnAnnuer2.Size = new System.Drawing.Size(116, 26);
            this.btnAnnuer2.TabIndex = 23;
            this.btnAnnuer2.Text = "Annuler";
            this.btnAnnuer2.UseVisualStyleBackColor = true;
            this.btnAnnuer2.Click += new System.EventHandler(this.btnAnnuer2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(931, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Plat: ";
            // 
            // comboPlat
            // 
            this.comboPlat.FormattingEnabled = true;
            this.comboPlat.Items.AddRange(new object[] {
            "Entrée",
            "Viande",
            "dessert"});
            this.comboPlat.Location = new System.Drawing.Point(1047, 152);
            this.comboPlat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPlat.Name = "comboPlat";
            this.comboPlat.Size = new System.Drawing.Size(184, 23);
            this.comboPlat.TabIndex = 25;
            // 
            // qteLbl
            // 
            this.qteLbl.AutoSize = true;
            this.qteLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qteLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qteLbl.Location = new System.Drawing.Point(931, 196);
            this.qteLbl.Name = "qteLbl";
            this.qteLbl.Size = new System.Drawing.Size(92, 25);
            this.qteLbl.TabIndex = 26;
            this.qteLbl.Text = "Quantité:";
            // 
            // numQte
            // 
            this.numQte.Location = new System.Drawing.Point(1047, 200);
            this.numQte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numQte.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQte.Name = "numQte";
            this.numQte.Size = new System.Drawing.Size(180, 23);
            this.numQte.TabIndex = 27;
            // 
            // ajtPlatComm
            // 
            this.ajtPlatComm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ajtPlatComm.Location = new System.Drawing.Point(1085, 238);
            this.ajtPlatComm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajtPlatComm.Name = "ajtPlatComm";
            this.ajtPlatComm.Size = new System.Drawing.Size(116, 27);
            this.ajtPlatComm.TabIndex = 28;
            this.ajtPlatComm.Text = "Ajouter";
            this.ajtPlatComm.UseVisualStyleBackColor = true;
            this.ajtPlatComm.Click += new System.EventHandler(this.ajtPlatComm_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(877, 460);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 94);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // flowDetails
            // 
            this.flowDetails.AutoScroll = true;
            this.flowDetails.Location = new System.Drawing.Point(880, 118);
            this.flowDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowDetails.Name = "flowDetails";
            this.flowDetails.Size = new System.Drawing.Size(390, 349);
            this.flowDetails.TabIndex = 29;
            this.flowDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.flowDetails_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1284, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowDetails);
            this.Controls.Add(this.ajtPlatComm);
            this.Controls.Add(this.numQte);
            this.Controls.Add(this.qteLbl);
            this.Controls.Add(this.comboPlat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuer2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterPlat);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textlibelle);
            this.Controls.Add(this.typePlatLbl);
            this.Controls.Add(this.libelleLbl);
            this.Controls.Add(this.prixLbl);
            this.Controls.Add(this.btnAjouterServeur);
            this.Controls.Add(this.textPrenomServeur);
            this.Controls.Add(this.textNomServeur);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.nb_place);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label nb_place;
        private Button btnAjouter;
        private NumericUpDown numericUpDown1;
        private Label titre;
        private Panel panel1;
        private Button gPlat;
        private Button gServeur;
        private Button gTable;
        private Label nomLabel;
        private Label prenomLabel;
        public TextBox textNomServeur;
        public TextBox textPrenomServeur;
        public Button btnAjouterServeur;
        private Label prixLbl;
        private Label libelleLbl;
        private Label typePlatLbl;
        public TextBox textlibelle;
        public NumericUpDown numericUpDown2;
        public Button btnAjouterPlat;
        public Button btnAnnuler;
        public ComboBox comboBox1;
        public Button btnAnnuer2;
        private Button btnCommande;
        public Label label1;
        public ComboBox comboPlat;
        public Label qteLbl;
        public NumericUpDown numQte;
        public Button ajtPlatComm;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        public Panel panel2;
        public FlowLayoutPanel flowDetails;
    }
}