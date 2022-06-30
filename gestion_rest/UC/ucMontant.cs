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
    public partial class ucMontant : UserControl
    {
        public double montant = 0;
        public Form Form;
        public ucMontant(Form frm)
        {
            InitializeComponent();
            Form = frm;
        }
        public ucMontant()
        {
            InitializeComponent();         
        }

        private void ucMontant_Load(object sender, EventArgs e)
        {

        }
    }
}
