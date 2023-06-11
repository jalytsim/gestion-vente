using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geston_vente
{
    public partial class tableContrats : Form
    {
        public tableContrats()
        {
            InitializeComponent();
        }

        private void tableContrats_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            // Retrieve data from the database and populate the DataGridView
            DbConnexion.Search("SELECT num_cont, ref_ter, ref_cli, ref_ven, conditions, nb_paie, deb, fin, penalite FROM contrats", DataGridView1);
        }
    }
}
