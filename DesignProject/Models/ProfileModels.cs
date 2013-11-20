using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DesignProject.Models
{
    public class ProfileModels
    {
        private static readonly string connectionString =
            string.Format("Server={0};Database={1};UserId={2};Password={3}", "localhost", "sample", "papemk2", "mikuro45");

        public static string Id { get; set; }
        public static string Birth { get; set; }
        public static string Name { get; set; }
        public static string UnderGrad { get; set; }
        public static string Department { get; set; }

        public static void getProfile()
        {

            MySqlDataReader reader;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter())
                {
                    //string query = "select now()";
                    string query = "select * from profile where id=5804";
                    adapter.SelectCommand = new MySqlCommand(query, connection);
                    reader = adapter.SelectCommand.ExecuteReader();
                    //reader.Read();
                    for (int i = 0; i < reader.FieldCount; ++i)
                    {
                        System.Diagnostics.Debug.WriteLine(string.Join("\t", reader.GetName(i)));

                        reader.Read();

                        switch (reader.GetName(i))
                        {
                            case "id":
                                Id = reader.GetString(i);
                                break;
                            case "birth":
                                Birth = reader.GetString(i);
                                break;
                            case "name":
                                Name = reader.GetString(i);
                                break;
                            case "undergrad":
                                UnderGrad = reader.GetString(i);
                                break;
                            case "department":
                                Department = reader.GetString(i);
                                break;
                        }
                    }
                }
            }
        }
    }
}