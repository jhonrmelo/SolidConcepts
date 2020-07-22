using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Erro
{
    public class ClientePublico : Cliente
    {
        public ClientePublico() : base() { }
        public override void AddSubunidades(Cliente unidade)
        {
            unidade.Razao = $"Publico - {unidade.Razao}";
            Unidades.Add(unidade);
        }
    }
}
