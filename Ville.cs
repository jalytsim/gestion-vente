using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain
{
    internal class Ville
    {
        public int Code { get; set; }
        public string NomV { get; set; }
        public Ville(int code, string nomV)
        {
            this.Code = code;
            this.NomV = nomV;
        }
    }
}
