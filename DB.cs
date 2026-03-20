using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Example
{
    internal class DB
    {
        private static readonly string _server = "localhost";
        private static readonly string _port = "3306";
        private static readonly string _username = "root";
        private static readonly string _password = "";
        private static readonly string _database = "demo";

        MySqlConnection connection = new($"server={_server};port={_port};username={_username};password={_password};database={_database}");

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
