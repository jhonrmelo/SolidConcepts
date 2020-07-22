using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Erro2
{
    public class Program
    {
        static void Main3(string[] args)
        {
            Retangulo quadrado = new Quadrado()
            {
                Altura = 15,
                Largura = 15
            };

            AtualizaRetanguloMostraValores(quadrado);

        }

        public static void AtualizaRetangulo(Retangulo ret)
        {
            ret.SetAltura(20);
        }

        public static void AtualizaRetanguloMostraValores(Retangulo ret)
        {
            ret.SetAltura(5);
            ret.SetLargura(10);
            Console.WriteLine($"O resultado deve ser 50 porém foi: {ret.CalculaArea()}");
        }
    }
}
