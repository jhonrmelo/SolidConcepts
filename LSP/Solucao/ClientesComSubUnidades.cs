using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Solucao
{
    public class ClientesComSubUnidades : BaseCliente
    {
        public List<ClientesComSubUnidades> Unidades { get; set; }

        public virtual void AddSubunidades(ClientesComSubUnidades unidade)
        {
            Unidades.Add(unidade);
        }
    }
}
