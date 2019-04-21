using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class FarmerListVM
    {        
        public int? Farmer_ID { get; set; }
        public string Farmer_Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
