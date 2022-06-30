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
    public partial class ucPlat : UserControl
    {

        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "gestion_rest");
        private NpgsqlConnection cnx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        public Form1 form1;

        public ucPlat(Form1 form)
        {
            InitializeComponent();
            this.form1 = form;
        }
        private void Select()
        {
            try
            {
                cnx.Open();
                sql = @"select * from plat;";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();

            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }
        private void plat_Load(object sender, EventArgs e)
        {
            cnx = new NpgsqlConnection(cc);
            Select();
        }

        private void typePlat_Click(object sender, EventArgs e)
        {

        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                sql = @"DELETE FROM plat WHERE code_plat= (" + id + ");";
                cmd = new NpgsqlCommand(sql, cnx);
                cmd.ExecuteReader();
                MessageBox.Show("serveur suppririmé avec succées");
                this.form1.SelectionPlats();
                cnx.Close();
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }
        public int id;

        private void btnMod_Click(object sender, EventArgs e)
        {
            this.form1.code_plat = id;
            this.form1.textlibelle.Text = "";
            this.form1.comboBox1.Text = "";
            string[] list = Regex.Split(libelle.Text, @"Libelle: ");
            string[] list1 = Regex.Split(typePlat.Text, @"Type du plat: ");
            foreach (string item in list)
            {
                this.form1.textlibelle.Text += item;
            }
            foreach (string item in list1)
            {
                this.form1.comboBox1.Text += item;
            }
            this.form1.btnAjouterPlat.Text = "Enregistrer";
            this.form1.btnAnnuer2.Visible = true;
        }
    }
}
