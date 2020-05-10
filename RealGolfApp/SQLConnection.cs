using System;
using System.Data.SqlClient;

namespace RealGolfApp
{
    public static class SQLConnection
    {
        public static SqlConnection GolfConnectionString { get; private set; }

        public static void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;

                connection.Open();

                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionString: {0}",
                    connection.ConnectionString);
            }
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return @"Data Source=RICHARD-KRUEGER\MSSQLSERVER2017;Initial Catalog=Golf;Integrated Security=true";
        }

        public static void RegisterUser(String userName, String password)
        {
            string sqlStatement = "EXEC SP CreateAccount";
            SqlCommand addCommand = new SqlCommand(sqlStatement, GolfConnectionString);
        }
    }
}
