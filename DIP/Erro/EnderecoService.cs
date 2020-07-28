using System;
using System.Collections.Generic;
using System.Text;


namespace DIP.Erro
{
    public class EnderecoService
    {
        public bool ValidEndereco(Endereco endereco)
        {
            if (endereco is null)
            {
                return false;
            }
            return true;
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            new EnderecoRepository().AdicionarEndereco(endereco);
        }
    }
}
