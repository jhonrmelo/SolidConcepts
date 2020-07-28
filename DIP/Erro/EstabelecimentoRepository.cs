using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;

namespace DIP.Erro
{
    public class EstabelecimentoRepository
    {
        public int AdicionarEstabelecimento(Estabelecimento estabelecimento)
        {
            MySqlConnection conn = new MySqlConnection("ConnectionString");

            string sqlQueryInserEstabelecimento = @"INSERT INTO ESTABELECIMENTO (RAZAO,CNPJ,EMAIL) VALUES (@RAZAO, @CNPJ,@EMAIL)";
            return conn.Query<int>(sqlQueryInserEstabelecimento, estabelecimento).FirstOrDefault();
        }
    }
}
