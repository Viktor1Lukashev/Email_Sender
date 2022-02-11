using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;

namespace EmailSender.Models
{
    public class MailSender: Isender
    {
        private IConfiguration _config;
        private string login;
        private string password;
        private int port;
        private string address;
        public MailSender(IConfiguration config)
        {

            this._config = config;
            login = config.GetSection("login").Value;
            password = config.GetSection("password").Value;
            port = Int32.Parse(config.GetSection("port").Value);
            address = config.GetSection("password").Value;

        }
        public void Send(Mail mail)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Виктор Лукашев", "Lukashev-viktor@yandex.ru"));
                foreach (var i in mail.Recipients)
                {
                    message.To.Add(new MailboxAddress("", i.ToString()));
                }

                message.Subject = mail.Subject;
                message.Body = new TextPart(mail.Body);

                using (var client = new SmtpClient())
                {

                    client.Connect(address, port, true);
                    client.Authenticate(login, password);
                    client.Send(message);
                    client.Disconnect(true);
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
