namespace SRP.Solucao
{
    public class CnpjService
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
