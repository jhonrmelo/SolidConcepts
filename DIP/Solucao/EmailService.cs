using DIP.Solucao.Interfaces;
using System.Net.Mail;

namespace DIP.Solucao
{
    public class EmailService : IEmailService
    {
        public bool ValidaEmail(string Email)
        {
            var addr = new MailAddress(Email);
            return addr.Address != Email;
        }
    }
}
