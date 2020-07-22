using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Erro
{
    public class CalculaTaxaService
    {

        public void CalculaTaxaContrato(List<Contrato> lstContrato)
        {
            foreach (var contrato in lstContrato)
            {
                if (contrato.DataFimVigencia < DateTime.Now)
                {
                    if (contrato.TipoContrato == EnumTipoContrato.Abastecimento)
                    {
                        contrato.TaxaFinal = contrato.Taxa * 1.5;
                    }
                    else
                    {
                        contrato.TaxaFinal = contrato.Taxa * 2.0;
                    }
                }
                else
                {
                    if (contrato.TipoContrato == EnumTipoContrato.Abastecimento)
                    {
                        contrato.TaxaFinal = contrato.Taxa * 1.2;
                    }
                    else
                    {
                        contrato.TaxaFinal = contrato.Taxa;
                    }
                }
            }
        }
    }
}
