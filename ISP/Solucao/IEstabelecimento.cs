using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Solucao
{
    public interface IEstabelecimento
    {
        int EstabelecimentoId { get; set; }
        string Nome { get; set; }
        double Taxa { get; set; }
    }
}
