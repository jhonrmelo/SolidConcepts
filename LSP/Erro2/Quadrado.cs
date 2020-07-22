using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Erro2
{
    public class Quadrado : Retangulo
    {
        public override void SetLargura(double largura)
        {
            Largura = largura;
            Altura = largura;
        }
        public override void SetAltura(double altura)
        {
            Largura = altura;
            Altura = altura;
        }
    }
}
