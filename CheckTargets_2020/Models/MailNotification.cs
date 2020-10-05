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
        // Source mail için seçilen mail https://myaccount.google.com/u/4/lesssecureapps?pli=1 linkinden less secure olarak ayarlanmalı
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
                mail.From = new MailAddress(SourceMail);
                mail.To.Add(TargetMail);
                mail.Subject = "Target State";
                mail.Body = "<h1>" + message + "</h1>";
                mail.IsBodyHtml = true;
                //  mail.Attachments.Add(new Attachment("C:\\file.zip"));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(SourceMail, "SourceMailPassword");
                    
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }


        }
    }
}
