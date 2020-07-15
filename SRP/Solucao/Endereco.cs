namespace SRP.Solucao
{
    public class Endereco
    {
        public int Id { get; set; }
        public int EstabelecimentoId { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
    }
}
