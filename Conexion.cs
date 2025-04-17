using System;
using MySql.Data.MySqlClient;

public class Conector
{
	public Conector()
	{
		string connetionString = "datasource=127.0.0.1;port=3306;user=root;password=;database=finanazas";
		string query = "select * From Persona";
		MySqlConnection databaseConnection = new MySqlConnection(connetionString);
		MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
		MySqlDataReader reader;
        try
        {
			databaseConnection.Open();
			reader = databaseConnection.ExecuteReader();

			if (reader.HasRows)
            {
                while (reader.Read())
                {
					
				}
			}
            else
            {
				Console.WriteLine("No se encontro nada");
            }
			databaseConnection.Close();
        }
		catch(Exception e)
        {
			MessageBox.Show(e.Message);
        }
	}
}
