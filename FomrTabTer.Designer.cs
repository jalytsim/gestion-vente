namespace Terrain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            cp = new DataGridViewTextBoxColumn();
            vnom = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            label8 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblAvertV1 = new Label();
            lblAvertV2 = new Label();
            label7 = new Label();
            btnEnr = new Button();
            label6 = new Label();
            button3 = new Button();
            txtCodev = new TextBox();
            txtNomv = new TextBox();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            btnRech = new Button();
            numPrix = new NumericUpDown();
            lblMax = new Label();
            trbSup = new TrackBar();
            cmbVille = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            colRef = new DataGridViewTextBoxColumn();
            colieu = new DataGridViewTextBoxColumn();
            colcp = new DataGridViewTextBoxColumn();
            colsup = new DataGridViewTextBoxColumn();
            colprix = new DataGridViewTextBoxColumn();
            coldescr = new DataGridViewTextBoxColumn();
            colven = new DataGridViewTextBoxColumn();
            btnmodify = new DataGridViewButtonColumn();
            btndelete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnNew = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbSup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1174, 697);
            tabControl1.TabIndex = 7;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1166, 664);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Villes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1154, 596);
            panel2.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { cp, vnom, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            dataGridView2.Location = new Point(525, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(619, 519);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // cp
            // 
            cp.DataPropertyName = "cp";
            cp.HeaderText = "Code Postale";
            cp.MinimumWidth = 6;
            cp.Name = "cp";
            cp.ReadOnly = true;
            cp.Width = 125;
            // 
            // vnom
            // 
            vnom.DataPropertyName = "Nom";
            vnom.HeaderText = "Nom";
            vnom.MinimumWidth = 6;
            vnom.Name = "vnom";
            vnom.ReadOnly = true;
            vnom.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.FlatStyle = FlatStyle.Flat;
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Text = "Modifier";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.FlatStyle = FlatStyle.Flat;
            dataGridViewButtonColumn2.HeaderText = "";
            dataGridViewButtonColumn2.MinimumWidth = 6;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.ReadOnly = true;
            dataGridViewButtonColumn2.Text = "Supprimer";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn2.Width = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(160, 56);
            label8.Name = "label8";
            label8.Size = new Size(151, 46);
            label8.TabIndex = 8;
            label8.Text = "Insertion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(787, 58);
            label5.Name = "label5";
            label5.Size = new Size(97, 46);
            label5.TabIndex = 0;
            label5.Text = "Villes";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(lblAvertV1);
            panel3.Controls.Add(lblAvertV2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnEnr);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(txtCodev);
            panel3.Controls.Add(txtNomv);
            panel3.Location = new Point(14, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 295);
            panel3.TabIndex = 7;
            // 
            // lblAvertV1
            // 
            lblAvertV1.AutoSize = true;
            lblAvertV1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvertV1.ForeColor = Color.Transparent;
            lblAvertV1.Location = new Point(16, 152);
            lblAvertV1.Name = "lblAvertV1";
            lblAvertV1.Size = new Size(145, 15);
            lblAvertV1.TabIndex = 10;
            lblAvertV1.Text = "Veuillez remplir ce champ!";
            // 
            // lblAvertV2
            // 
            lblAvertV2.AutoSize = true;
            lblAvertV2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvertV2.ForeColor = Color.Transparent;
            lblAvertV2.Location = new Point(16, 67);
            lblAvertV2.Name = "lblAvertV2";
            lblAvertV2.Size = new Size(145, 15);
            lblAvertV2.TabIndex = 10;
            lblAvertV2.Text = "Veuillez remplir ce champ!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 99);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 6;
            label7.Text = "Nom de la ville";
            // 
            // btnEnr
            // 
            btnEnr.Location = new Point(395, 254);
            btnEnr.Name = "btnEnr";
            btnEnr.Size = new Size(94, 29);
            btnEnr.TabIndex = 8;
            btnEnr.Text = "Ajouter";
            btnEnr.UseVisualStyleBackColor = true;
            btnEnr.Click += btnEnr_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 17);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 5;
            label6.Text = "Code Postal";
            // 
            // button3
            // 
            button3.Location = new Point(286, 254);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Annuler";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtCodev
            // 
            txtCodev.Location = new Point(16, 40);
            txtCodev.Name = "txtCodev";
            txtCodev.Size = new Size(125, 27);
            txtCodev.TabIndex = 3;
            // 
            // txtNomv
            // 
            txtNomv.Location = new Point(16, 122);
            txtNomv.Name = "txtNomv";
            txtNomv.Size = new Size(473, 27);
            txtNomv.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1166, 664);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Terrains";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRech);
            groupBox1.Controls.Add(numPrix);
            groupBox1.Controls.Add(lblMax);
            groupBox1.Controls.Add(trbSup);
            groupBox1.Controls.Add(cmbVille);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(2, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 375);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtres";
            // 
            // btnRech
            // 
            btnRech.Location = new Point(45, 313);
            btnRech.Name = "btnRech";
            btnRech.Size = new Size(94, 29);
            btnRech.TabIndex = 7;
            btnRech.Text = "Rechercher";
            btnRech.UseVisualStyleBackColor = true;
            btnRech.Click += btnRech_Click;
            // 
            // numPrix
            // 
            numPrix.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            numPrix.Location = new Point(19, 134);
            numPrix.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrix.Name = "numPrix";
            numPrix.Size = new Size(151, 27);
            numPrix.TabIndex = 6;
            numPrix.Click += numPrix_Click;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(76, 252);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(17, 20);
            lblMax.TabIndex = 4;
            lblMax.Text = "0";
            // 
            // trbSup
            // 
            trbSup.Location = new Point(28, 216);
            trbSup.Name = "trbSup";
            trbSup.Size = new Size(130, 56);
            trbSup.TabIndex = 5;
            trbSup.ValueChanged += trbSup_ValueChanged;
            // 
            // cmbVille
            // 
            cmbVille.FormattingEnabled = true;
            cmbVille.Location = new Point(19, 57);
            cmbVille.Name = "cmbVille";
            cmbVille.Size = new Size(151, 28);
            cmbVille.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 193);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 2;
            label4.Text = "Superficie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 111);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 1;
            label3.Text = "Prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 34);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Villes";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colRef, colieu, colcp, colsup, colprix, coldescr, colven, btnmodify, btndelete });
            dataGridView1.Location = new Point(206, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(946, 519);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // colRef
            // 
            colRef.DataPropertyName = "ref_ter";
            colRef.FillWeight = 64.37166F;
            colRef.HeaderText = "Réf";
            colRef.MinimumWidth = 6;
            colRef.Name = "colRef";
            colRef.ReadOnly = true;
            colRef.Resizable = DataGridViewTriState.False;
            colRef.Width = 67;
            // 
            // colieu
            // 
            colieu.DataPropertyName = "lieu";
            colieu.FillWeight = 64.37166F;
            colieu.HeaderText = "Lieu";
            colieu.MinimumWidth = 6;
            colieu.Name = "colieu";
            colieu.ReadOnly = true;
            colieu.Width = 68;
            // 
            // colcp
            // 
            colcp.DataPropertyName = "cp";
            colcp.FillWeight = 385.0267F;
            colcp.HeaderText = "Code Postal";
            colcp.MinimumWidth = 6;
            colcp.Name = "colcp";
            colcp.ReadOnly = true;
            colcp.Resizable = DataGridViewTriState.False;
            colcp.Width = 403;
            // 
            // colsup
            // 
            colsup.DataPropertyName = "superficie";
            colsup.FillWeight = 64.37166F;
            colsup.HeaderText = "Superficie (m²)";
            colsup.MinimumWidth = 6;
            colsup.Name = "colsup";
            colsup.ReadOnly = true;
            colsup.Width = 68;
            // 
            // colprix
            // 
            colprix.DataPropertyName = "prix";
            colprix.FillWeight = 64.37166F;
            colprix.HeaderText = "Prix (Ar)";
            colprix.MinimumWidth = 6;
            colprix.Name = "colprix";
            colprix.ReadOnly = true;
            colprix.Width = 67;
            // 
            // coldescr
            // 
            coldescr.DataPropertyName = "description";
            coldescr.FillWeight = 64.37166F;
            coldescr.HeaderText = "Description";
            coldescr.MinimumWidth = 6;
            coldescr.Name = "coldescr";
            coldescr.ReadOnly = true;
            coldescr.Width = 68;
            // 
            // colven
            // 
            colven.DataPropertyName = "ref_ven";
            colven.FillWeight = 64.37166F;
            colven.HeaderText = "Référence Vendeur";
            colven.MinimumWidth = 6;
            colven.Name = "colven";
            colven.ReadOnly = true;
            colven.Resizable = DataGridViewTriState.False;
            colven.Width = 67;
            // 
            // btnmodify
            // 
            btnmodify.FillWeight = 64.37166F;
            btnmodify.FlatStyle = FlatStyle.Flat;
            btnmodify.HeaderText = "";
            btnmodify.MinimumWidth = 6;
            btnmodify.Name = "btnmodify";
            btnmodify.ReadOnly = true;
            btnmodify.Text = "Modifier";
            btnmodify.UseColumnTextForButtonValue = true;
            btnmodify.Width = 68;
            // 
            // btndelete
            // 
            btndelete.FillWeight = 64.37166F;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.HeaderText = "";
            btndelete.MinimumWidth = 6;
            btndelete.Name = "btndelete";
            btndelete.ReadOnly = true;
            btndelete.Text = "Supprimer";
            btndelete.UseColumnTextForButtonValue = true;
            btndelete.Width = 67;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(196, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 596);
            panel1.TabIndex = 8;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(10, 34);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 2;
            btnNew.Text = "Nouveau";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 29);
            label1.Name = "label1";
            label1.Size = new Size(273, 46);
            label1.TabIndex = 0;
            label1.Text = "Liste des Terrains";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 696);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbSup).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnNew;
        private Label label1;
        private DataGridView dataGridView2;
        private Panel panel2;
        private Label label5;
        private Label label8;
        private Panel panel3;
        private Label label7;
        private Button btnEnr;
        private Label label6;
        private Button button3;
        private TextBox txtCodev;
        private TextBox txtNomv;
        private DataGridViewTextBoxColumn cp;
        private DataGridViewTextBoxColumn vnom;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private Label lblAvertV1;
        private Label lblAvertV2;
        private GroupBox groupBox1;
        private Label lblMax;
        private TrackBar trbSup;
        private ComboBox cmbVille;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn colRef;
        private DataGridViewTextBoxColumn colieu;
        private DataGridViewTextBoxColumn colcp;
        private DataGridViewTextBoxColumn colsup;
        private DataGridViewTextBoxColumn colprix;
        private DataGridViewTextBoxColumn coldescr;
        private DataGridViewTextBoxColumn colven;
        private DataGridViewButtonColumn btnmodify;
        private DataGridViewButtonColumn btndelete;
        private NumericUpDown numPrix;
        private Button btnRech;
    }
}