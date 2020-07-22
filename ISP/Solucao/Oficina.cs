using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.Solucao
{
    public class Oficina : IEstabelecimentoComPecas
    {
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public double Taxa { get; set; }
        public List<Peca> ListPecas { get; set; }
        public Peca VendePeca(int id)
        {
            var peca = ListPecas.Where(peca => peca.PecaId == id).FirstOrDefault();
            ListPecas.Remove(peca);
            return peca;
        }
    }
}
