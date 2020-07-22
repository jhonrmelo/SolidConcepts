using LSP.Erro;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LSP.Erro1
{
    public class Erro
    {
        static void Main2(string[] args)
        {

            List<Cliente> lstCliente = new List<Cliente>
            {
                new ClientePublico(),
                new ClientePrivado()
            };

            List<Cliente> lstUnidades = new List<Cliente>
            {
                new Cliente(),
                new Cliente()
            };


            foreach (var cliente in lstCliente)
            {
                foreach (var unidade in lstUnidades)
                {
                    cliente.AddSubunidades(unidade);
                }
            }

        }
    }
}
