using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Solucao
{
    public class Solucao
    {
        static void Main3(string[] args)
        {
            List<BaseCliente> lstBaseClientes = new List<BaseCliente>
            {
                new ClientesComSubUnidades(),

                new ClientePublico(),

                new ClientePrivado()
            };

            List<BaseCliente> lstUnidades = new List<BaseCliente>
            {
                new BaseCliente(),
                new BaseCliente()
            };

            //foreach (var cliente in lstBaseClientes)
            //{
            //    foreach (var unidade in lstUnidades)
            //    {
            //        cliente.addSubunidades(); // Não funciona, já me da direto um erro de compilação.
            //    }
            //}

            List<ClientesComSubUnidades> lstClienteComSubunidade = new List<ClientesComSubUnidades>
            {
                new ClientePublico(),
                new ClientesComSubUnidades()
            };

            List<ClientesComSubUnidades> lstUnidades2 = new List<ClientesComSubUnidades>();
            lstUnidades2.Add(new ClientesComSubUnidades());
            lstUnidades2.Add(new ClientesComSubUnidades());


            foreach (var cliente in lstClienteComSubunidade)
            {
                foreach (var unidade in lstUnidades2)
                {
                    cliente.AddSubunidades(unidade);
                }
            }

        }
    }
}
