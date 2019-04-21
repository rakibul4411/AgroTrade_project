using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModel
{
    public class ImportedProductSourceVM
    {
        public int Imported_Product_Source_ID { get; set; }
        public decimal Imported_Product_Buying_Cost { get; set; }
        public decimal Shipment_Cost { get; set; }
        public decimal Custom_Tax { get; set; }
        public decimal Transportation_Cost { get; set; }
        public decimal Storing_Cost { get; set; }
        public decimal Total_Cost { get; set; }
        public decimal Importers_WholeSale_Price { get; set; }
    }
}
