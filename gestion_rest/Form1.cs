using gestion_rest.UC;
using Npgsql;
using System.Data;

namespace gestion_rest
{
    public partial class Form1 : Form
    {
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "gestion_rest");
        private NpgsqlConnection cnx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        public int id_ser=0;
        public int code_plat=0;
        public int numComm;
        // private ucServeur ucS=new ucServeur(this);
        public Form1()
        {
            cnx = new NpgsqlConnection(cc);
            InitializeComponent();
            initializeMontant();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nomLabel.Visible = false;
            prenomLabel.Visible = false;
            btnAjouterServeur.Visible = false;
            textPrenomServeur.Visible = false;
            textNomServeur.Visible = false;
            btnAnnuler.Visible = false;
            libelleLbl.Visible = false;
            prixLbl.Visible = false;
            typePlatLbl.Visible = false;
            textlibelle.Visible = false;
            comboBox1.Visible = false;
            numericUpDown2.Visible = false;
            btnAjouterPlat.Visible = false;
            btnAnnuer2.Visible = false;
            label1.Visible = false;
            comboPlat.Visible = false;
            qteLbl.Visible = false;
            numQte.Visible = false;
            ajtPlatComm.Visible= false;
            flowDetails.Visible = false;
            SelectionTable();
        }

        private void SelectionTable()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                cnx.Open();
                sql = @"select * from tablee;";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt != null)
                {
                    if(dt.Rows.Count > 0)
                    {
                        ucTable[] items = new ucTable[dt.Rows.Count];
                        for(int i = 0; i < 1; i++)
                        {
                            foreach(DataRow row in dt.Rows)
                            {
                                items[i] = new ucTable();
                                items[i].nameTable.Text = "table numéro: " + row["num_tab"].ToString();
                                items[i].nbPlace.Text = row["nb_place"].ToString();
                                items[i].id = int.Parse(row["num_tab"].ToString());
                                flowLayoutPanel1.Controls.Add(items[i]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                sql = @"INSERT INTO tablee(nb_place) VALUES ("+ numericUpDown1.Value +");";
                cmd = new NpgsqlCommand(sql, cnx);
                cmd.ExecuteReader();
                MessageBox.Show("table ajoutée avec succées");
                cnx.Close();
                flowLayoutPanel1.Controls.Clear();
                SelectionTable();
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }

        private void gTable_Click(object sender, EventArgs e)
        {
            SelectionTable();
            btnAjouter.Visible = true;
            titre.Text = "Gestion des tables:";
            numericUpDown1.Visible = true;
            label1.Visible = false;
            flowDetails.Visible = false;
            panel2.Visible = false;
            comboPlat.Visible = false;
            nb_place.Visible = true;
            nomLabel.Visible = false;
            prenomLabel.Visible = false;
            btnAjouterServeur.Visible = false;
            textPrenomServeur.Visible = false;
            textNomServeur.Visible = false;
            qteLbl.Visible = false;
            numQte.Visible = false;
            ajtPlatComm.Visible = false;
            libelleLbl.Visible = false;
            prixLbl.Visible = false;
            typePlatLbl.Visible = false;
            textlibelle.Visible = false;
            comboBox1.Visible = false;
            numericUpDown2.Visible = false;
            btnAjouterPlat.Visible = false;

        }

        private void gServeur_Click(object sender, EventArgs e)
        {
            SelectionServeurs();
            btnAjouter.Visible = false;
            titre.Text = "Gestion des serveurs:";
            numericUpDown1.Visible = false;
            nb_place.Visible=false;
            nomLabel.Visible = true;
            prenomLabel.Visible = true;
            btnAjouterServeur.Visible = true;
            textPrenomServeur.Visible = true;
            label1.Visible = false;
            flowDetails.Visible = false;
            panel2.Visible = false;
            comboPlat.Visible = false;
            textNomServeur.Visible = true;
            qteLbl.Visible = false;
            numQte.Visible = false;
            ajtPlatComm.Visible = false;
            libelleLbl.Visible = false;
            prixLbl.Visible = false;
            typePlatLbl.Visible = false;
            textlibelle.Visible = false;
            comboBox1.Visible = false;
            numericUpDown2.Visible = false;
            btnAjouterPlat.Visible = false;
        }

        private void btnAjouterServeur_Click(object sender, EventArgs e)
        {
            if(btnAjouterServeur.Text == "Enregistrer")
            {
                try
                {
                    cnx.Open();
                    sql = @"select * from update_serveur("+id_ser+",'"+textNomServeur.Text+"','"+textPrenomServeur.Text+"');";
                    cmd = new NpgsqlCommand(sql, cnx);
                    cmd.ExecuteReader();
                    MessageBox.Show("serveur modifié avec succées");
                    cnx.Close();
                    flowLayoutPanel1.Controls.Clear();
                    SelectionServeurs();
                }
                catch (Exception ex)
                {
                    cnx.Close();
                    MessageBox.Show("something is wrong" + ex.Message);
                }
                btnAjouterServeur.Text = "Ajouter";
                textPrenomServeur.Text = "";
                textNomServeur.Text = "";
                btnAnnuler.Visible = false;
                // MessageBox.Show("id=: " + id_ser);
            }
            else
            {
                try
                {
                    cnx.Open();
                    sql = @"INSERT INTO serveur(nom,prenom) VALUES ('" + textNomServeur.Text + "','"+ textPrenomServeur.Text + "');";
                    cmd = new NpgsqlCommand(sql, cnx);
                    cmd.ExecuteReader();
                    MessageBox.Show("serveur ajouté avec succées");
                    cnx.Close();
                    flowLayoutPanel1.Controls.Clear();
                    SelectionServeurs();
                    btnAjouterServeur.Text = "Ajouter";
                }
                catch (Exception ex)
                {
                    cnx.Close();
                    MessageBox.Show("something is wrong" + ex.Message);
                }
                btnAjouterServeur.Text = "Enregistrer";
                textPrenomServeur.Text = "";
                textNomServeur.Text = "";
            }
            
        }

        public void SelectionServeurs()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                cnx.Open();
                sql = @"select * from serveur;";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ucServeur[] items = new ucServeur[dt.Rows.Count];
                        for (int i = 0; i < 1; i++)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                items[i] = new ucServeur(this);
                                items[i].nomServeur.Text = "Nom: " + row["nom"].ToString();
                                items[i].prenomServeur.Text = "Prenom: " + row["prenom"].ToString();
                                items[i].id = Int32.Parse(row["num_ser"].ToString());

                                flowLayoutPanel1.Controls.Add(items[i]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            switch (titre.Text)
            {
                case "Gestion des tables:":
                    SelectionTable();
                    break;
                case "Gestion des serveurs:":
                    SelectionServeurs();
                    break;
                case "Gestion des plats:":
                    break;

            }
        }

        private void gPlat_Click(object sender, EventArgs e)
        {
            btnAjouter.Visible = false;
            titre.Text = "Gestion des Plats:";
            numericUpDown1.Visible = false;
            nb_place.Visible = false;
            nomLabel.Visible = false;
            prenomLabel.Visible = false;
            flowDetails.Visible = false;
            panel2.Visible = false;
            btnAjouterServeur.Visible = false;
            textPrenomServeur.Visible = false;
            textNomServeur.Visible = false;
            label1.Visible = false;
            comboPlat.Visible = false;
            qteLbl.Visible = false;
            numQte.Visible = false;
            ajtPlatComm.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            SelectionPlats();
            libelleLbl.Visible = true;
            prixLbl.Visible = true;
            typePlatLbl.Visible = true;
            textlibelle.Visible = true;
            comboBox1.Visible = true;
            numericUpDown2.Visible = true;
            btnAjouterPlat.Visible = true;
        }
        public void SelectionPlats()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                cnx.Open();
                sql = @"select * from plat;";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ucPlat[] items = new ucPlat[dt.Rows.Count];
                       
                            foreach (DataRow row in dt.Rows)
                            {
                                items[0] = new ucPlat(this);
                                items[0].libelle.Text = "Libelle: " + row["libelle"].ToString();
                                items[0].prix.Text = "Prix: " + row["prix"].ToString()+" DH";
                                items[0].typePlat.Text = "Type du plat: " + row["type_plat"].ToString();
                                items[0].id = Int32.Parse(row["code_plat"].ToString());
                                flowLayoutPanel1.Controls.Add(items[0]);
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }

        

        private void btnAjouterPlat_Click(object sender, EventArgs e)
        {
            if (btnAjouterPlat.Text == "Enregistrer")
            {
                try
                {
                    cnx.Open();
                    sql = @"select * from update_plat(" + code_plat + ",'" + textlibelle.Text + "','" + comboBox1.SelectedItem + "',"+numericUpDown2.Value+");";
                    cmd = new NpgsqlCommand(sql, cnx);
                    cmd.ExecuteReader();
                    MessageBox.Show("plat modifié avec succées");
                    cnx.Close();
                    flowLayoutPanel1.Controls.Clear();
                    SelectionPlats();
                }
                catch (Exception ex)
                {
                    cnx.Close();
                    MessageBox.Show("something is wrong" + ex.Message);
                }
                btnAjouterPlat.Text = "Ajouter";
                textlibelle.Text = "";
                numericUpDown2.Text = "0";
                btnAnnuer2.Visible = false;
                // MessageBox.Show("id=: " + id_ser);
            }
            else
            {
                try
                {
                    cnx.Open();
                    sql = @"INSERT INTO plat(libelle,type_plat,prix) VALUES ('" + textlibelle.Text + "','" + comboBox1.SelectedItem + "','" + numericUpDown2.Value + "');";
                    cmd = new NpgsqlCommand(sql, cnx);
                    cmd.ExecuteReader();
                    MessageBox.Show("plat ajouté avec succées");
                    cnx.Close();
                    flowLayoutPanel1.Controls.Clear();
                    SelectionPlats();
                    textlibelle.Text = "";

                }
                catch (Exception ex)
                {
                    cnx.Close();
                    MessageBox.Show("something is wrong" + ex.Message);
                }
                btnAjouterPlat.Text = "Ajouter";
                textlibelle.Text = "";
                numericUpDown2.Text = "0";
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            btnAnnuler.Visible = false;
            textNomServeur.Text = "";
            textPrenomServeur.Text = "";
            btnAjouterServeur.Text = "Ajouter";
        }

        private void btnAnnuer2_Click(object sender, EventArgs e)
        {
            textlibelle.Text = "";
            btnAjouterPlat.Text = "Ajouter";
            btnAnnuer2.Visible = false;
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            nomLabel.Visible = false;
            prenomLabel.Visible = false;
            btnAjouterServeur.Visible = false;
            textPrenomServeur.Visible = false;
            textNomServeur.Visible = false;
            btnAnnuler.Visible = false;
            libelleLbl.Visible = false;
            flowDetails.Visible = false;
            panel2.Visible = false;
            prixLbl.Visible = false;
            typePlatLbl.Visible = false;
            textlibelle.Visible = false;
            comboBox1.Visible = false;
            ajtPlatComm.Visible = false;
            numericUpDown2.Visible = false;
            //ucMontant2.Visible = false;
            btnAjouterPlat.Visible = false;
            btnAnnuer2.Visible = false;
            btnAjouter.Visible = false;
            titre.Text = "";
            numericUpDown1.Visible = false;
            nb_place.Visible = false;
            qteLbl.Visible = false;
            numQte.Visible = false;


            SelectionComm();
        }
        public void SelectionComm()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                cnx.Open();
                sql = @"select * from commande;";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        UcCommande[] items = new UcCommande[dt.Rows.Count];

                        foreach (DataRow row in dt.Rows)
                        {
                            items[0] = new UcCommande(this);
                            items[0].modePay.Text = "Mode du paiement: " + row["mode_pay"].ToString();
                            items[0].datCmd.Text = row["date_comm"].ToString();
                            items[0].nbrPersonne.Text = row["nb_pers"].ToString()+" personnes";
                            items[0].nbTable.Text = row["num_tab"].ToString();
                            items[0].heurePay.Text = row["heure_pay"].ToString();
                            items[0].idComm = int.Parse(row["num_comm"].ToString());
                            flowLayoutPanel1.Controls.Add(items[0]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }


        private void ajtPlatComm_Click(object sender, EventArgs e)
        {
            int idPlat = 0;
            try
            {
                cnx.Open();
                sql = @"select * from plat where libelle='" + comboPlat.SelectedItem + "';";
                cmd = new NpgsqlCommand(sql, cnx);
                //cmd1.ExecuteReader();
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        idPlat = int.Parse(row["code_plat"].ToString());
                    }
                }
                MessageBox.Show("plat ajouté avec succés");
                cnx.Close();
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);

            }

            UcCommande ucComm = new UcCommande(this);
            ucComm.AjouterPlat((int)numQte.Value, idPlat,numComm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public ucMontant ucMontant=new ucMontant();
        public void initializeMontant()
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(this.ucMontant);
        }

        private void flowDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}