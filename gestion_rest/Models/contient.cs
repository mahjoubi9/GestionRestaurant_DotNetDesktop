using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rest.Models
{
    internal class contient
    {
        private int num_con;
        private int code_plat;
        private int num_comm;
        private int qte;

        public contient(int num_con, int code_plat, int num_comm, int qte)
        {
            this.num_con = num_con;
            this.code_plat = code_plat;
            this.num_comm = num_comm;
            this.qte = qte;
        }
    }
}
