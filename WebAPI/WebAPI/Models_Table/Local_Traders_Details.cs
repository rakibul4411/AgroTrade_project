using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Local_Traders_Details
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Local_Trader_ID { get; set; }
        public string Local_Trader_Name { get; set; }
        public decimal Local_Buying_Price { get; set; }
        public decimal Transportation_Cost { get; set; }
        public decimal Storing_Cost { get; set; }
        public decimal Total_Cost { get; set; }
        //public bool IsBuying_From_Importer { get; set; }
        //public decimal Local_Trader_selling_Price { get; set; }
        //public virtual ICollection<Local_Trader_Order_Details> Local_Trader_Order_Details { get; set; }
    }
}
