using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class RetailersDetailsVM
    {
        public int Retailer_ID { get; set; }
        public string Retailer_Name { get; set; }
        public decimal Retailers_Buying_Price { get; set; }
        public decimal Transportation_Cost { get; set; }
        public decimal Total_Cost_PerUnit { get; set; }
        public decimal Retailer_Selling_Price { get; set; }
    }
}
