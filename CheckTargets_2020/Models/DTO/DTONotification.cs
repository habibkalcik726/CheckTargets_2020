using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.Models.DTO
{
    public class DTONotification
    {
        public int ID { get; set; }
        public int TargetID { get; set; }
        public string Message { get; set; }
        public string TargetContact { get; set; }
        public int UserId { get; set; }

    }
}
