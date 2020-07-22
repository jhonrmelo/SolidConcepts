using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Erro
{
    public class Posto : IEstabelecimento
    {
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public double Taxa { get; set; }
        public double PrecoCombustivel { get; set; }
        public double TotalAbastecidoNoDia { get; set; }
        public List<Peca> ListPecas { get; set; }

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
            throw new NotImplementedException();
        }
    }
}
