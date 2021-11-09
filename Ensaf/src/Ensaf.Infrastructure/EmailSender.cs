using Ensaf.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Ensaf.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(ILogger<EmailSender> logger)
        {
            _logger = logger;
        }

        public async Task SendEmailAsync(string to, string from, string subject, string body)
        {
            var fromAddress = new MailAddress("tyodro.system@gmail.com", "From Name");
            var toAddress = new MailAddress("mido5219@gmail.com", "To Name");
            const string fromPassword = "tyodro2020";


            var emailClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            //emailClient.Credentials = new NetworkCredential("tyodro.system@gmail.com","tyodro2020",)
            var message = new MailMessage
            {

                From = new MailAddress(from),
                Subject = subject,
                Body = body


            };
            message.To.Add(new MailAddress(to));
            await emailClient.SendMailAsync(message);
            _logger.LogWarning($"Sending email to {to} from {from} with subject {subject}.");
        }
    }
}
