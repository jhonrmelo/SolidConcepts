using DIP.Solucao.Interfaces;

namespace DIP.Solucao
{
    public class Estabelecimento : IEstabelecimento
    {
        private ICnpjService _cnpjService;
        private IEmailService _emailService;
        private IEnderecoService _enderecoService;
        public Estabelecimento(ICnpjService cnpjService, IEmailService emailService, IEnderecoService enderecoService)
        {
            _cnpjService = cnpjService;
            _emailService = emailService;
            _enderecoService = enderecoService;
        }

        public int Id { get; set; }
        public int Razao { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        public bool IsValid()
        {
            return _emailService.ValidaEmail(Email)
                       && _cnpjService.ValidaCnpj(Cnpj)
                       && _enderecoService.ValidEndereco(Endereco);
        }
    }
}
