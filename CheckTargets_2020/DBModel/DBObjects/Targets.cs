using CheckTargets_2020.DBModel.DBObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.DBModel
{
   [Table("Targets")]
    public class Targets
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(100), Required(ErrorMessage = "Please Enter Your Target Name")]
        [DisplayName("Target Name")]
        public string Name { get; set; }

        [StringLength(100), Required(ErrorMessage = "Please Enter Your URL")]
        [DisplayName("URL")]
        public string Url { get; set; }
        public bool State { get; set; }

        [ForeignKey("User")]
        public int CreatedByID { get; set; }
        public Users User { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

    }
}
