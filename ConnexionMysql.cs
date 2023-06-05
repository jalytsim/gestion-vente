using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Terrain
{
    internal class ConnexionMysql
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "server=localhost;username=root;password=;database=gestionter";
            MySqlConnection connexion = new MySqlConnection(sql);
            try
            {
                connexion.Open();
            }catch (MySqlException ex)
            {
                MessageBox.Show("Echec de connection à la base de donnée\n", "Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return connexion;
        }
///////////////////Terrain
        public static void AjoutTer(Data donnees)
        {
            string sql = "INSERT INTO terrains VALUES (0,@DataLieu, @DataCp, @DataSuperficie, @DataPrix, @DataDescription, @DataRefVen)";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@DataLieu", MySqlDbType.VarChar).Value = donnees.Lieu;
            cmd.Parameters.Add("@DataCp", MySqlDbType.Int32).Value = donnees.Cp;
            cmd.Parameters.Add("@DataSuperficie", MySqlDbType.Float).Value = donnees.Superficie;
            cmd.Parameters.Add("@DataPrix", MySqlDbType.Int32).Value = donnees.Prix;
            cmd.Parameters.Add("@DataDescription", MySqlDbType.Text).Value = donnees.Description;
            cmd.Parameters.Add("@DataRefVen", MySqlDbType.Int32).Value = donnees.RefVen; 
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le terrain de "+donnees.Superficie +" m² \n  situé à " + donnees.Lieu+ "\n a été ajouté avec succès","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Echec d'ajout du terrain","Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connexion.Close();
        }
        public static void ModTer(Data donnees, int ter_ref)
        {
            string sql = "UPDATE terrains SET lieu=@DataLieu, cp= @DataCp,superficie= @DataSuperficie,prix= @DataPrix,description= @DataDescription,ref_ven= @DataRefVen WHERE ref_ter="+ ter_ref+"";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@DataLieu", MySqlDbType.VarChar).Value = donnees.Lieu;
            cmd.Parameters.Add("@DataCp", MySqlDbType.Int32).Value = donnees.Cp;
            cmd.Parameters.Add("@DataSuperficie", MySqlDbType.Float).Value = donnees.Superficie;
            cmd.Parameters.Add("@DataPrix", MySqlDbType.Int32).Value = donnees.Prix;
            cmd.Parameters.Add("@DataDescription", MySqlDbType.Text).Value = donnees.Description;
            cmd.Parameters.Add("@DataRefVen", MySqlDbType.Int32).Value = donnees.RefVen;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modification terminée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Echec de la modification", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connexion.Close();
        }
        public static void SupTer(int ter_ref)
        {
            string sql = "DELETE FROM terrains WHERE ref_ter= @DataRefTer";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@DataRefTer", MySqlDbType.Int32).Value = ter_ref;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Le terrain n° " + ter_ref + " a été suppimé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Echec de la suppression", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connexion.Close();
        }
        public static void AffichTer(string requete, DataGridView dgv)
        {
            string sql = requete;
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adp.Fill(table);
            dgv.DataSource = table;
            connexion.Close();
        }
        ///////////////////////////////////Ville
        public static void AjoutVille(Ville info)
        {
            string sql = "INSERT INTO villes VALUES (@VilleCode, @VilleNomV)";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@VilleCode", MySqlDbType.Int32).Value = info.Code;
            cmd.Parameters.Add("@VilleNomV", MySqlDbType.VarChar).Value = info.NomV;
            try
            {
                if ((info.Code <101) || (info.Code >= 800))
                {
                    MessageBox.Show("Le code postal inséré n'existe pas", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La ville " + info.NomV + " a été ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (MySqlException)
            {
                MessageBox.Show("Echec d'ajout de la ville", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connexion.Close();
        }
       
        public static void ModVille(Ville info, int codev)
        {
            string sql = "UPDATE villes SET nom= @VilleNom WHERE cp="+codev+"";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@VilleNom", MySqlDbType.VarChar).Value = info.NomV;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Modification terminée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Echec de la modification", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connexion.Close();
        }
        public static void SupVille(int codev )
        {
            string sql = "DELETE FROM villes WHERE cp= @VilleCode";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@VilleCode", MySqlDbType.Int32).Value = codev;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("La ville n° " + codev + " a été suppimé avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Echec de la suppression", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connexion.Close();
        }
       
        public static int SimpleSelection(string requete, string nom)
        {
            int valeur = 0;
            string sql = requete;
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                valeur = Convert.ToInt32(dr[nom].ToString());
                dr.Close();
                connexion.Close();
                return valeur;
            }
            return valeur;

        }
        ////////////////////Combobox
        /*public static void VilleCombo(string combo)
        {
            string sql = "SELECT * FROM villes ORDER BY nom ASC";
            MySqlConnection connexion = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connexion);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adp.Fill(table);
            foreach (DataRow dr in table.Rows)
            {
                string ligne = string.Format("{0}:{1}", dr.ItemArray[0], dr.ItemArray[1]);
                combo.Items.Add(ligne);
            }
        }*/
    }
   
}
