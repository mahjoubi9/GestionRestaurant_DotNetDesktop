using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_rest.UC
{
    public partial class ucServeur : UserControl
    {
        public Form1 form1 = new Form1();
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "gestion_rest");
        private NpgsqlConnection cnx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        public ucServeur(Form1 form)
        {
            cnx = new NpgsqlConnection(cc);
            InitializeComponent();
            this.form1 = form;
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                sql = @"DELETE FROM serveur WHERE num_ser= (" + id + ");";
                cmd = new NpgsqlCommand(sql, cnx);
                cmd.ExecuteReader();
                MessageBox.Show("serveur suppririmé avec succées");
                this.form1.SelectionServeurs();
                cnx.Close();
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }

        private void ucServeur_Load(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.form1.id_ser = id;
            this.form1.textPrenomServeur.Text = "";
            this.form1.textNomServeur.Text = "";
            string[] list = Regex.Split(prenomServeur.Text, @"Prenom: ");
            string[] list1 = Regex.Split(nomServeur.Text, @"Nom: ");
            foreach (string item in list)
            {
                this.form1.textPrenomServeur.Text += item;
            }
            foreach (string item in list1)
            {
                this.form1.textNomServeur.Text += item;
            }
            this.form1.btnAjouterServeur.Text = "Enregistrer";
            this.form1.btnAnnuler.Visible = true;
        }
    }
}
