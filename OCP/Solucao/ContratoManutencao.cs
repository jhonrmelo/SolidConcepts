using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Solucao
{
    public class ContratoManutencao : IContrato
    {
        public double Taxa { get; set; }
        public double TaxaFinal { get; set; }
        public DateTime DataFimVigencia { get; set; }

        public void CalculaTaxa()
        {
            if (DataFimVigencia < DateTime.Now)
            {
                TaxaFinal = Taxa * 1.5;
            }
            TaxaFinal = Taxa * 1.2;
        }
    }
}
