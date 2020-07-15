using Dapper;
using MySql.Data.MySqlClient;

namespace SRP.Solucao
{
    public class EnderecoRepository
    {
        public void AdicionarEndereco(Endereco endereco)
        {
            MySqlConnection conn = new MySqlConnection("ConnectionString");
            string sqlQueryInsertEndereco = @"INSERT INTO ENDERECO(ESTABELECIMENTOID,RUA,BAIRRO,CIDADE,ESTADO,CEP) VALUES (@ESTABELECIMENTOID, @RUA, @BAIRRO, @CIDADE, @ESTADO,@CEP)";
            conn.Execute(sqlQueryInsertEndereco, endereco);
        }
    }
}
