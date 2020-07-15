namespace SRP.Solucao
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public int Razao { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        public bool IsValid()
        {
            return new EmailService().ValidaEmail(Email) 
                       && new CnpjService().ValidaCnpj(Cnpj) 
                       && new EnderecoService().ValidEndereco(Endereco);
        }
    }
}
