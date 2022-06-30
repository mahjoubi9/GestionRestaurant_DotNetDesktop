using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rest.Models
{
    internal class table
    {
        private int num_tab;
        private int nb_pers;

        public table(int num_tab, int nb_pers)
        {
            this.num_tab = num_tab;
            this.nb_pers = nb_pers;
        }
    }
}
