using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GOTIT
{
    public partial class FrgestionUser : Form
    {
        private User userGestion = new User();  // Création d'une instance de la classe User

        public FrgestionUser()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ltUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Vérifie si un utilisateur est réellement sélectionné
            if (ltUtilisateur.SelectedIndex != -1)
            {
                string idUser = ltUtilisateur.SelectedItem.ToString();  // Renommage de la variable
                string email = userGestion.GetUserEmail(idUser);  // Utilisation de idUser
                string role = userGestion.GetUserRole(idUser);
                tbEmail.Text = email;  // Met à jour le texte de la TextBox avec l'email de l'utilisateur
                tbIduser.Text = idUser;  // Met à jour le texte de la TextBox avec l'id de l'utilisateur
                tbRole.Text = role;  // Met à jour le texte de la TextBox avec l'id de l'utilisateur
            }
        }

        private void FrgestionUser_Load(object sender, EventArgs e)
        {
            // Utilise l'instance de User pour récupérer tous les utilisateurs
            List<string> users = userGestion.GetAllUsers();
            foreach (string user in users)
            {
                ltUtilisateur.Items.Add(user);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // vide sauf si tu veux faire un truc quand le texte change
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            // vide sauf si tu veux faire un truc quand le texte change
        }

        private void tbIduser_TextChanged(object sender, EventArgs e)
        {
            // vide sauf si tu veux faire un truc quand le texte change
        }

        private void tbRole_TextChanged(object sender, EventArgs e)
        {
            // vide sauf si tu veux faire un truc quand le texte change

        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (ltUtilisateur.SelectedIndex != -1)
            {
                string idUser = ltUtilisateur.SelectedItem.ToString();
                DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmer la suppression", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userGestion.DeleteUser(idUser);
                    RefreshUserList(); // Rafraîchir la liste après suppression
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }

        private void RefreshUserList()
        {
            ltUtilisateur.Items.Clear(); // Vide la liste existante
            List<string> users = userGestion.GetAllUsers(); // Recharge la liste des utilisateurs
            foreach (string user in users)
            {
                ltUtilisateur.Items.Add(user);
            }
        }

        private void btModif_Click(object sender, EventArgs e)
        {
            if (ltUtilisateur.SelectedIndex != -1)
            {
                string idUser = tbIduser.Text;  // Utilise l'identifiant de la TextBox id
                string email = tbEmail.Text;    // Utilise l'email de la TextBox email
                string role = tbRole.Text;      // Utilise le rôle de la TextBox role

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Veuillez vous assurer que tous les champs sont remplis.");
                    return;
                }

                userGestion.UpdateUser(idUser, email, role);
                RefreshUserList();  // Rafraîchir la liste pour refléter les changements
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.");
            }
        }

    }
}
