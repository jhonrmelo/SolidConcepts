namespace DIP.Solucao.Interfaces
{
    public interface IEnderecoService
    {
        void AdicionarEndereco(Endereco endereco);
        bool ValidEndereco(Endereco endereco);
    }
}