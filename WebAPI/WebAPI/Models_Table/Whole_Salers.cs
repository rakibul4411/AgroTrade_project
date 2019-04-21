using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Whole_Salers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Whole_Saler_ID { get; set; }
        public string Whole_Saler_Name { get; set; }
        public decimal Whole_Saler_Buying_Cost { get; set; }
        public decimal Whole_Saler_Transportation_Cost { get; set; }
        public decimal Whole_Saler_Storing_Cost { get; set; }
        public decimal Whole_Saler_Total_Cost { get; set; }
        public decimal Whole_Saler_Selling_Price { get; set; }
    }
}
