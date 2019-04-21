using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class LocalTradersDetailsVM
    {
        public int Local_Trader_ID { get; set; }
        public string Local_Trader_Name { get; set; }
        public decimal Local_Buying_Price { get; set; }
        public decimal Transportation_Cost { get; set; }
        public decimal Storing_Cost { get; set; }
        public decimal Total_Cost { get; set; }
    }
}
