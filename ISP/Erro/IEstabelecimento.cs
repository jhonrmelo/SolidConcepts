using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Erro
{
    public interface IEstabelecimento
    {
        int EstabelecimentoId { get; set; }
        string Nome { get; set; }
        double Taxa { get; set; }
        double PrecoCombustivel { get; set; }
        double TotalAbastecidoNoDia { get; set; }
        List<Peca> ListPecas { get; set; }

        void AtualizaTotalAbastecido(double valor);
        double CalculaValorVenda(double quantidade);

        Peca VendePeca(int id);


    }
}
