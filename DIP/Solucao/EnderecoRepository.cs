using Dapper;
using DIP.Solucao.Database;
using DIP.Solucao.Interfaces;

namespace DIP.Solucao
{
    public class EnderecoRepository : DbConn, IEnderecoRepository
    {
        public void AdicionarEndereco(Endereco endereco)
        {
            string sqlQueryInsertEndereco = @"INSERT INTO ENDERECO(ESTABELECIMENTOID,RUA,BAIRRO,CIDADE,ESTADO,CEP) VALUES (@ESTABELECIMENTOID, @RUA, @BAIRRO, @CIDADE, @ESTADO,@CEP)";
            conn.Execute(sqlQueryInsertEndereco, endereco);
        }
    }
}
