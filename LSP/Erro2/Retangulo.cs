using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Erro2
{
    public class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public virtual void SetLargura(double largura)
        {
            Largura = largura;
        }
        public virtual void SetAltura(double altura)
        {
            Altura = altura;
        }
        public double CalculaArea()
        {
            return Altura * Largura;
        }
    }
}
