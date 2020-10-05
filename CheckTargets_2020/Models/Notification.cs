using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.Models
{
    public  class Notification 
    {
        INotification _notification;
        public Notification(INotification notification)
        {
            _notification = notification;
        }
        public string Message { get; set; }

        public void Notify()
        {
            _notification.sendNotification(Message);
        }




    }
}
