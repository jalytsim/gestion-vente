﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;




namespace geston_vente
{

    public partial class acceuilContrat : Form
    {
        public static Form active;

        ajout_modContrats fenetre;
        public acceuilContrat()
        {
            InitializeComponent();
            fenetre = new ajout_modContrats(this);
        }
        public void afficher()
        {
            DbConnexion.Search("SELECT num_cont,ref_ter,ref_cli,ref_ven,conditions,nb_paie,deb,fin,penalite FROM contrats", DataGridView1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            afficher();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    afficher();
                }
                return;
            }
        }

        public void GeneratePdf()
        {
            // Declare the file path variable
            string filePath = string.Empty;

            try
            {
                // Open the save file dialog to choose the file path
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichier PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    // Create a new PDF document
                    using (Document document = new Document())
                    {
                        // Create a new PDF writer
                        using (PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create)))
                        {
                            // Open the PDF document
                            document.Open();

                            // Add content to the PDF document
                            AddContent(document, writer);

                            // Close the PDF document
                            document.Close();

                            // Display a notification
                            MessageBox.Show("PDF generated successfully!");

                            // Open the PDF with the default PDF application
                            Process.Start(filePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
        }


        private void AddContent(Document document, PdfWriter writer)
        {
            // Create a new paragraph
            Paragraph paragraph = new Paragraph();

            // Add text to the paragraph
            paragraph.Add("CONTRAT DE VENTE DE TERRAIN");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("ENTRE LES SOUSSIGNÉS :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Vendeur :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Nom : [Nom du vendeur]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Adresse : [Adresse du vendeur]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Acheteur :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Nom : [Nom de l'acheteur]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Adresse : [Adresse de l'acheteur]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("OBJET DU CONTRAT :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Le présent contrat a pour objet la vente d'un terrain situé à [Emplacement du terrain] et ayant les caractéristiques suivantes :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("- Superficie : [Superficie du terrain]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("- Description : [Description du terrain]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("- Référence cadastrale : [Référence cadastrale du terrain]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("PRIX ET CONDITIONS DE PAIEMENT :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Le prix convenu pour la vente du terrain est de [Montant en devise]. Les conditions de paiement sont les suivantes :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("- [Indiquer les conditions de paiement, par exemple : versement d'un acompte de [Montant] à la signature du contrat, suivi de [Nombre] versements mensuels de [Montant] chacun.]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("DATE DE TRANSFERT DE PROPRIÉTÉ :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("La propriété du terrain sera transférée à l'acheteur à compter de la date de signature du présent contrat.");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("OBLIGATIONS DES PARTIES :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("- Obligations du vendeur :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("  - Transférer la propriété du terrain à l'acheteur dans les délais convenus.");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("  - Garantir que le terrain est libre de tout privilège, hypothèque ou autre charge.");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("- Obligations de l'acheteur :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("  - Effectuer les paiements conformément aux conditions convenues.");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("  - Respecter toutes les obligations légales et réglementaires liées à l'acquisition du terrain.");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("PÉNALITÉ EN CAS DE DÉFAUT DE PAIEMENT :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("En cas de défaut de paiement de la part de l'acheteur, celui-ci sera tenu de payer une pénalité de [Montant ou pourcentage] sur le montant dû, calculée par [Mode de calcul de la pénalité].");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("LOI APPLICABLE ET JURIDICTION :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Le présent contrat est régi par la loi en vigueur dans [Pays ou région]. Tout litige découlant du présent contrat sera de la compétence exclusive des tribunaux de [Ville ou région].");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("SIGNATURES :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("En signant le présent contrat, les parties reconnaissent avoir pris connaissance de son contenu et en acceptent les termes et conditions.");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Fait en deux exemplaires originaux à [Lieu], le [Date].");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Signature du Vendeur :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("[Nom du Vendeur]");
            paragraph.Add(Environment.NewLine);
            paragraph.Add(Environment.NewLine);
            paragraph.Add("Signature de l'Acheteur :");
            paragraph.Add(Environment.NewLine);
            paragraph.Add("[Nom de l'Acheteur]");

            // Add the paragraph to the document
            document.Add(paragraph);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = search.Text;
            string query = "SELECT num_cont, ref_ter, ref_cli, ref_ven, conditions, nb_paie, deb, fin, penalite FROM contrats WHERE num_cont LIKE '%" + searchQuery + "%'";
            DbConnexion.Search(query, DataGridView1);
        }

        private void show_Click(object sender, EventArgs e)
        {
            affichageContrat form2 = new affichageContrat();

            // Configure the form properties
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            form2.AutoSize = true;
            form2.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Add the form to the panel's controls
            showContrat.Controls.Clear(); // Clear existing controls in the panel
            showContrat.Controls.Add(form2);

            // Show the form
            form2.Visible = true;
            form2.loadCont("CO000001");
        }

        private void back_Click(object sender, EventArgs e)
        {
            tableContrats form2 = new tableContrats();

            // Configure the form properties
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            form2.AutoSize = true;
            form2.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Add the form to the panel's controls
            showContrat.Controls.Clear(); // Clear existing controls in the panel
            showContrat.Controls.Add(form2);

            // Show the form
            form2.Visible = true;

            // Load the data into the DataGridView
            form2.LoadData();
            form2.DataGridView1.Width = 1004;
            form2.DataGridView1.Height = 420;
        }


        private void addCont_Click(object sender, EventArgs e)
        {
            fenetre.effacer();
            fenetre.ShowDialog();
        }

        private void pdfCont_Click(object sender, EventArgs e)
        {
            GeneratePdf();
        }
    }
}
