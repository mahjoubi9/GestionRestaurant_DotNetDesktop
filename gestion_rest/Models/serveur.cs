using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rest.Models
{
    internal class serveur
    {
        private int num_ser;
        private string nom;
        private string prenom;

        public serveur(int num_ser, string nom, string prenom)
        {
            this.num_ser = num_ser;
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
