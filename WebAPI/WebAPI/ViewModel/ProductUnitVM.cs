using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class ProductUnitVM
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Product_Unit_ID { get; set; }
        public int Product_Unit_Quantity { get; set; }
    }
}
