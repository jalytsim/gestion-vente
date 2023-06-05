using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terrain
{
    public partial class FormInsertion : Form
    {
        private readonly Form1 _parent;
        public string tlieu, tcode, tpr, tsup, tdescr, tven, refter;
        
        public FormInsertion(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void ModifInfo()
        {
            lbltitre.Text = "Modifier un terrain";
            btnAjout.Text = "Enregistrer";
            txtLieu.Text = tlieu;
            txtcp.Text = tcode;
            txtPrix.Text = tpr;
            txtSup.Text = tsup;
            txtDescr.Text = tdescr;
            txtVen.Text = tven;
            txtRef.Text = refter;

        }
        public void Effacer()
        {
            txtRef.Text= txtLieu.Text = txtDescr.Text = txtcp.Text = txtPrix.Text = txtSup.Text = txtVen.Text = string.Empty;
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            int pr, code, ven, tref;
            float super;
            string li = txtLieu.Text;
            string description = txtDescr.Text;

            if (txtLieu.Text == "" | txtcp.Text == "" | txtSup.Text == "" | txtPrix.Text == "" | txtVen.Text == "")
            {
                if (txtLieu.Text == "")
                {
                    lblAvert1.ForeColor = Color.Red;
                }
                else
                {
                    lblAvert1.ForeColor = Color.Transparent;
                }
                if (txtcp.Text == "")
                {
                    lblAvert2.ForeColor = Color.Red;
                }
                else
                {
                    lblAvert2.ForeColor = Color.Transparent;
                }
                if (txtSup.Text == "")
                {
                    lblAvert3.ForeColor = Color.Red;
                }
                else
                {
                    lblAvert3.ForeColor = Color.Transparent;
                }
                if (txtPrix.Text == "")
                {
                    lblAvert4.ForeColor = Color.Red;
                }
                else
                {
                    lblAvert4.ForeColor = Color.Transparent;
                }
                if (txtVen.Text == "")
                {
                    lblAvert5.ForeColor = Color.Red;
                }
                else
                {
                    lblAvert5.ForeColor = Color.Transparent;
                }
                //MessageBox.Show("Veuillez remplir les champs nécessaires", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (btnAjout.Text == "Ajouter")
                {
                    try
                    {
                        pr = int.Parse(txtPrix.Text);
                        code = int.Parse(txtcp.Text);
                        ven = int.Parse(txtVen.Text);
                        super = float.Parse(txtSup.Text);
                        Data dt = new Data(li, code, super, pr, description, ven);
                        ConnexionMysql.AjoutTer(dt);
                        Effacer();
                    }
                    catch (FormatException)
                    {


                        MessageBox.Show("Veuillez insérez un nombre entier dans le champ Prix", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                }
                else
                {

                    try
                    {
                        tref = int.Parse(txtRef.Text);
                        pr = int.Parse(txtPrix.Text);
                        code = int.Parse(txtcp.Text);
                        ven = int.Parse(txtVen.Text);
                        super = float.Parse(txtSup.Text);
                        Data dt = new Data(li, code, super, pr, description, ven);
                        ConnexionMysql.ModTer(dt, tref);
                        Effacer();
                    }
                    catch (FormatException)
                    {


                        MessageBox.Show("Veuillez insérez un nombre entier dans le champ Prix", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                }
            }
            _parent.Afficher();
        }

        private void btnAnnul_Click(object sender, EventArgs e)
        {
            Effacer();
        }
    }
}
