using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geston_vente
{
     class paie
    {
        public int Contrat { get; set; }
        public int Montant { get; set; }
        public string Observation { get; set; }

        public paie(int contrat,int montant, string observation)
        {
            Contrat = contrat;
            Montant = montant;
            Observation = observation;
        }
    }
}
