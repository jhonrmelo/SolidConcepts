using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Erro
{
    public class ClientePrivado : Cliente
    {
        public ClientePrivado() : base()
        {

        }

        public override void AddSubunidades(Cliente unidade)
        {
            throw new NotImplementedException();
        }
    }
}
