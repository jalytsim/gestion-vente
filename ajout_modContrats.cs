﻿using System;
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
    public partial class ajout_modContrats : Form
    {
        private readonly acceuilContrat _parent;
        public string num_contUI, ref_terUI, ref_cliUI, ref_venUI, condUI, penUI, debUI, finUI;
        public int nb_pUI;
       /* public DateTime debUI;
        public DateTime finUI;*/
        public ajout_modContrats(acceuilContrat parent)
        {
             InitializeComponent();
            _parent = parent;
        }

        public void modifierContrats()
        {
            button1.Text = "Modifier";
            num_contUIlab.Text = num_contUI.ToString();
            ref_ter.Text = ref_terUI;
            ref_cli.Text = ref_cliUI;
            ref_ven.Text = ref_venUI;
            cond.Text = condUI;
            nb_p.Value = nb_pUI;
            deb.Text = debUI;
            fin.Text = finUI;
            pen.Text = penUI;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        public void effacer()
        {
         cond.Text = fin.Text = deb.Text = pen.Text = num_contUIlab.Text = ref_ven.Text = ref_ter.Text = ref_cli.Text = string.Empty;
        }
        static string GenererNumContrat(int length)
        {
            const string chars = "0123456789";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            sb.Append("CO"); // Ajouter les deux premières lettres "CO"

            for (int i = 2; i < length; i++) // Commencer à l'index 2 pour éviter de générer des lettres supplémentaires
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*int text2 = int.Parse(ref_ter.Text.Trim());
            if(ref_cli.Text.Trim().Length < 3)
            {
                MessageBox.Show("Observation vide");
                return;
            }
            if (ref_ter.Text.Trim().Length == 0)
            {
                MessageBox.Show("Montant vide");
                return;
            }*/

            if (button1.Text == "Enregistrer")
            {
                string num_cont = GenererNumContrat(8);
                contrats contrat = new contrats(
                    num_cont,
                    ref_ter.Text,
                    ref_cli.Text,
                    ref_ven.Text,
                    cond.Text,
                    int.Parse(nb_p.Text),
                    DateTime.Parse(deb.Text),
                    DateTime.Parse(fin.Text),
                    pen.Text
                );
                DbConnexion.ajoutContrats(contrat);
                effacer();
            }

            if (button1.Text == "Modifier")
            {
                string num_cont = num_contUIlab.Text;
                contrats p = new contrats(
                    num_cont,
                    ref_ter.Text,
                    ref_cli.Text,
                    ref_ven.Text,
                    cond.Text,
                    int.Parse(nb_p.Text),
                    DateTime.Parse(deb.Text),
                    DateTime.Parse(fin.Text),
                    pen.Text
                    );
                    DbConnexion.modifierContrats(p,num_contUI);
                
            }
            _parent.afficher();
            

        }
    }
}
