using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Local_Trader_Order_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Local_Trader_Order_ID { get; set; }

        [ForeignKey(" Local_Trader_ID")]
        public int Local_Trader_ID { get; set; }
        public virtual Local_Traders_Details Local_Traders_Details { get; set; }

        [ForeignKey(" Product_ID")]
        public int Product_ID { get; set; }
        public virtual Products Products { get; set; }
    }
}
