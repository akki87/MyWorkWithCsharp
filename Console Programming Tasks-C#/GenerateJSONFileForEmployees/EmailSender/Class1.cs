using System.Text.Json;
using System.Collections.Generic;
using System.Numerics;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Reflection;

namespace EmailSender
{
    public class Mail
    {
        //public string ToMail;
        //public string template;
        //public Mail(string Tomail,string template) { this.ToMail = Tomail;this.template = template; }
        public void  SendMail(string Tomail,string template)
        {
            using MailMessage msg = new MailMessage()
            {
                IsBodyHtml = true,
                Body = template,
                Subject = "Tester",
                From = new MailAddress("nykumar@qualminds.com"),
            };
            msg.To.Add(new MailAddress(Tomail));
            SmtpClient message = new SmtpClient();
            message.Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
            message.Host = ConfigurationManager.AppSettings["Host"];
            message.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["Username"], ConfigurationManager.AppSettings["Password"]);
            message.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["SSL"]);
            message.Send(msg);
        }
    }
}