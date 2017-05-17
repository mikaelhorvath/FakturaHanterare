using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaHanterare
{
    class EmailSender
    {
        private String emailBody;

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
        /// <summary>
        /// This Method sends the email
        /// </summary>
        public void SendEmail()
        {

        }
    }
}
