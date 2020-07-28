using Dapper;
using DIP.Solucao.Database;
using DIP.Solucao.Interfaces;
using System.Linq;

namespace DIP.Solucao
{
    public class EstabelecimentoRepository : DbConn, IEstabelecimentoRepository
    {
        public int AdicionarEstabelecimento(Estabelecimento estabelecimento)
        {

            string sqlQueryInserEstabelecimento = @"INSERT INTO ESTABELECIMENTO (RAZAO,CNPJ,EMAIL) VALUES (@RAZAO, @CNPJ,@EMAIL)";
            return conn.Query<int>(sqlQueryInserEstabelecimento, estabelecimento).FirstOrDefault();
        }
    }
}
