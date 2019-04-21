using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Traders_List
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Trader_ID { get; set; }
        public string Trader_Name { get; set; }

        public string Trader_Address { get; set; }

        [ForeignKey("Trader_Category_ID")]
        public int? Trader_Category_ID { get; set; }
        public virtual Trader_Category Trader_Category { get; set; }

        [ForeignKey("Market_ID")]
        public int? Market_ID { get; set; }
        public virtual Market_List Market_List { get; set; }
    }
}
