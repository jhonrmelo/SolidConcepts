using DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Solucao.Factory
{
    public static class Factory
    {
        public static ICnpjService CreateCnpjService()
        {
            return new CnpjService();
        }

        public static IEmailService CreateEmailService()
        {
            return new EmailService();
        }
        public static IEnderecoService CreateEnderecoService()
        {
            return new EnderecoService(CreateEnderecoRepository());
        }

        public static IEstabelecimento CreateEstabelecimento()
        {
            return new Estabelecimento(CreateCnpjService(), CreateEmailService(), CreateEnderecoService());
        }
        public static IEstabelecimentoService CreateEstabelecimentoService()
        {
            return new EstabelecimentoService(CreateEstabelecimentoRepository(), CreateEnderecoService());
        }

        public static IEstabelecimentoRepository CreateEstabelecimentoRepository()
        {
            return new EstabelecimentoRepository();
        }

        public static IEnderecoRepository CreateEnderecoRepository()
        {
            return new EnderecoRepository();
        }
    }
}
