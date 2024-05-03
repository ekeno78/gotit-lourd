using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace GOTIT
{
    internal class ClassUser
    {
        public ClassADO gotit = new ClassADO();

        public int Id_utilisateur { get; set; }
        public string Identifiant { get; set; }
        public string Email_utilisateur { get; set; }
        public string Password_utilisateur { get; set; }
        public string Role { get; set; }

        public ClassUser(int id, string identifiant, string email_utilisateur, string password_utilisateur, string role)
        {
            Id_utilisateur = id;
            Identifiant = identifiant;
            Email_utilisateur = email_utilisateur;
            Password_utilisateur = password_utilisateur;
            Role = role;
        }

        public ClassUser() { }

        public DataTable GetAllUsers()
        {
            var dataTable = new DataTable();
            try
            {
                using (var connection = gotit.ConnexionBase())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand("SELECT Id_utilisateur, Identifiant, Email_utilisateur, Password_utilisateur, Role FROM utilisateurs", connection))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Prenons l'exemple de la manipulation après récupération
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int idUtilisateur = row["Id_utilisateur"] != DBNull.Value ? Convert.ToInt32(row["Id_utilisateur"]) : 0;
                        string identifiant = row["Identifiant"] != DBNull.Value ? row["Identifiant"].ToString() : "default";
                        // Continuez pour les autres champs de la même manière
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllUsers: {ex.Message}");
                throw;
            }
            return dataTable;
        }

        public int SQLDeleteUser(int id)
        {
            try
            {
                using (var connection = gotit.ConnexionBase())
                {
                    connection.Open();
                    var sqlCmd = new MySqlCommand("DELETE FROM utilisateurs WHERE Id_utilisateur = @Id", connection);
                    sqlCmd.Parameters.AddWithValue("@Id", id);
                    return sqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SQLDeleteUser: {ex.Message}");
                throw;
            }
        }

        public int SQLEditUser(int id, string identifiant, string email_utilisateur, string password_utilisateur, string role)
        {
            try
            {
                using (var connection = gotit.ConnexionBase())
                {
                    connection.Open();
                    var sqlCmd = new MySqlCommand("UPDATE utilisateurs SET Identifiant = @Identifiant, Email_utilisateur = @Email_utilisateur, Password_utilisateur = @Password_utilisateur, Role = @Role WHERE Id_utilisateur = @Id", connection);
                    sqlCmd.Parameters.AddWithValue("@Id", id);
                    sqlCmd.Parameters.AddWithValue("@Identifiant", identifiant);
                    sqlCmd.Parameters.AddWithValue("@Email_utilisateur", email_utilisateur);
                    sqlCmd.Parameters.AddWithValue("@Password_utilisateur", password_utilisateur);
                    sqlCmd.Parameters.AddWithValue("@Role", role);
                    return sqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SQLEditUser: {ex.Message}");
                throw;
            }
        }

        public int SQLInsertUser(string identifiant, string email_utilisateur, string password_utilisateur, string role)
        {
            try
            {
                using (var connection = gotit.ConnexionBase())
                {
                    connection.Open();
                    var sqlCmd = new MySqlCommand("INSERT INTO utilisateurs (Identifiant, Email_utilisateur, Password_utilisateur, Role) VALUES (@Identifiant, @Email_utilisateur, @Password_utilisateur, @Role)", connection);
                    sqlCmd.Parameters.AddWithValue("@Identifiant", identifiant);
                    sqlCmd.Parameters.AddWithValue("@Email_utilisateur", email_utilisateur);
                    sqlCmd.Parameters.AddWithValue("@Password_utilisateur", password_utilisateur);
                    sqlCmd.Parameters.AddWithValue("@Role", role);
                    return sqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SQLInsertUser: {ex.Message}");
                throw;
            }
        }
    }
}
