using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Text;

namespace Terrain
{
    public partial class Form1 : Form
    {
        private DataTable dtable;
        private int smallChangeValue1 = 100;
        private int trackValue1;
        private bool stop1 = false;
        FormInsertion form;
        public Form1()
        {
            InitializeComponent();
            form = new FormInsertion(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbVille.Text = "";
            trbSup.Maximum = ConnexionMysql.SimpleSelection("SELECT DISTINCT max(superficie) as maxim from terrains", "maxim");
            numPrix.Maximum = ConnexionMysql.SimpleSelection("SELECT DISTINCT max(prix) as maxim from terrains", "maxim");
            CmbFill();

        }
        ///////Autres
        private void CmbFill()
        {
            MySqlConnection conn = ConnexionMysql.GetConnection();
            string query = "SELECT * FROM villes ORDER BY nom asc";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dtr = cmd.ExecuteReader();
            while (dtr.Read())
            {
                cmbVille.Items.Add(dtr["nom"].ToString());
            }
            dtr.Close();
            /*MySqlDataAdapter adp = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmbVille.DataSource = dt;
            cmbVille.DisplayMember = "nom";*/
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Effacer();
            form.ShowDialog();
        }
        private void trbSup_ValueChanged(object sender, EventArgs e)
        {
            if (stop1) return;
            trackValue1 = trbSup.Value;
            if (trackValue1 % smallChangeValue1 != 0)
            {
                trackValue1 = (trackValue1 / smallChangeValue1) * smallChangeValue1;
                stop1 = true;
                trbSup.Value = trackValue1;
                stop1 = false;
            }
            lblMax.Text = trackValue1.ToString();
        }
        private void numPrix_Click(object sender, EventArgs e)
        {
            numPrix.Minimum = ConnexionMysql.SimpleSelection("SELECT DISTINCT min(prix) as maxim from terrains", "maxim");
        }
        public void Clear()
        {
            txtCodev.Text = txtNomv.Text = String.Empty;
        }
        /////////////Affichage
        public void Afficher()
        {
            ConnexionMysql.AffichTer("SELECT * FROM terrains", dataGridView1);
        }
        
        public void Afficher2()
        {
            ConnexionMysql.AffichTer("SELECT * FROM villes order by cp ASC ", dataGridView2);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Afficher();
            Afficher2();
        }

        ///////////////////////Suppression et modification
        ///Terrains/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int reft = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                form.Effacer();
                form.refter = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.tlieu = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.tcode = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.tsup = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.tpr = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.tdescr = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.tven = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.ModifInfo();
                form.ShowDialog();
                Afficher();

                return;
            }
            if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show("Voulez-vous vraiment supprimer le terrain de référence n° " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " situé à " + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + " ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ter = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    ConnexionMysql.SupTer(ter);
                    Afficher();
                }
                return;
            }
        }
        ////Villes
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnEnr.Text = "Enregistrer";
                txtCodev.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCodev.ReadOnly = true;
                txtNomv.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

                return;
            }
            if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show("Voulez-vous vraiment supprimer la ville " + dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString() + " ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ter = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
                    ConnexionMysql.SupVille(ter);
                    Afficher2();
                }
                return;
            }

        }
       
        ///////////////////////////////////////Ajout et modification des Villes
        private void btnEnr_Click(object sender, EventArgs e)
        {
            int codeV;
            string nomV = txtNomv.Text;

            if (txtNomv.Text == "" | txtCodev.Text == "")
            {
                if (txtNomv.Text == "")
                {
                    lblAvertV1.ForeColor = Color.Red;
                }
                else
                {
                    lblAvertV1.ForeColor = Color.Transparent;
                }
                if (txtCodev.Text == "")
                {
                    lblAvertV2.ForeColor = Color.Red;
                }
                else
                {
                    lblAvertV2.ForeColor = Color.Transparent;

                }
            }
            else
            {
                //try
                if (btnEnr.Text == "Ajouter")
                {
                    codeV = int.Parse(txtCodev.Text);
                    Ville dt = new Ville(codeV, nomV);
                    ConnexionMysql.AjoutVille(dt);
                    Clear();
                    Afficher2();

                }
                //catch (Exception ex)
                //{
                //MessageBox.Show("Veuillez insérez un nombre entier dans le champ Prix", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                else
                {
                    //MessageBox.Show("Veuillez insérez un nombre entier dans le champ Prix", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    codeV = int.Parse(txtCodev.Text);
                    nomV = txtNomv.Text;
                    Ville vil = new Ville(codeV, nomV);
                    ConnexionMysql.ModVille(vil, codeV);
                    txtCodev.ReadOnly = false;
                    btnEnr.Text = "Ajouter";
                    Clear();
                    Afficher2();
                }

            }
        }
 
//////////////////Filtres de recherche
        private void btnRech_Click(object sender, EventArgs e)
        {
            string cmbEmpty = cmbVille.Text, requete = "";
            int numVal = Convert.ToInt32(numPrix.Value), trbVal = trbSup.Value;
            /////////////////////Ville
            if (cmbVille.Text != "")
            {

                string cpVille = cmbVille.SelectedItem.ToString();
                requete = "select * from terrains t, villes v  where t.cp = v.cp and v.nom='" + cpVille + "'";
                if (numVal != 0)
                {
                    requete += " AND prix <=" + numVal;
                }
                if (trbVal != 0)
                {
                    requete += " AND superficie <=" + trbVal;
                }
                if (trbVal != 0  &&  numVal != 0)
                {
                    requete += " AND prix <=" + numVal + " AND superficie <=" + trbVal;
                }
                ConnexionMysql.AffichTer(requete, dataGridView1);
            }
            else
            {   
                if (numVal != 0)
                {
                    requete = "select * from terrains where prix <=" + numVal;
                    
                }
                if (trbVal != 0)
                {
                    requete = "select * from terrains where superficie <=" + trbVal;
                    
                }
                if (trbVal != 0 && numVal != 0)
                {
                    requete = "select * from terrains where superficie <="+ trbVal + " AND prix <="+ numVal;
                }
                ConnexionMysql.AffichTer(requete, dataGridView1);
            }
           
        }
    }
}