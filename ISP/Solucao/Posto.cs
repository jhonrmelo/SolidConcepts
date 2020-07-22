using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Solucao
{
    public class Posto : IEstabelecimentoComAbastecimento
    {
        public int EstabelecimentoId { get; set; }
        public string Nome { get; set; }
        public double Taxa { get; set; }
        public double PrecoCombustivel { get; set; }
        public double TotalAbastecidoNoDia { get; set; }

        public void AtualizaTotalAbastecido(double valor)
        {
            TotalAbastecidoNoDia += valor;
        }
        public double CalculaValorVenda(double quantidade)
        {
            return PrecoCombustivel * quantidade;
        }
    }
}
