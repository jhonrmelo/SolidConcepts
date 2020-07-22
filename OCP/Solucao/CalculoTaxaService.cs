using System.Collections.Generic;

namespace OCP.Solucao
{
    public class CalculoTaxaService
    {
        public void CalculaTaxaContrato(List<IContrato> Ilstcontrato)
        {
            foreach (var contrato in Ilstcontrato)
            {
                contrato.CalculaTaxa();
            }
        }
    }
}
