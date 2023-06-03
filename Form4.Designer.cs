namespace geston_vente
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titre = new System.Windows.Forms.Label();
            this.cor = new System.Windows.Forms.Label();
            this.np = new System.Windows.Forms.Label();
            this.coordonnee = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.envoie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(324, 27);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(133, 13);
            this.titre.TabIndex = 0;
            this.titre.Text = "FACTURE DE PAIEMENT";
            // 
            // cor
            // 
            this.cor.AutoSize = true;
            this.cor.Location = new System.Drawing.Point(85, 80);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(130, 13);
            this.cor.TabIndex = 1;
            this.cor.Text = "Coordonnée de l\'enreprise";
            // 
            // np
            // 
            this.np.AutoSize = true;
            this.np.Location = new System.Drawing.Point(550, 148);
            this.np.Name = "np";
            this.np.Size = new System.Drawing.Size(123, 13);
            this.np.TabIndex = 2;
            this.np.Text = "Nom et Prénom du client";
            // 
            // coordonnee
            // 
            this.coordonnee.Location = new System.Drawing.Point(88, 97);
            this.coordonnee.Multiline = true;
            this.coordonnee.Name = "coordonnee";
            this.coordonnee.Size = new System.Drawing.Size(209, 91);
            this.coordonnee.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(553, 164);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(209, 91);
            this.nom.TabIndex = 4;
            // 
            // envoie
            // 
            this.envoie.Location = new System.Drawing.Point(359, 308);
            this.envoie.Name = "envoie";
            this.envoie.Size = new System.Drawing.Size(127, 23);
            this.envoie.TabIndex = 5;
            this.envoie.Text = "Générer la facture";
            this.envoie.UseVisualStyleBackColor = true;
            this.envoie.Click += new System.EventHandler(this.envoie_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.envoie);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.coordonnee);
            this.Controls.Add(this.np);
            this.Controls.Add(this.cor);
            this.Controls.Add(this.titre);
            this.Name = "Form4";
            this.Text = "Facture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label cor;
        private System.Windows.Forms.Label np;
        private System.Windows.Forms.TextBox coordonnee;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button envoie;
    }
}