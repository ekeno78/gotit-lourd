using System;
using System.Windows.Forms;

namespace GOTIT
{
    public partial class FrmLogin : Form
    {
        private User userGestion = new User();  // Création d'une instance de la classe User pour FrmLogin

        public FrmLogin()
        {
            InitializeComponent();
        }
 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string identifiant = textBox1.Text;
            string password = txtPassword.Text;

            // Utilisation de userLogin pour appeler ValidateUser
            if (userGestion.ValidateUser(identifiant, password))
            {
                this.Hide();  // Cache le formulaire de connexion
                FrgestionUser gestionUserForm = new FrgestionUser();
                gestionUserForm.ShowDialog();  // Ouvre le formulaire de gestion d'utilisateur
                this.Close();  // Ferme le formulaire de connexion après la fermeture du formulaire de gestion
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect, ou vous n'avez pas les droits d'admin.", "Erreur de Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
