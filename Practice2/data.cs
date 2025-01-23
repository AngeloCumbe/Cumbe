using System.Collections.Generic;
using System.Data.SqlClient;

namespace Practice2
{
    internal class Data
    {
        static string connectionString = "Data Source=DESKTOP-5VDUM75\\MSSQLSERVER01;Initial Catalog=owner;Integrated Security=True;"; // Local Connection
        static SqlConnection sqlConnection;

        public Data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<owner> Getowners()
        {
            var selectStatement = "SELECT * FROM owners";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var owners = new List<owner>();

            while (reader.Read())
            {
                owners.Add(new owner
                {
                    name = reader["name"].ToString(),
                    username = reader["username"].ToString(),
                    age = Convert.ToInt32(reader["age"].ToString())
                });
            }

            sqlConnection.Close();
            return owners;

        }
    }
}