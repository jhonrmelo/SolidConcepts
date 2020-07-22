using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Solucao
{
    public interface IEstabelecimentoComAbastecimento : IEstabelecimento
    {
        double PrecoCombustivel { get; set; }
        double TotalAbastecidoNoDia { get; set; }
        void AtualizaTotalAbastecido(double valor);
        double CalculaValorVenda(double quantidade);
    }
}
