using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Product_Category
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Product_Category_ID { get; set; }
        public string Product_Category_Name { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
