using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Products
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Details { get; set; }
        public string Product_Source { get; set; }

        [ForeignKey(" Product_Category_ID")]
        public int? Product_Category_ID { get; set; }
        public virtual Product_Category Product_Category { get; set; }
        [ForeignKey(" Market_ID")]
        public int Market_ID { get; set; }
        public virtual Market_List MarketList { get; set; }
        [ForeignKey(" Product_Unit_ID")]
        public int? Product_Unit_ID { get; set; }
        public virtual Product_Unit Product_Unit { get; set; }
    }
}
