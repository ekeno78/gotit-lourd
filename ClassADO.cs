using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class ClassADO
{
    private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
    {
        Server = "172.16.196.254",
        UserID = "gotit",
        Password = "azertysio",
        Database = "gotit",
    };

    public MySqlConnection ConnexionBase()
    {
        MySqlConnection connexion = new MySqlConnection(builder.ConnectionString);
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
}
