using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Local_Product_Source
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]

        public int Local_Product_Source_ID { get; set; }
        public decimal Seeding_Cost { get; set; }
        public decimal Ploughing_Cost { get; set; }
        public decimal Watering_Cost { get; set; }
        public decimal Labour_Cost { get; set; }
        public decimal Processing_Cost { get; set; }
        public decimal Total_Production_Cost { get; set; }

        //public decimal Product_Selling_Price { get; set; }

        [ForeignKey(" Product_ID")]
        public int Product_ID { get; set; }
        public virtual Products Products { get; set; }

        [ForeignKey(" Farmer_ID")]
        public int Farmer_ID { get; set; }
        public virtual Farmer_List FarmerList { get; set; }
    }
}
