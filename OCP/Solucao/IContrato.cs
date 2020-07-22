using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Solucao
{
    public interface IContrato
    {
        double Taxa { get; set; }
        double TaxaFinal { get; set; }
        DateTime DataFimVigencia { get; set; }

        void CalculaTaxa();
    }
}
