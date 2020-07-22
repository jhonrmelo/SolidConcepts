using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.Erro
{
    public class Oficina : IEstabelecimento
    {
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public double Taxa { get; set; }
        public double PrecoCombustivel { get; set; }
        public double TotalAbastecidoNoDia { get; set; }
        public List<Peca> ListPecas { get; set; }

        public void AtualizaTotalAbastecido(double valor)
        {
            throw new NotImplementedException();
        }

        public double CalculaValorVenda(double quantidade)
        {
            throw new NotImplementedException();
        }

        public Peca VendePeca(int id)
        {
            var peca = ListPecas.Where(peca => peca.PecaId == id).FirstOrDefault();
            ListPecas.Remove(peca);
            return peca;
        }
    }
}
