using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.Models
{
    public interface INotification
    {
        void sendNotification(string message);
    }
}
