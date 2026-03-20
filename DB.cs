using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
namespace Demo_Example
{
    internal class DB
    {

        public class MySqlConfig
        {
            public string server { get; set; }
            public int port { get; set; }

            public string username { get; set; }

            public string password { get; set; }

            public string database { get; set; }
        }

        public class Config
        {
            public MySqlConfig config { get; set; }
        }

        static string LoadConfig()
        {
            if (!File.Exists("config.json"))
            {
                MessageBox.Show("config.json не найден!");
                return null;
            }

            string json = File.ReadAllText("config.json");
            Config config = JsonSerializer.Deserialize<Config>(json);
            // System.Diagnostics.Debug.WriteLine($"server={config.config.server};port={config.config.port};user={config.config.username};password={config.config.password};database={config.config.database};");
            return $"server={config.config.server};port={config.config.port};user={config.config.username};password={config.config.password};database={config.config.database};";
            
        }

        MySqlConnection connection = new(LoadConfig());

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
