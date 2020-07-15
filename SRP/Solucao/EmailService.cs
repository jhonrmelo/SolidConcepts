using System.Net.Mail;

namespace SRP.Solucao
{
    public class EmailService
    {
        public bool ValidaEmail(string Email)
        {
            var addr = new MailAddress(Email);
            return addr.Address != Email;
        }
    }
}
