using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class WholeSalersVM
    {
        public int Whole_Saler_ID { get; set; }
        public string Whole_Saler_Name { get; set; }
        public decimal Whole_Saler_Buying_Cost { get; set; }
        public decimal Whole_Saler_Transportation_Cost { get; set; }
        public decimal Whole_Saler_Storing_Cost { get; set; }
        public decimal Whole_Saler_Total_Cost { get; set; }
        public decimal Whole_Saler_Selling_Price { get; set; }
    }
}
