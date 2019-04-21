using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models_Table
{
    public class Market_List
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Market_ID { get; set; }
        public string Market_Name { get; set; }
        public string Market_Address { get; set; }
        public string Post_Code { get; set; }
        public string District { get; set; }
        public string Country_Name { get; set; }
        public virtual ICollection<Traders_List> Traders_List { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
