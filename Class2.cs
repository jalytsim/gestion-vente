using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace geston_vente
{
    //class CRUD
    internal class DbConnexion
    {
        //Pour se connecté à la base de donnée
        public static MySqlConnection DBconnexion()
        {
            string connecte = "Server=localhost;Database=gestionter;Uid=root;Pwd=";
            MySqlConnection connexion = new MySqlConnection(connecte);
            try
            {
                connexion.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Non connecté!");
            }
            return connexion;
        }

        //Pour ajouté les paiements
        public static void ajoutContrats(contrats p)
        {
            string req1 = "INSERT INTO contrats (num_cont, ref_ter, ref_cli, ref_ven, conditions, nb_paie, deb, fin, penalite) VALUES (@NumCont, @RefTer, @RefCli, @RefVen, @Conditions, @NbPaie, @Deb, @Fin, @Penalite)";
            MySqlConnection connexion = DBconnexion();
            MySqlCommand command = new MySqlCommand(req1, connexion);
            command.Parameters.AddWithValue("@NumCont", p.num_cont);
            command.Parameters.AddWithValue("@RefTer", p.ref_ter);
            command.Parameters.AddWithValue("@RefCli", p.ref_cli);
            command.Parameters.AddWithValue("@RefVen", p.ref_ven);
            command.Parameters.AddWithValue("@Conditions", p.cond);
            command.Parameters.AddWithValue("@NbPaie", p.nb_p);
            command.Parameters.AddWithValue("@Deb", p.deb);
            command.Parameters.AddWithValue("@Fin", p.fin);
            command.Parameters.AddWithValue("@Penalite", 0.5);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec succès!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ajout échoué!");
            }
            connexion.Close();
        }

        //Pour modifier les paiements
        public static void modifierContrats(contrats p, string id)
        {
            string query = "UPDATE contrats SET ref_ter=@RefTer, ref_cli=@RefCli, ref_ven=@RefVen, conditions=@Conditions, nb_paie=@NbPaie, deb=@Deb, fin=@Fin, penalite=@Penalite WHERE num_cont=@NumCont";
            MySqlConnection connexion = DBconnexion();
            MySqlCommand command = new MySqlCommand(query, connexion);
            command.Parameters.AddWithValue("@NumCont", id);
            command.Parameters.AddWithValue("@RefTer", p.ref_ter);
            command.Parameters.AddWithValue("@RefCli", p.ref_cli);
            command.Parameters.AddWithValue("@RefVen", p.ref_ven);
            command.Parameters.AddWithValue("@Conditions", p.cond);
            command.Parameters.AddWithValue("@NbPaie", p.nb_p);
            command.Parameters.AddWithValue("@Deb", p.deb);
            command.Parameters.AddWithValue("@Fin", p.fin);
            command.Parameters.AddWithValue("@Penalite", p.pen);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Modifié avec succès!");

            }
            catch (Exception)
            {
                MessageBox.Show("Modification échoué!");
            }
            connexion.Close();
        }


        //Pour supprimer les paiements
        public static void supprimeContrats(string id)
        {
            string query = "DELETE FROM contrats WHERE num_cont = @NumCont";
            MySqlConnection connexion = DBconnexion();
            MySqlCommand command = new MySqlCommand(query, connexion);
            command.Parameters.AddWithValue("@NumCont", id);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Supprimé avec succès!");
            }
            catch (Exception)
            {
                MessageBox.Show("Suppression échoué!");
            }
            connexion.Close();
        }

        public static void Search(string requête, DataGridView table)
        {
            string req1 = requête;
            MySqlConnection connexion = DBconnexion();
            MySqlCommand command1 = new MySqlCommand(req1, connexion);
            MySqlDataAdapter adapte = new MySqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapte.Fill(table1);
            table.DataSource = table1;
            connexion.Close();
        }

    }
}

