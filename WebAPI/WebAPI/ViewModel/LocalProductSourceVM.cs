using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class LocalProductSourceVM
    {
        public int Local_Product_Source_ID { get; set; }
        public decimal Seeding_Cost { get; set; }
        public decimal Ploughing_Cost { get; set; }
        public decimal Watering_Cost { get; set; }
        public decimal Labour_Cost { get; set; }
        public decimal Processing_Cost { get; set; }
        public decimal Total_Production_Cost { get; set; }
    }
}
