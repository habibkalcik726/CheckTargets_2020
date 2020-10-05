using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.Models.DTO
{
    public class DTOTargets
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool State { get; set; }

        public int CreatedByID { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

    }
}
