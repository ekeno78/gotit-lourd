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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.BackColor = System.Drawing.Color.Ivory;
            this.btEnregistrer.Location = new System.Drawing.Point(681, 432);
            this.btEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btEnregistrer.TabIndex = 0;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = false;
            // 
            // btQuitter
            // 
            this.btQuitter.BackColor = System.Drawing.Color.Ivory;
            this.btQuitter.Location = new System.Drawing.Point(87, 432);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(100, 28);
            this.btQuitter.TabIndex = 1;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.DeepPink;
            this.btSupprimer.Location = new System.Drawing.Point(359, 286);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(135, 74);
            this.btSupprimer.TabIndex = 2;
            this.btSupprimer.Text = "Supprimer un client";
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btNouveau
            // 
            this.btNouveau.BackColor = System.Drawing.Color.Pink;
            this.btNouveau.Location = new System.Drawing.Point(556, 311);
            this.btNouveau.Margin = new System.Windows.Forms.Padding(4);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(225, 28);
            this.btNouveau.TabIndex = 3;
            this.btNouveau.Text = "Ajouter un nouveau client";
            this.btNouveau.UseVisualStyleBackColor = false;
            // 
            // ltUtilisateur
            // 
            this.ltUtilisateur.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ltUtilisateur.FormattingEnabled = true;
            this.ltUtilisateur.ItemHeight = 16;
            this.ltUtilisateur.Location = new System.Drawing.Point(556, 91);
            this.ltUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.ltUtilisateur.Name = "ltUtilisateur";
            this.ltUtilisateur.Size = new System.Drawing.Size(225, 180);
            this.ltUtilisateur.TabIndex = 5;
            this.ltUtilisateur.SelectedIndexChanged += new System.EventHandler(this.ltUtilisateur_SelectedIndexChanged);
            // 
            // tbIduser
            // 
            this.tbIduser.Location = new System.Drawing.Point(87, 91);
            this.tbIduser.Margin = new System.Windows.Forms.Padding(4);
            this.tbIduser.Name = "tbIduser";
            this.tbIduser.Size = new System.Drawing.Size(407, 22);
            this.tbIduser.TabIndex = 6;
            this.tbIduser.TextChanged += new System.EventHandler(this.tbIduser_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(87, 161);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(407, 22);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(87, 242);
            this.tbRole.Margin = new System.Windows.Forms.Padding(4);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(407, 22);
            this.tbRole.TabIndex = 8;
            this.tbRole.TextChanged += new System.EventHandler(this.tbRole_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Identifiant de l\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email de l\'utilisateur";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rôle de l\'utilisateur";
            // 
            // btModif
            // 
            this.btModif.BackColor = System.Drawing.Color.Coral;
            this.btModif.Location = new System.Drawing.Point(87, 286);
            this.btModif.Margin = new System.Windows.Forms.Padding(4);
            this.btModif.Name = "btModif";
            this.btModif.Size = new System.Drawing.Size(137, 74);
            this.btModif.TabIndex = 12;
            this.btModif.Text = "Enregister les modifications";
            this.btModif.UseVisualStyleBackColor = false;
            this.btModif.Click += new System.EventHandler(this.btModif_Click);
            // 
            // FrgestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 492);
            this.Controls.Add(this.btModif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRole);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbIduser);
            this.Controls.Add(this.ltUtilisateur);
            this.Controls.Add(this.btNouveau);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btEnregistrer);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btModif;
    }
}

