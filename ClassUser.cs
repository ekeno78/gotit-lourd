using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GOTIT
{
    public class User
    {
        private ClassADO db = new ClassADO();

        public List<string> GetAllUsers()
        {
            List<string> users = new List<string>();
            string query = "SELECT Identifiant FROM utilisateurs";
            try
            {
                using (MySqlConnection conn = db.ConnexionBase())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("Identifiant")))
                                {
                                    users.Add(reader.GetString("Identifiant"));
                                }
                                else
                                {
                                    users.Add("Identifiant non disponible");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des utilisateurs: " + ex.Message);
            }
            return users;
        }

        public string GetUserEmail(string identifiant)
        {
            string query = "SELECT Email_utilisateur FROM utilisateurs WHERE Identifiant = @Identifiant";
            try
            {
                using (MySqlConnection conn = db.ConnexionBase())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Identifiant", MySqlDbType.VarChar).Value = identifiant;
                        object email = cmd.ExecuteScalar();
                        return email != null ? email.ToString() : "Email non disponible";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération de l'email: " + ex.Message);
                return "Erreur de récupération";
            }
        }
        public string GetUserRole(string identifiant)
        {
            string query = "SELECT Role FROM utilisateurs WHERE Identifiant = @Identifiant";
            try
            {
                using (MySqlConnection conn = db.ConnexionBase())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Identifiant", MySqlDbType.VarChar).Value = identifiant;
                        object role = cmd.ExecuteScalar();
                        return role != null ? role.ToString() : "Role non disponible";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération du role: " + ex.Message);
                return "Erreur de récupération";
            }
        }
        public void DeleteUser(string identifiant)
        {
            string query = "DELETE FROM utilisateurs WHERE Identifiant = @Identifiant";
            try
            {
                using (MySqlConnection conn = db.ConnexionBase())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Identifiant", MySqlDbType.VarChar).Value = identifiant;
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Utilisateur supprimé avec succès.");
                        else
                            MessageBox.Show("Aucun utilisateur trouvé avec cet identifiant.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de l'utilisateur: " + ex.Message);
            }
        }
        public void UpdateUser(string idUser, string email, string role)
        {
            string query = "UPDATE utilisateurs SET Email_utilisateur = @Email, Role = @Role WHERE Identifiant = @Identifiant";
            try
            {
                using (MySqlConnection conn = db.ConnexionBase())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Identifiant", MySqlDbType.VarChar).Value = idUser;
                        cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@Role", MySqlDbType.VarChar).Value = role;

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                            MessageBox.Show("Informations de l'utilisateur mises à jour avec succès.");
                        else
                            MessageBox.Show("Aucune mise à jour réalisée. Vérifiez que l'identifiant existe.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour de l'utilisateur: " + ex.Message);
            }
        }
        public bool ValidateUser(string identifiant, string password)
        {
            bool isValid = false;
            // La requête SQL vérifie maintenant que le rôle est "admin" (en minuscules)
            string query = "SELECT COUNT(*) FROM utilisateurs WHERE Identifiant = @Identifiant AND Password_utilisateur = @Password AND Role = 'admin'";
            try
            {
                using (MySqlConnection conn = db.ConnexionBase())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Identifiant", identifiant);
                        cmd.Parameters.AddWithValue("@Password", password);  // Pour une application réelle, envisagez d'utiliser le hachage du mot de passe

                        int result = Convert.ToInt32(cmd.ExecuteScalar());
                        if (result > 0)
                        {
                            isValid = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification des identifiants: " + ex.Message);
            }
            return isValid;
        }

    }
}
