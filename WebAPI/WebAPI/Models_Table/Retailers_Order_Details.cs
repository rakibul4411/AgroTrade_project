using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Retailers_Order_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Retailer_Order_ID { get; set; }

        [ForeignKey(" Retailer_ID")]
        public int Retailer_ID { get; set; }
        public virtual Retailers_Details Retailers_Details { get; set; }

        [ForeignKey(" Product_ID")]
        public int Product_ID { get; set; }
        public virtual Products Products { get; set; }
    }
}
