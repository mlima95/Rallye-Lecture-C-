namespace rallyeLecture
{
    partial class alimentationBdd
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
            this.tbAnnee = new System.Windows.Forms.TextBox();
            this.btnLancerIntegration = new System.Windows.Forms.Button();
            this.cbAleatoire = new System.Windows.Forms.CheckBox();
            this.cbConstruit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNiveau = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cblIntegrer = new System.Windows.Forms.CheckedListBox();
            this.cbRepertoire = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAnnee
            // 
            this.tbAnnee.Location = new System.Drawing.Point(151, 159);
            this.tbAnnee.Name = "tbAnnee";
            this.tbAnnee.Size = new System.Drawing.Size(100, 20);
            this.tbAnnee.TabIndex = 1;
            // 
            // btnLancerIntegration
            // 
            this.btnLancerIntegration.Location = new System.Drawing.Point(137, 256);
            this.btnLancerIntegration.Name = "btnLancerIntegration";
            this.btnLancerIntegration.Size = new System.Drawing.Size(147, 23);
            this.btnLancerIntegration.TabIndex = 2;
            this.btnLancerIntegration.Text = "Lancer l\'intégration";
            this.btnLancerIntegration.UseVisualStyleBackColor = true;
            // 
            // cbAleatoire
            // 
            this.cbAleatoire.AutoSize = true;
            this.cbAleatoire.Location = new System.Drawing.Point(132, 217);
            this.cbAleatoire.Name = "cbAleatoire";
            this.cbAleatoire.Size = new System.Drawing.Size(66, 17);
            this.cbAleatoire.TabIndex = 3;
            this.cbAleatoire.Text = "aléatoire";
            this.cbAleatoire.UseVisualStyleBackColor = true;
            // 
            // cbConstruit
            // 
            this.cbConstruit.AutoSize = true;
            this.cbConstruit.Location = new System.Drawing.Point(247, 217);
            this.cbConstruit.Name = "cbConstruit";
            this.cbConstruit.Size = new System.Drawing.Size(66, 17);
            this.cbConstruit.TabIndex = 4;
            this.cbConstruit.Text = "construit";
            this.cbConstruit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "fichier csv à intégrer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "année scolaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "mot de passe :";
            // 
            // cmbNiveau
            // 
            this.cmbNiveau.FormattingEnabled = true;
            this.cmbNiveau.Location = new System.Drawing.Point(150, 185);
            this.cmbNiveau.Name = "cmbNiveau";
            this.cmbNiveau.Size = new System.Drawing.Size(121, 21);
            this.cmbNiveau.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "répertoire des fichiers :";
            // 
            // cblIntegrer
            // 
            this.cblIntegrer.FormattingEnabled = true;
            this.cblIntegrer.Location = new System.Drawing.Point(151, 59);
            this.cblIntegrer.Name = "cblIntegrer";
            this.cblIntegrer.Size = new System.Drawing.Size(433, 94);
            this.cblIntegrer.TabIndex = 12;
            // 
            // cbRepertoire
            // 
            this.cbRepertoire.FormattingEnabled = true;
            this.cbRepertoire.Location = new System.Drawing.Point(151, 10);
            this.cbRepertoire.Name = "cbRepertoire";
            this.cbRepertoire.Size = new System.Drawing.Size(121, 21);
            this.cbRepertoire.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "niveau";
            // 
            // alimentationBdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRepertoire);
            this.Controls.Add(this.cblIntegrer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNiveau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConstruit);
            this.Controls.Add(this.cbAleatoire);
            this.Controls.Add(this.btnLancerIntegration);
            this.Controls.Add(this.tbAnnee);
            this.Name = "alimentationBdd";
            this.Text = "Alimentation de la base de données : Nouvelle classe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnnee;
        private System.Windows.Forms.Button btnLancerIntegration;
        private System.Windows.Forms.CheckBox cbAleatoire;
        private System.Windows.Forms.CheckBox cbConstruit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNiveau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cblIntegrer;
        private System.Windows.Forms.ComboBox cbRepertoire;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
    }
}

