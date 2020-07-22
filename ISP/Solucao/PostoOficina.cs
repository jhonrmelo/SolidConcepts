using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.Solucao
{
    public class PostoOficina : IEstabelecimentoComPecaEAbastecimento
    {
        public double PrecoCombustivel { get; set; }
        public double TotalAbastecidoNoDia { get; set; }
        public List<Peca> ListPecas { get; set; }
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public double Taxa { get; set; }

        public void AtualizaTotalAbastecido(double valor)
        {
            TotalAbastecidoNoDia += valor;
        }
        public double CalculaValorVenda(double quantidade)
        {
            return PrecoCombustivel * quantidade;
        }
        public Peca VendePeca(int id)
        {
            var peca = ListPecas.Where(peca => peca.PecaId == id).FirstOrDefault();
            ListPecas.Remove(peca);
            return peca;
        }
    }
}
