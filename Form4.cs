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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void envoie_Click(object sender, EventArgs e)
        {
            genererPDF();
        }
        public void genererPDF()
        {
            MessageBox.Show("Parfait");
        }
    }
}
