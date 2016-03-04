using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;

namespace Chiavi
{
    class Mail
    {
        public Mail()
        {
 
        }

        public void sendMail(string To, string Subject, string Body)
        {
            var SMTP = new SmtpClient
            {
                Host =  "out.itesys.it",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials =  new System.Net.NetworkCredential("", "")
            };

            Thread T1 = new Thread(delegate()
            {
                using (var message = new MailMessage("rizzo@2858.it", To)
                {
                    Subject = Subject,
                    Body = Body
                })
                {
                    {
                        SMTP.Send(message);
                    }
                }
            });

            T1.Start();
        }
        public void sendTestMail()
        {
            var SMTP = new SmtpClient
            {
                Host =  "out.itesys.it",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials =  new System.Net.NetworkCredential("", "")
            };

            Thread T1 = new Thread(delegate()
            {
                using (var message = new MailMessage("rizzo@2858.it", "rizzo@2858.it")
                {
                    Subject = "Messaggio di prova",
                    Body = "Questo è un messaggio di prova"
                })
                {
                    {
                        SMTP.Send(message);
                    }
                }
            });

            T1.Start();
        }

    }
}
