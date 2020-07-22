using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Solucao
{
    public interface IEstabelecimentoComPecas : IEstabelecimento
    {
        List<Peca> ListPecas { get; set; }
        Peca VendePeca(int id);

    }
}
