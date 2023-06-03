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
using MySqlX.XDevAPI;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace geston_vente
{
   
    public partial class Form1 : Form
    {
        
        
        Form2 fenetre;
        public Form1()
        {
            InitializeComponent();
            fenetre = new Form2(this);
        }
        public void afficher()
        {
            DbConnexion.Search("SELECT num_cont,ref_ter,ref_cli,ref_ven,conditions,nb_paie,deb,fin,penalite FROM contrats;", dataGridView1);
        }
        /*MySqlConnection connexion = new MySqlConnection("Server=localhost;Database=gestionter;Uid=root;Pwd=");*/
        

        private void button2_Click(object sender, EventArgs e)
        {
            fenetre.effacer();
            fenetre.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            afficher();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                fenetre.effacer();
                fenetre.num_contUI = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                fenetre.ref_terUI = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                fenetre.ref_cliUI = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                fenetre.condUI = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                fenetre.nb_pUI = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());   
                fenetre.debUI = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                fenetre.finUI = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                fenetre.penUI = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();


                fenetre.modifierContrats();
                fenetre.ShowDialog();
               
                return ;
            }
            if (e.ColumnIndex == 1) 
            {
               if(MessageBox.Show("Voulez-vous vraiment supprimer cette ligne?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DbConnexion.supprimeContrats(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    afficher();
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Créer un nouveau document PDF
Document document = new Document();

// Ajouter une page au document
Page page = document.Pages.Add();

// Créer un objet TextBuilder pour ajouter le contenu
TextBuilder textBuilder = new TextBuilder(page);

// Définir les propriétés du texte
TextState textState = new TextState
{
    FontSize = 12,
    Font = FontRepository.FindFont("Arial")
};

// Ajouter le contenu au document
string contenuTexte = "CONTRAT DE VENTE DE TERRAIN\n" +
    "-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
    "ENTRE LES SOUSSIGNES :\n" +
    "La collectivité DJIVON représentée par Monsieur DJIVON Kokou, \n" +
    "___________________, demeurant et domicilié à __________________________ majeur non\n" +
    "interdit, jouissant de ses droits civils selon son statut personnel togolais, ayant pleine\n" +
    "capacité pour contracter et disposer valablement des biens de ladite collectivité ainsi\n" +
    "qu'il le déclare expressément,\n" +
    "Ci-après désigné par le Vendeur ;\n";

TextParagraph textParagraph = new TextParagraph();
/*textParagraph.TextState = textState;
*/textParagraph.AppendLine(contenuTexte);
textBuilder.AppendParagraph(textParagraph);

// Spécifier le chemin de sortie du fichier PDF
string outputFilePath = "fichier.pdf";

// Sauvegarder le document au format PDF
document.Save(outputFilePath);

// Afficher un message de confirmation
Console.WriteLine("Le fichier PDF a été généré avec succès.");

// Attendre une entrée utilisateur pour terminer le programme
Console.ReadLine();
 }
    }
}
