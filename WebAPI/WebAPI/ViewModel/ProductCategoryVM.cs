using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class ProductCategoryVM
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Product_Category_ID { get; set; }
        [Required]
        public string Product_Category_Name { get; set; }
    }
}
