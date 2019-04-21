using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.ViewModel
{
    public class ProductsVM
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Product_ID { get; set; }
        [Required]
        public string Product_Name { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public string Product_Source { get; set; }
        
    }
}