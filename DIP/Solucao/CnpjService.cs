
using DIP.Solucao.Interfaces;

namespace DIP.Solucao
{
    public class CnpjService : ICnpjService
    {
        public bool ValidaCnpj(string Cnpj)
        {
            if (Cnpj.Length != 14)
            {
                return false;
            }
            return true;
        }
    }
}
