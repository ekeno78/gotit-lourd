using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GOTIT
{
    public class ClassADO
    {
        private readonly string connectionString = "server=172.16.196.254;port=3306;database=gotit;uid=gotit;pwd=.nConX5bQW2h]veu;";

        public MySqlConnection ConnexionBase()
        {
            MySqlConnection connexion = new MySqlConnection(connectionString);
            try
            {
                connexion.Open();
                Console.WriteLine("Connexion à la base de données réussie.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur de connexion: {ex.Message}");
            }
            return connexion;
        }

        // Méthode pour exécuter une requête et lire les résultats
        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = ConnexionBase())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Exemple de traitement de données, ajustez en fonction de votre schéma de base de données
                            int columnValue = reader.IsDBNull(reader.GetOrdinal("columnName")) ? 0 : reader.GetInt32(reader.GetOrdinal("columnName"));
                            Console.WriteLine($"Valeur lue: {columnValue}");
                        }
                    }
                }
            }
        }
    }
}
