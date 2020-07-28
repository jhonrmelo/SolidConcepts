using DIP.Solucao.Interfaces;

namespace DIP.Solucao
{
    public class EnderecoService : IEnderecoService
    {
        private IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        public bool ValidEndereco(Endereco endereco)
        {
            if (endereco is null)
            {
                return false;
            }
            return true;
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            _enderecoRepository.AdicionarEndereco(endereco);
        }
    }
}
