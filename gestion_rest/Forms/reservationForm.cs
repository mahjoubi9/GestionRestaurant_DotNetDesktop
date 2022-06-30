using gestion_rest.UC;
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

namespace gestion_rest.Forms
{
    public partial class reservationForm : Form
    {
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "gestion_rest");
        private NpgsqlConnection cnx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        public int idTable;
        public int nbPlace;
        public reservationForm(int id,int nb)
        {
            InitializeComponent();
            cnx = new NpgsqlConnection(cc);
            this.idTable = id;
            this.nbPlace = nb;
            comboBox1.Items.Add("éspece");
            comboBox1.Items.Add("Carte bancaire");
            try
            {
                cnx.Open();
                sql = @"select * from serveur;";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        comboServeurs.Items.Add(row["nom"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }

        private void btnAjt_Click(object sender, EventArgs e)
        {
            int a = 0;
            cnx.Open();
            try
            {
                
                sql = @"select * from commande where num_tab=" + idTable + ";";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        
                        if (row["date_comm"].ToString() != date.Value.Day + "-" + date.Value.Month + "-" + date.Value.Year)
                        {
                            a = 1;
                        }
                        else
                        {
                            a = 0;
                            break;
                        }
                    }
                }
                else
                {
                    a = 1;
                }
               
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
           
            try
            {
                if (this.nbPlace<nbPerson.Value)
                {
                    //MessageBox.Show("l nombre de personne doit inférieur ou égale à "+ nbPlace, MessageBoxButtons.OK,MessageBoxIcon.Error);
                    var selectedOption = MessageBox.Show("le nombre de personne doit inférieur ou égale à " + nbPlace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (a==0)
                {
                    var selectedOption = MessageBox.Show("Cette table est déja réservé pour ce jour, svp choisissez une autre date!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    cnx.Open();
                    //l'ajout de la commande
                    sql = @"INSERT INTO commande(heure_pay,date_comm,mode_pay,nb_pers,num_tab) VALUES ('" + DateTime.Now.ToString("HH:mm")+ ":00+01:00" + "','"+ date.Value.Year + "-" + date.Value.Month + "-" + date.Value.Day + "','"+comboBox1.SelectedItem+"',"+nbPerson.Value+","+idTable+");";
                    cmd = new NpgsqlCommand(sql, cnx);
                    cmd.ExecuteReader();
                    //selectioner le serveur




                    String ccc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "gestion_rest");
                    NpgsqlConnection cnx1;
                    NpgsqlCommand cmd1;
                    String sql1;
                    cnx1 = new NpgsqlConnection(ccc);
                    int idSer = 0;
                    try
                    {
                        cnx1.Open();
                        sql1 = @"select * from serveur where nom='" + comboServeurs.SelectedItem + "';";
                        cmd1 = new NpgsqlCommand(sql1, cnx1);
                        //cmd1.ExecuteReader();
                        dt = new DataTable();
                        dt.Load(cmd1.ExecuteReader());
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                idSer = int.Parse(row["num_ser"].ToString());
                            }
                        }
                        MessageBox.Show("id du serveur: " + idSer + " le nom: " + comboServeurs.SelectedItem);
                    }
                    catch (Exception ex)
                    {
                        cnx1.Close();
                        MessageBox.Show("something is wrong" + ex.Message);
                        
                    }
                    //affectation du serveur
                    affecterServeur(idSer);
                    this.Dispose();
                }
                
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }
        
        public void affecterServeur(int idSer)
        {
            String ccc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "gestion_rest");
            NpgsqlConnection cnx1;
            NpgsqlCommand cmd1;
            String sql1;
            cnx1 = new NpgsqlConnection(ccc);
            try
            {
                cnx1.Open();
                sql1 = @"INSERT INTO affecter(date_affect,num_ser,num_tab) VALUES ('" + date.Value.Year + "-" + date.Value.Month + "-" + date.Value.Day + "'," + idSer + "," + idTable + ");";
                cmd1 = new NpgsqlCommand(sql1, cnx1);
                cmd1.ExecuteReader();
                cnx1.Close();
            }catch (Exception ex)
            {
                cnx1.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
            
        }

        private void reservationForm_Load(object sender, EventArgs e)
        {
            cmdTitre.Text = "Ajouter une commande à la table numéro " + idTable;
        }
    }
}
