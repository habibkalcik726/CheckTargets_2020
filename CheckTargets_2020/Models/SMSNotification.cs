using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.Models
{
    public class SMSNotification : INotification
    {
        public string Phone { get; set; }

        /// <summary>
        /// send sms notification
        /// </summary>
        public void sendNotification(string message)
        {
            
           //sms notification
        }
    }
}
