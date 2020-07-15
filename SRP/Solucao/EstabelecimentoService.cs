namespace SRP.Solucao
{
    public class EstabelecimentoService
    {
        public bool AdicionarEstabelecimento(Estabelecimento estabelecimento)
        {
            if (estabelecimento.IsValid())
            {
                return false;
            }

            int estabelecimentoID = new EstabelecimentoRepository().AdicionarEstabelecimento(estabelecimento);
            estabelecimento.Endereco.EstabelecimentoId = estabelecimentoID;

            new EnderecoService().AdicionarEndereco(estabelecimento.Endereco);

            return true;
        }
    }
}
