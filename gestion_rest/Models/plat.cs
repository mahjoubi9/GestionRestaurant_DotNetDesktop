using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rest.Models
{
    internal class plat
    {
        private int code_plat;
        private String libelle;
        private String type_plat;
        public double prix;

        public plat(int code_plat, string libelle, string type_plat, double prix)
        {
            this.code_plat = code_plat;
            this.libelle = libelle;
            this.type_plat = type_plat;
            this.prix = prix;
        }
    }
}
