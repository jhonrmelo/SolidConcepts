using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Solucao
{
    public class ClientePublico : ClientesComSubUnidades
    {
        public override void AddSubunidades(ClientesComSubUnidades unidade)
        {
            unidade.Razao = $"Publico - {unidade.Razao}";
            Unidades.Add(unidade);
        }
    }
}
