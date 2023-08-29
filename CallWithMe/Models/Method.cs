﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CallWithMe.Models
{
    public class Method
    {
        public static void sendMail(string to, string subject, string body)
        {
            new Thread(() =>
            {
                try
                {
                    var toEmailAddress = ConfigurationManager.AppSettings["ToEmailAddress"].ToString();
                    var fromEmailAddress = ConfigurationManager.AppSettings["FromEmailAddress"].ToString();
                    var fromEmailDisplayName = ConfigurationManager.AppSettings["FromEmailDisplayName"].ToString();
                    var fromEmailPassword = ConfigurationManager.AppSettings["FromEmailPassword"].ToString();
                    var smtpHost = ConfigurationManager.AppSettings["SMTPHost"].ToString();
                    var smtpPort = ConfigurationManager.AppSettings["SMTPPort"].ToString();

                    MailMessage message = new MailMessage(new MailAddress(fromEmailAddress, fromEmailDisplayName), new MailAddress(toEmailAddress));
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.Body = "from : " + to + "<br />" + body;

                    var client = new SmtpClient();
                    client.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPassword);
                    client.Host = smtpHost;
                    client.EnableSsl = false;
                    client.Port = !string.IsNullOrEmpty(smtpPort) ? Convert.ToInt32(smtpPort) : 0;
                    client.Send(message);
                }
                catch
                {

                }
            }).Start();
        }
    }
}
