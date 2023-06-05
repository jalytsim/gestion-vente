namespace Terrain
{
    partial class FormInsertion
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
            lbltitre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblRef = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtRef = new TextBox();
            txtVen = new TextBox();
            txtDescr = new TextBox();
            txtPrix = new TextBox();
            txtSup = new TextBox();
            txtcp = new TextBox();
            txtLieu = new TextBox();
            btnAjout = new Button();
            btnAnnul = new Button();
            label10 = new Label();
            label11 = new Label();
            lblAvert1 = new Label();
            lblAvert2 = new Label();
            lblAvert3 = new Label();
            lblAvert4 = new Label();
            lblAvert5 = new Label();
            SuspendLayout();
            // 
            // lbltitre
            // 
            lbltitre.AutoSize = true;
            lbltitre.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitre.Location = new Point(308, 9);
            lbltitre.Name = "lbltitre";
            lbltitre.Size = new Size(202, 37);
            lbltitre.TabIndex = 0;
            lbltitre.Text = "Ajout de terrain";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 89);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 160);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Lieu*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 225);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Code Postale*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 285);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 4;
            label5.Text = "Superficie* (en m²)";
            // 
            // lblRef
            // 
            lblRef.AutoSize = true;
            lblRef.Location = new Point(51, 96);
            lblRef.Name = "lblRef";
            lblRef.Size = new Size(75, 20);
            lblRef.TabIndex = 5;
            lblRef.Text = "Référence";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 350);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 6;
            label7.Text = "Prix*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 412);
            label8.Name = "label8";
            label8.Size = new Size(158, 20);
            label8.TabIndex = 7;
            label8.Text = "Description (facultatif)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 481);
            label9.Name = "label9";
            label9.Size = new Size(159, 20);
            label9.TabIndex = 8;
            label9.Text = "Référence du vendeur*";
            // 
            // txtRef
            // 
            txtRef.Location = new Point(210, 98);
            txtRef.Name = "txtRef";
            txtRef.ReadOnly = true;
            txtRef.Size = new Size(111, 27);
            txtRef.TabIndex = 9;
            // 
            // txtVen
            // 
            txtVen.Location = new Point(210, 474);
            txtVen.Name = "txtVen";
            txtVen.Size = new Size(111, 27);
            txtVen.TabIndex = 11;
            // 
            // txtDescr
            // 
            txtDescr.Location = new Point(210, 409);
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new Size(422, 27);
            txtDescr.TabIndex = 12;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(210, 347);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(228, 27);
            txtPrix.TabIndex = 13;
            // 
            // txtSup
            // 
            txtSup.Location = new Point(210, 282);
            txtSup.Name = "txtSup";
            txtSup.PlaceholderText = "0000.00";
            txtSup.Size = new Size(111, 27);
            txtSup.TabIndex = 14;
            // 
            // txtcp
            // 
            txtcp.Location = new Point(210, 222);
            txtcp.Name = "txtcp";
            txtcp.Size = new Size(111, 27);
            txtcp.TabIndex = 15;
            // 
            // txtLieu
            // 
            txtLieu.Location = new Point(210, 160);
            txtLieu.Name = "txtLieu";
            txtLieu.Size = new Size(422, 27);
            txtLieu.TabIndex = 16;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(653, 593);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(94, 29);
            btnAjout.TabIndex = 17;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnAnnul
            // 
            btnAnnul.Location = new Point(538, 593);
            btnAnnul.Name = "btnAnnul";
            btnAnnul.Size = new Size(94, 29);
            btnAnnul.TabIndex = 18;
            btnAnnul.Text = "Annuler";
            btnAnnul.UseVisualStyleBackColor = true;
            btnAnnul.Click += btnAnnul_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(327, 285);
            label10.Name = "label10";
            label10.Size = new Size(28, 20);
            label10.TabIndex = 19;
            label10.Text = "m²";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(444, 350);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 20;
            label11.Text = "ariary";
            // 
            // lblAvert1
            // 
            lblAvert1.AutoSize = true;
            lblAvert1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvert1.ForeColor = Color.Transparent;
            lblAvert1.Location = new Point(210, 137);
            lblAvert1.Name = "lblAvert1";
            lblAvert1.Size = new Size(145, 15);
            lblAvert1.TabIndex = 21;
            lblAvert1.Text = "Veuillez remplir ce champ!";
            // 
            // lblAvert2
            // 
            lblAvert2.AutoSize = true;
            lblAvert2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvert2.ForeColor = Color.Transparent;
            lblAvert2.Location = new Point(210, 204);
            lblAvert2.Name = "lblAvert2";
            lblAvert2.Size = new Size(145, 15);
            lblAvert2.TabIndex = 22;
            lblAvert2.Text = "Veuillez remplir ce champ!";
            // 
            // lblAvert3
            // 
            lblAvert3.AutoSize = true;
            lblAvert3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvert3.ForeColor = Color.Transparent;
            lblAvert3.Location = new Point(210, 264);
            lblAvert3.Name = "lblAvert3";
            lblAvert3.Size = new Size(145, 15);
            lblAvert3.TabIndex = 23;
            lblAvert3.Text = "Veuillez remplir ce champ!";
            // 
            // lblAvert4
            // 
            lblAvert4.AutoSize = true;
            lblAvert4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvert4.ForeColor = Color.Transparent;
            lblAvert4.Location = new Point(210, 329);
            lblAvert4.Name = "lblAvert4";
            lblAvert4.Size = new Size(145, 15);
            lblAvert4.TabIndex = 24;
            lblAvert4.Text = "Veuillez remplir ce champ!";
            // 
            // lblAvert5
            // 
            lblAvert5.AutoSize = true;
            lblAvert5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvert5.ForeColor = Color.Transparent;
            lblAvert5.Location = new Point(210, 456);
            lblAvert5.Name = "lblAvert5";
            lblAvert5.Size = new Size(145, 15);
            lblAvert5.TabIndex = 25;
            lblAvert5.Text = "Veuillez remplir ce champ!";
            // 
            // FormInsertion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(lblAvert5);
            Controls.Add(lblAvert4);
            Controls.Add(lblAvert3);
            Controls.Add(lblAvert2);
            Controls.Add(lblAvert1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnAnnul);
            Controls.Add(btnAjout);
            Controls.Add(txtLieu);
            Controls.Add(txtcp);
            Controls.Add(txtSup);
            Controls.Add(txtPrix);
            Controls.Add(txtDescr);
            Controls.Add(txtVen);
            Controls.Add(txtRef);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblRef);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbltitre);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormInsertion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "<";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblRef;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtRef;
        private TextBox txtVen;
        private TextBox txtDescr;
        private TextBox txtPrix;
        private TextBox txtSup;
        private TextBox txtcp;
        private TextBox txtLieu;
        private Button btnAjout;
        private Button btnAnnul;
        private Label label10;
        private Label label11;
        private Label lblAvert1;
        private Label lblAvert2;
        private Label lblAvert3;
        private Label lblAvert4;
        private Label lblAvert5;
    }
}