using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Whole_Saler_Order_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Order_ID { get; set; }

        [ForeignKey(" Whole_Saler_ID")]
        public int? Whole_Saler_ID { get; set; }
        public virtual Whole_Salers Whole_Salers { get; set; }
        [ForeignKey(" Product_ID")]
        public int? Product_ID { get; set; }
        public virtual Products Products { get; set; }
    }
}
