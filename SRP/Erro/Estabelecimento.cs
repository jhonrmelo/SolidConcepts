using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Net.Mail;

namespace SRP.Erro
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public int Razao { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }


        /// <summary>
        /// Classe violadora do SRP, aqui tenho varios motivos para modificar essa classe conforme a demanda de novos assuntos surgir.
        /// </summary>
        /// <param name="estabelecimento"></param>
        /// <returns></returns>
        public bool AdicionarEstabelecimento(Estabelecimento estabelecimento)
        {
            if (estabelecimento.Endereco is null)
            {
                return false;
            }

            if (estabelecimento.Cnpj.Length != 14)
            {
                return false;
            }

            var addr = new MailAddress(estabelecimento.Email);

            if (addr.Address != estabelecimento.Email)
            {
                return false;
            }

            MySqlConnection conn = new MySqlConnection("ConnectionString");

            string sqlQueryInserEstabelecimento = @"INSERT INTO ESTABELECIMENTO (RAZAO,CNPJ,EMAIL) VALUES (@RAZAO, @CNPJ,@EMAIL)";
            int estabelecimentoId = conn.Query<int>(sqlQueryInserEstabelecimento, estabelecimento).FirstOrDefault();

            estabelecimento.Endereco.EstabelecimentoId = estabelecimentoId;
            string sqlQueryInsertEndereco = @"INSERT INTO ENDERECO(ESTABELECIMENTOID,RUA,BAIRRO,CIDADE,ESTADO,CEP) VALUES (@ESTABELECIMENTOID, @RUA, @BAIRRO, @CIDADE, @ESTADO,@CEP)";
            conn.Execute(sqlQueryInsertEndereco, estabelecimento.Endereco);

            return true;
        }
    }
}
