using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class TraderCategoryVM
    {
        ///[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Trader_Category_ID { get; set; }
        public string Trader_Category_Name { get; set; }
    }
}
