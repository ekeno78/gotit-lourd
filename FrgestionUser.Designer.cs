namespace GOTIT
{
    partial class FrgestionUser
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
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btNouveau = new System.Windows.Forms.Button();
            this.ltUtilisateur = new System.Windows.Forms.ListBox();
            this.tbIduser = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.BackColor = System.Drawing.Color.Ivory;
            this.btEnregistrer.Location = new System.Drawing.Point(560, 467);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btEnregistrer.TabIndex = 0;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = false;
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.Ivory;
            this.btQuitter.Location = new System.Drawing.Point(25, 477);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 1;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.DeepPink;
            this.btSupprimer.Location = new System.Drawing.Point(247, 347);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(124, 23);
            this.btSupprimer.TabIndex = 2;
            this.btSupprimer.Text = "Supprimer un client";
            this.btSupprimer.UseVisualStyleBackColor = false;
            // 
            // btNouveau
            // 
            this.btNouveau.BackColor = System.Drawing.Color.Pink;
            this.btNouveau.Location = new System.Drawing.Point(65, 347);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(160, 23);
            this.btNouveau.TabIndex = 3;
            this.btNouveau.Text = "Ajouter un nouveau client";
            this.btNouveau.UseVisualStyleBackColor = false;
            // 
            // ltUtilisateur
            // 
            this.ltUtilisateur.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ltUtilisateur.FormattingEnabled = true;
            this.ltUtilisateur.Location = new System.Drawing.Point(465, 54);
            this.ltUtilisateur.Name = "ltUtilisateur";
            this.ltUtilisateur.Size = new System.Drawing.Size(170, 316);
            this.ltUtilisateur.TabIndex = 5;
            this.ltUtilisateur.SelectedIndexChanged += new System.EventHandler(this.ltUtilisateur_SelectedIndexChanged);
            // 
            // tbIduser
            // 
            this.tbIduser.Location = new System.Drawing.Point(65, 74);
            this.tbIduser.Name = "tbIduser";
            this.tbIduser.Size = new System.Drawing.Size(306, 20);
            this.tbIduser.TabIndex = 6;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(65, 131);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(306, 20);
            this.tbPrenom.TabIndex = 7;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(65, 197);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(306, 20);
            this.tbNom.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id de l\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prénom de l\'utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom de l\'utilisateur";
            // 
            // btRole
            // 
            this.btRole.BackColor = System.Drawing.Color.Coral;
            this.btRole.Location = new System.Drawing.Point(65, 239);
            this.btRole.Name = "btRole";
            this.btRole.Size = new System.Drawing.Size(78, 47);
            this.btRole.TabIndex = 12;
            this.btRole.Text = "Editer le rôle ";
            this.btRole.UseVisualStyleBackColor = false;
            // 
            // FrgestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 532);
            this.Controls.Add(this.btRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbIduser);
            this.Controls.Add(this.ltUtilisateur);
            this.Controls.Add(this.btNouveau);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btEnregistrer);
            this.Name = "FrgestionUser";
            this.Text = "FrGestionUser";
            this.Load += new System.EventHandler(this.FrgestionUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.ListBox ltUtilisateur;
        private System.Windows.Forms.TextBox tbIduser;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRole;
    }
}

