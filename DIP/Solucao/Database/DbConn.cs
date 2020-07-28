using Dapper;
using DIP.Solucao.Interfaces;
using MySql.Data.MySqlClient;

namespace DIP.Solucao.Database
{
    public class DbConn
    {
        public MySqlConnection conn;

        public DbConn()
        {
            conn = new MySqlConnection("ConnectionString");
        }
    }
}
