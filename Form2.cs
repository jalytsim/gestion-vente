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
    public partial class Form2 : Form
    {
        private readonly acceuilContrat _parent;
        public string num_contUI, ref_terUI, ref_cliUI, ref_venUI, condUI, penUI, debUI, finUI;
        public int nb_pUI;
       /* public DateTime debUI;
        public DateTime finUI;*/
        public Form2(acceuilContrat parent)
        {
             InitializeComponent();
            _parent = parent;
        }

        public void modifierContrats()
        {
            button1.Text = "Modifier";
            num_cont.Text = num_contUI.ToString();
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
           ref_ter.Text = ref_cli.Text = string.Empty;
        }
        static string GenererNumContrat(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int text2 = int.Parse(ref_ter.Text.Trim());
            if(ref_cli.Text.Trim().Length < 3)
            {
                MessageBox.Show("Observation vide");
                return;
            }
            if (ref_ter.Text.Trim().Length == 0)
            {
                MessageBox.Show("Montant vide");
                return;
            }

            if (button1.Text == "Enregistrer")
            {
                string num_cont = GenererNumContrat(10);
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
                string num_cont = pen.Text;
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
                effacer();
            }
            _parent.afficher();
            

        }
    }
}
