using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geston_vente
{
    internal class contrats
    {
        public string num_cont { get; set; }
        public string ref_ter { get; set; }
        public string ref_cli { get; set; }
        public string ref_ven { get; set; }
        public string cond { get; set; }
        public int nb_p { get; set; }
        public DateTime deb { get; set; }
        public DateTime fin { get; set; }

        public string pen { get; set; }

        public contrats(string num_cont, string ref_ter, string ref_cli, string ref_ven, string cond, int nb_p, DateTime deb, DateTime fin, String pen)
        {
            this.num_cont = num_cont;
            this.ref_ter = ref_ter;
            this.ref_cli = ref_cli;
            this.ref_ven = ref_ven;
            this.cond = cond;
            this.nb_p = nb_p;
            this.deb = deb;
            this.fin = fin;
            this.pen = pen;
        }
    }
}
