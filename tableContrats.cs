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
        ajout_modContrats fenetre;

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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 0)
            {
                fenetre.effacer();
                fenetre.num_contUI = DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                fenetre.ref_terUI = DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                fenetre.ref_cliUI = DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                fenetre.ref_venUI = DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                fenetre.condUI = DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                fenetre.nb_pUI = (int)DataGridView1.Rows[e.RowIndex].Cells[7].Value;
                fenetre.debUI = DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                fenetre.finUI = DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                fenetre.penUI = DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();


                fenetre.modifierContrats();

                fenetre.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DbConnexion.supprimeContrats(DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DbConnexion.Search("SELECT num_cont,ref_ter,ref_cli,ref_ven,conditions,nb_paie,deb,fin,penalite FROM contrats", DataGridView1);

                }
                return;
            }

        }

        }
    }
