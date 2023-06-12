using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace geston_vente
{
    public partial class affichageContrat : Form
    {
        public affichageContrat()
        {
            InitializeComponent();
        }

        public void loadCont(string num_contQL)
        {
            string query = "SELECT * FROM contrats co INNER JOIN clients cl ON co.ref_cli=cl.ref_cli INNER JOIN terrains t ON co.ref_ter=t.ref_ter INNER JOIN vendeurs v ON co.ref_ven=v.ref_ven WHERE num_cont= \"CO000001\";";
            MySqlConnection connection = DbConnexion.DBconnexion();
            MySqlCommand command = new MySqlCommand(query, connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    num_cont.Text = reader.GetString(reader.GetOrdinal("num_cont"));
                    cond.Text = reader.GetString(reader.GetOrdinal("conditions"));
                    np.Text = reader.GetString(reader.GetOrdinal("nb_paie"));
                    deb.Text = reader.GetString(reader.GetOrdinal("deb"));
                    fin.Text = reader.GetString(reader.GetOrdinal("fin"));
                    pen.Text = reader.GetString(reader.GetOrdinal("penalite"));

                    //vendeur
                    ref_ven.Text = reader.GetString(reader.GetOrdinal("ref_ven"));
                    nom_ven.Text = reader.GetString(reader.GetOrdinal("nom_ven"));
                    prenom_ven.Text = reader.GetString(reader.GetOrdinal("prenoms_ven"));
                    mail_ven.Text = reader.GetString(reader.GetOrdinal("mail_ven"));
                    cin_ven.Text = reader.GetString(reader.GetOrdinal("cin_ven"));

                    //client
                    ref_cli.Text = reader.GetString(reader.GetOrdinal("ref_cli"));
                    nom_cli.Text = reader.GetString(reader.GetOrdinal("nom_cli"));
                    prenom_cli.Text = reader.GetString(reader.GetOrdinal("prenoms_cli"));
                    mail_cli.Text = reader.GetString(reader.GetOrdinal("mail_ven"));
                    cin_cli.Text = reader.GetString(reader.GetOrdinal("cin_cli"));

                    //terrain
                    ref_ter.Text = reader.GetString(reader.GetOrdinal("ref_ter"));
                    cp.Text = reader.GetString(reader.GetOrdinal("cp"));
                    lieu.Text = reader.GetString(reader.GetOrdinal("lieu"));
                    sup.Text = reader.GetString(reader.GetOrdinal("superficie"));
                    descri_ter.Text = reader.GetString(reader.GetOrdinal("description"));



                }
            }

            connection.Close();
        }
        private void back_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
