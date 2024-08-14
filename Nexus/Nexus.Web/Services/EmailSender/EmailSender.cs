using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace Nexus.Services.EmailSender
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromEmail = "info@blackmagicmaps.com";
            var emailPassword = "Anynarghtler1@";

            var cliente = new SmtpClient("smtp.hostinger.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fromEmail, emailPassword)
            };

            return cliente.SendMailAsync(fromEmail, email, subject, htmlMessage);
        }
    }
}
