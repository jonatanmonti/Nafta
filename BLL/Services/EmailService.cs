using System;
using System.Net.Mail;
using System.Net;
using Common.Helper;


namespace BLL.Services
{
    public class EmailService
    {
        private readonly string _smtpServer;
        private readonly int _port;
        private readonly bool _enableSsl;
        private readonly string _fromEmail;
        private readonly string _fromName;
        private readonly string _password;

        public EmailService()
        {
            // Carga la configuración desde AppConfigManager
            _smtpServer = AppConfigManager.GetAppSetting("SmtpServer");
            _port = int.Parse(AppConfigManager.GetAppSetting("Port"));
            _enableSsl = bool.Parse(AppConfigManager.GetAppSetting("EnableSsl"));
            _fromEmail = AppConfigManager.GetAppSetting("FromEmail");
            _fromName = AppConfigManager.GetAppSetting("FromName");
            _password = AppConfigManager.GetAppSetting("Password");
        }

        public bool SendVerificationCode(string toEmail, string code)
        {
            try
            {
                string subject = "Código de verificación de tu cuenta";
                string body = $"Tu código de verificación es: <b>{code}</b>";

                var smtp = new SmtpClient(_smtpServer)
                {
                    Port = _port,
                    EnableSsl = _enableSsl,
                    Credentials = new NetworkCredential(_fromEmail, _password)
                };

                var message = new MailMessage
                {
                    From = new MailAddress(_fromEmail, _fromName),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };

                message.To.Add(toEmail);

                smtp.Send(message);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al enviar el correo: {ex.Message}");
                return false;
            }
        }
    }
}
