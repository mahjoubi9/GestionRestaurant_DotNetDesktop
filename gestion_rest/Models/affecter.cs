using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_rest.Models
{
    internal class affecter
    {
        private int num_aff;
        private int num_tab;
        private int num_ser;

        public affecter(int num_aff, int num_tab, int num_ser)
        {
            this.num_aff = num_aff;
            this.num_tab = num_tab;
            this.num_ser = num_ser;
        }
    }
}
