using gestion_rest.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_rest.UC
{
    public partial class ucTable : UserControl
    {
        public int id;

        public ucTable()
        {
            InitializeComponent();
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            
            reservationForm fr = new reservationForm(id, int.Parse(nbPlace.Text.ToString()));
            fr.Show();
        }

        private void ucTable_Load(object sender, EventArgs e)
        {

        }
    }
}
