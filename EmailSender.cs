using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FakturaHanterare
{
    class EmailSender
    {
        private String emailBody;
        private String recipient;

        /// <summary>
        /// Method sets our emailBody
        /// </summary>
        public String EmailBody
        {
            set
            {
                this.emailBody = value;
            }
        }

        public String Recipient
        {
            set
            {
                this.recipient = value;
            }
        }
        /// <summary>
        /// This Method sends the email
        /// </summary>
        public void SendEmail()
        {
            String txtEmail = "Hi, this email has been sent to you from FakturaHanterare 1.0. Please review your invoice below:\n\n" + this.emailBody;
          
            MailMessage mail = new MailMessage("SENDER-Email@mail.com", this.recipient);
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Credentials = new NetworkCredential("SENDER-Email@mail.com", "YourPassword");
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            mail.Subject = "Your invoice sent from FakturaHanterare";
            mail.Body = txtEmail;
            client.Send(mail);
        }
    }
}
