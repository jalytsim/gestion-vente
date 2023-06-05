using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain
{
    internal class Data
    {
        public string Lieu { get; set; }
        public int Cp { get; set; }
        public float  Superficie { get; set; }
        public int Prix { get; set; }
        public string Description { get; set; }
        public int RefVen { get; set; }

        public Data(string lieu, int cp, float superficie, int prix, string description, int refVen)
        {
            this.Lieu = lieu;
            this.Cp = cp;
            this.Superficie = superficie;
            this.Prix = prix;
            this.Description = description;
            this.RefVen = refVen;
        }
       
    }

}
