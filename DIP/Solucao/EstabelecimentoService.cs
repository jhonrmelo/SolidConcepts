using DIP.Solucao.Interfaces;

namespace DIP.Solucao
{
    public class EstabelecimentoService : IEstabelecimentoService
    {
        private IEstabelecimentoRepository _estabelecimentoRepository;
        private IEnderecoService _estabelecimentoService;

        public EstabelecimentoService(IEstabelecimentoRepository estabelecimentoRepository, IEnderecoService enderecoService)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
            _estabelecimentoService = enderecoService;
        }

        public bool AdicionarEstabelecimento(Estabelecimento estabelecimento)
        {
            if (estabelecimento.IsValid())
            {
                return false;
            }

            int estabelecimentoID = _estabelecimentoRepository.AdicionarEstabelecimento(estabelecimento);

            estabelecimento.Endereco.EstabelecimentoId = estabelecimentoID;

            _estabelecimentoService.AdicionarEndereco(estabelecimento.Endereco);

            return true;
        }
    }
}
