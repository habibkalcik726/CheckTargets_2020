using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.DBModel.DBObjects
{

    [Table("Notifications")]
    public class Notifications
    {
        public int ID { get; set; }

        public int TargetID { get; set; }
        
        [StringLength(100), Required(ErrorMessage = "Please Enter Your Message")]
        [DisplayName("Message")]
        public string Message { get; set; }
        
        [StringLength(100), Required(ErrorMessage = "Please Enter Your Target Contact")]
        [DisplayName("Target Contact")]
        public string TargetContact { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual Users User { get; set; }



    }
}
