namespace ProjSicilynes
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.listBoxLiaison = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.tbSecteur = new System.Windows.Forms.TextBox();
            this.tbLiaison = new System.Windows.Forms.TextBox();
            this.btnModifSecteur = new System.Windows.Forms.Button();
            this.btnSuppSecteur = new System.Windows.Forms.Button();
            this.btnModifLiaison = new System.Windows.Forms.Button();
            this.btnSuppLiaison = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxTraversee = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.Location = new System.Drawing.Point(68, 128);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(240, 121);
            this.listBoxSecteur.TabIndex = 0;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBoxSecteur_SelectedIndexChanged);
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.Location = new System.Drawing.Point(384, 128);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(404, 121);
            this.listBoxLiaison.TabIndex = 1;
            this.listBoxLiaison.SelectedIndexChanged += new System.EventHandler(this.listBoxLiaison_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSecteur.Location = new System.Drawing.Point(18, 183);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(44, 13);
            this.lblSecteur.TabIndex = 2;
            this.lblSecteur.Text = "Secteur";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblLiaison.Location = new System.Drawing.Point(338, 183);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(40, 13);
            this.lblLiaison.TabIndex = 3;
            this.lblLiaison.Text = "Liaison";
            // 
            // tbSecteur
            // 
            this.tbSecteur.Location = new System.Drawing.Point(42, 31);
            this.tbSecteur.Name = "tbSecteur";
            this.tbSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbSecteur.TabIndex = 4;
            // 
            // tbLiaison
            // 
            this.tbLiaison.Location = new System.Drawing.Point(47, 34);
            this.tbLiaison.Name = "tbLiaison";
            this.tbLiaison.Size = new System.Drawing.Size(100, 20);
            this.tbLiaison.TabIndex = 5;
            // 
            // btnModifSecteur
            // 
            this.btnModifSecteur.Location = new System.Drawing.Point(41, 67);
            this.btnModifSecteur.Name = "btnModifSecteur";
            this.btnModifSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnModifSecteur.TabIndex = 6;
            this.btnModifSecteur.Text = "Modifier";
            this.btnModifSecteur.UseVisualStyleBackColor = true;
            this.btnModifSecteur.Click += new System.EventHandler(this.btnModifSecteur_Click);
            // 
            // btnSuppSecteur
            // 
            this.btnSuppSecteur.Location = new System.Drawing.Point(35, 58);
            this.btnSuppSecteur.Name = "btnSuppSecteur";
            this.btnSuppSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnSuppSecteur.TabIndex = 7;
            this.btnSuppSecteur.Text = "Supprimer";
            this.btnSuppSecteur.UseVisualStyleBackColor = true;
            // 
            // btnModifLiaison
            // 
            this.btnModifLiaison.Location = new System.Drawing.Point(45, 67);
            this.btnModifLiaison.Name = "btnModifLiaison";
            this.btnModifLiaison.Size = new System.Drawing.Size(75, 23);
            this.btnModifLiaison.TabIndex = 8;
            this.btnModifLiaison.Text = "Modifier";
            this.btnModifLiaison.UseVisualStyleBackColor = true;
            this.btnModifLiaison.Click += new System.EventHandler(this.btnModifLiaison_Click);
            // 
            // btnSuppLiaison
            // 
            this.btnSuppLiaison.Location = new System.Drawing.Point(30, 53);
            this.btnSuppLiaison.Name = "btnSuppLiaison";
            this.btnSuppLiaison.Size = new System.Drawing.Size(75, 23);
            this.btnSuppLiaison.TabIndex = 9;
            this.btnSuppLiaison.Text = "Supprimer";
            this.btnSuppLiaison.UseVisualStyleBackColor = true;
            this.btnSuppLiaison.Click += new System.EventHandler(this.btnSuppLiaison_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnModifSecteur);
            this.groupBox1.Controls.Add(this.tbSecteur);
            this.groupBox1.Location = new System.Drawing.Point(27, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise à jour du secteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.btnSuppSecteur);
            this.groupBox2.Location = new System.Drawing.Point(198, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression du secteur";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbLiaison);
            this.groupBox3.Controls.Add(this.btnModifLiaison);
            this.groupBox3.Location = new System.Drawing.Point(384, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 109);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mise à jour Liaison";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Duree";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox4.Controls.Add(this.btnSuppLiaison);
            this.groupBox4.Location = new System.Drawing.Point(601, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 100);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supprimer une Liaison";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Admin";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox5.Controls.Add(this.btnConfirmer);
            this.groupBox5.Controls.Add(this.tbDuree);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(384, 390);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(358, 110);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ajouter une Liaison";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(61, 62);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 19;
            this.btnConfirmer.Text = "Ajouter";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(61, 34);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(100, 20);
            this.tbDuree.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(234, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Port arrivée";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Port départ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duree";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nombre de Liaison";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(384, 51);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 71);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // listBoxTraversee
            // 
            this.listBoxTraversee.FormattingEnabled = true;
            this.listBoxTraversee.Location = new System.Drawing.Point(27, 392);
            this.listBoxTraversee.Name = "listBoxTraversee";
            this.listBoxTraversee.Size = new System.Drawing.Size(317, 108);
            this.listBoxTraversee.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.listBoxTraversee);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.listBoxLiaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxLiaison;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.TextBox tbSecteur;
        private System.Windows.Forms.TextBox tbLiaison;
        private System.Windows.Forms.Button btnModifSecteur;
        private System.Windows.Forms.Button btnSuppSecteur;
        private System.Windows.Forms.Button btnModifLiaison;
        private System.Windows.Forms.Button btnSuppLiaison;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBoxTraversee;
    }
}

