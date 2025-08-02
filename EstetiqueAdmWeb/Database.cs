using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstetiqueAdmWeb
{
    public class Database
    {
        private MySqlConnection connection;
        private string server = "localhost";
        private string database = "bd_estetique";  // ✅ nome do seu banco
        private string uid = "root";
        private string password = ""; // ou coloque sua senha se tiver, exemplo: "123456"

        public Database()
        {
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }
    }
}
