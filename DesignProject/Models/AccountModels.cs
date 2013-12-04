using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DesignProject.Models
{
    public class AccountModels
    {
        private static readonly string connectionString =
            string.Format("Server={0};Database={1};UserId={2};Password={3}", "localhost", "sample", "papemk2", "mikuro45");

        public static void GetProfile()
        {

        }

        public static bool GetAuth(string id, string password)
        {
            MySqlDataReader reader;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    string query = "select * from auth where ID=" + "\"" + id + "\"" + " and Pass=" + "\"" + password + "\"";
                    adapter.SelectCommand = new MySqlCommand(query, connection);
                    reader = adapter.SelectCommand.ExecuteReader();
                    return reader.Read();
                }
            }
        }

        public static DateTime GetDateTime()
        {
            MySqlDataReader reader;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    string query = "select now()";
                    adapter.SelectCommand = new MySqlCommand(query, connection);
                    reader = adapter.SelectCommand.ExecuteReader();
                    reader.Read();

                    return reader.GetDateTime(0);
                }
            }
        }
    }
}