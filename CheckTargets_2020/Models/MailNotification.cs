using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CheckTargets_2020.Models
{
    public class MailNotification : INotification
    {
        public string SourceMail { get; set; }
        public string TargetMail { get; set; }

        /// <summary>
        /// send mail notification
        /// </summary>
        /// <param name="message"></param>
        public void sendNotification(string message)
        {
            //mail notification
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("godofothergods@gmail.com");
                mail.To.Add(TargetMail);
                mail.Subject = "Target State";
                mail.Body = "<h1>" + message + "</h1>";
                mail.IsBodyHtml = true;
                //  mail.Attachments.Add(new Attachment("C:\\file.zip"));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("godofothergods@gmail.com", "bablisok");
                    
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }


        }
    }
}
