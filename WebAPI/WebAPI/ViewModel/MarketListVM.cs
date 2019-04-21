using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class MarketListVM
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int Market_ID { get; set; }
        [Required]
        public string Market_Name { get; set; }
        [Required]
        public string Market_Address { get; set; }
        [Required]
        public string Post_Code { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string Country_Name { get; set; }
    }
}
