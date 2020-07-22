using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Erro
{
    public class Cliente
    {
        public Cliente()
        {
            Unidades = new List<Cliente>();
        }
        public int Id { get; set; }
        public string Razao { get; set; }
        public List<Cliente> Unidades { get; set; }

        public virtual void AddSubunidades(Cliente cliente)
        {
            Unidades.Add(cliente);
        }
    }
}
