﻿namespace geston_vente
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fin = new System.Windows.Forms.DateTimePicker();
            this.deb = new System.Windows.Forms.DateTimePicker();
            this.nb_p = new System.Windows.Forms.NumericUpDown();
            this.num_cont = new System.Windows.Forms.Label();
            this.ref_ven = new System.Windows.Forms.TextBox();
            this.ref_ter = new System.Windows.Forms.TextBox();
            this.ref_cli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nb_p)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reference Terrain ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reference Clients";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 347);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cond
            // 
            this.cond.Location = new System.Drawing.Point(220, 219);
            this.cond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cond.Name = "cond";
            this.cond.Size = new System.Drawing.Size(132, 22);
            this.cond.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de Paie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Conditions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Reference Vendeur";
            // 
            // pen
            // 
            this.pen.Location = new System.Drawing.Point(445, 185);
            this.pen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(176, 22);
            this.pen.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Penalite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Debut";
            // 
            // fin
            // 
            this.fin.Location = new System.Drawing.Point(443, 132);
            this.fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(179, 22);
            this.fin.TabIndex = 21;
            // 
            // deb
            // 
            this.deb.Location = new System.Drawing.Point(443, 76);
            this.deb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deb.Name = "deb";
            this.deb.Size = new System.Drawing.Size(179, 22);
            this.deb.TabIndex = 22;
            // 
            // nb_p
            // 
            this.nb_p.Location = new System.Drawing.Point(220, 271);
            this.nb_p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nb_p.Name = "nb_p";
            this.nb_p.Size = new System.Drawing.Size(133, 22);
            this.nb_p.TabIndex = 23;
            // 
            // num_cont
            // 
            this.num_cont.AutoSize = true;
            this.num_cont.Location = new System.Drawing.Point(36, 31);
            this.num_cont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num_cont.Name = "num_cont";
            this.num_cont.Size = new System.Drawing.Size(44, 16);
            this.num_cont.TabIndex = 27;
            this.num_cont.Text = "label2";
            // 
            // ref_ven
            // 
            this.ref_ven.Location = new System.Drawing.Point(220, 174);
            this.ref_ven.Margin = new System.Windows.Forms.Padding(4);
            this.ref_ven.Name = "ref_ven";
            this.ref_ven.Size = new System.Drawing.Size(132, 22);
            this.ref_ven.TabIndex = 28;
            // 
            // ref_ter
            // 
            this.ref_ter.Location = new System.Drawing.Point(221, 81);
            this.ref_ter.Margin = new System.Windows.Forms.Padding(4);
            this.ref_ter.Name = "ref_ter";
            this.ref_ter.Size = new System.Drawing.Size(132, 22);
            this.ref_ter.TabIndex = 29;
            // 
            // ref_cli
            // 
            this.ref_cli.Location = new System.Drawing.Point(220, 130);
            this.ref_cli.Margin = new System.Windows.Forms.Padding(4);
            this.ref_cli.Name = "ref_cli";
            this.ref_cli.Size = new System.Drawing.Size(132, 22);
            this.ref_cli.TabIndex = 30;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 449);
            this.Controls.Add(this.ref_cli);
            this.Controls.Add(this.ref_ter);
            this.Controls.Add(this.ref_ven);
            this.Controls.Add(this.num_cont);
            this.Controls.Add(this.nb_p);
            this.Controls.Add(this.deb);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nb_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fin;
        private System.Windows.Forms.DateTimePicker deb;
        private System.Windows.Forms.NumericUpDown nb_p;
        private System.Windows.Forms.Label num_cont;
        private System.Windows.Forms.TextBox ref_ven;
        private System.Windows.Forms.TextBox ref_ter;
        private System.Windows.Forms.TextBox ref_cli;
    }
}