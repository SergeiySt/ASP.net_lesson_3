using System.Net.Mail;
using System.Net;
using db_and_news.Models;

namespace db_and_news.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool SendEmail(string to, string subject, string body, EmailData emailData)
        {
            var smtpServer = _configuration["EmailSettings:SmtpServer"];
            var smtpPort = int.Parse(_configuration["EmailSettings:SmtpPort"]);
            var smtpUsername = _configuration["EmailSettings:SmtpUsername"];
            var smtpPassword = _configuration["EmailSettings:SmtpPassword"];

            try
            {
                using (var client = new SmtpClient(smtpServer, smtpPort))
                {
                    client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    client.EnableSsl = true;

                    var message = new MailMessage
                    {
                        From = new MailAddress(smtpUsername),
                        Subject = subject,
                        Body = $"Email: {emailData.Email}<br>Заголовок новости: {emailData.NewsTitle}<br>{body}",
                        IsBodyHtml = true
                    };

                    message.To.Add(to);

                    client.Send(message);

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
