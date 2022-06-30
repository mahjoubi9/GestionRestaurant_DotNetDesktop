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
    public partial class UcCommande : UserControl
    {
        public Form1 Form1;
        public int idComm;
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "gestion_rest");
        private NpgsqlConnection cnx;
        private NpgsqlCommand cmd;
        private String sql;
        public DataTable dt;
        public UcCommande(Form1 frm)
        {
            InitializeComponent();
            cnx=new NpgsqlConnection(cc);
            this.Form1 = frm;
        }

        private void ajoutPlat_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                this.Form1.comboPlat.Items.Clear();
                sql = @"select libelle from plat;";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        this.Form1.comboPlat.Items.Add(row["libelle"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong " + ex.Message);
            }
            this.Form1.numComm = idComm;
            this.Form1.label1.Visible = true;
            this.Form1.comboPlat.Visible = true;
            this.Form1.qteLbl.Visible = true;
            this.Form1.numQte.Visible = true;
            this.Form1.ajtPlatComm.Visible = true;
            this.Form1.flowDetails.Visible = false;
        }

        private void UcCommande_Load(object sender, EventArgs e)
        {

        }

        public void AjouterPlat(int qte,int idPlat,int cm)
        {
            try
            {
                cnx.Open();
                sql = @"INSERT INTO contient(num_comm,qte,code_plat) VALUES (" + cm + "," + qte + "," + idPlat + ");";
                cmd = new NpgsqlCommand(sql, cnx);
                cmd.ExecuteReader(); 
                cnx.Close();
                this.Form1.label1.Visible = false;
                this.Form1.comboPlat.Visible = false;
                this.Form1.qteLbl.Visible = false;
                this.Form1.numQte.Visible = false;
                this.Form1.ajtPlatComm.Visible = false;
                //selDetails();

            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            selDetails();
        }
        public void selDetails()
        {
            this.Form1.flowDetails.Visible = true;
            this.Form1.panel2.Visible = true;
            this.Form1.flowDetails.Controls.Clear();
            this.Form1.ucMontant.montant = 0;
            try
            {

                cnx.Open();
                sql = @"select qte,prix,libelle from contient natural join plat where num_comm=" + idComm + ";";
                cmd = new NpgsqlCommand(sql, cnx);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cnx.Close();
                this.Form1.ucMontant.montant = 0;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ucDetails[] items = new ucDetails[dt.Rows.Count];

                        foreach (DataRow row in dt.Rows)
                        {

                            items[0] = new ucDetails();
                            items[0].lblLabelle.Text = row["libelle"].ToString();
                            items[0].lblQte.Text = "Quantité: " + row["qte"].ToString();
                            items[0].lblPrix.Text = "Prix: " + row["prix"].ToString();
                            this.Form1.ucMontant.montant += double.Parse(row["qte"].ToString()) * double.Parse(row["prix"].ToString());
                            this.Form1.flowDetails.Controls.Add(items[0]);
                        }
                    }
                    else
                    {
                        ucNoResult ucNoResult=new ucNoResult();
                        this.Form1.ucMontant.mnt.Text = 0 + " DHs";
                        this.Form1.panel2.Visible = false;
                        this.Form1.flowDetails.Controls.Add(ucNoResult);
                    }
                }
                else
                {
                    
                    this.Form1.ucMontant.mnt.Text = 0+ " DHs";
                }
            }
            catch (Exception ex)
            {
                cnx.Close();
                MessageBox.Show("something is wrong" + ex.Message);
            }
            this.Form1.ucMontant.mnt.Text = this.Form1.ucMontant.montant + " DHs";
            this.Form1.initializeMontant();
        }
    
    }
}
