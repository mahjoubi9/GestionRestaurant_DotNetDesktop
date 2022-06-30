using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rest.Models
{
    internal class commande
    {
        private int num_com;
        private String heure_pay;
        private String mode_pay;
        private String date_com;
        private int nb_pers;
        private int num_tab;

        public commande(int num_com, string heure_pay, string mode_pay, string date_com, int nb_pers, int num_tab)
        {
            this.num_com = num_com;
            this.heure_pay = heure_pay;
            this.mode_pay = mode_pay;
            this.date_com = date_com;
            this.nb_pers = nb_pers;
            this.num_tab = num_tab;
        }
    }
}
