using System;
using System.Collections.Generic;
using System.Text;

namespace SuppliesPriceLister.ViewModel.supplies
{
    public class SuppliesPrice
    {
        public string id { get; set; }

        public string itemName { get; set; }

        public double price { get; set; } // all in dolars and AUD
    }
}
