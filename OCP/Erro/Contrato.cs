using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Erro
{
    public class Contrato
    {
        public EnumTipoContrato TipoContrato { get; set; }
        public double Taxa { get; set; }
        public double TaxaFinal { get; set; }
        public DateTime DataFimVigencia { get; set; }
    }
}
