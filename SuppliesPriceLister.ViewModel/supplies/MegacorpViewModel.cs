using SuppliesPriceLister.ViewModel.supplies;
using System;
using System.Collections.Generic;

namespace SuppliesPriceLister.ViewModel
{
    public class MegacorpViewModel
    {
        public List<PartnersViewModel> partners { get; set; }        
    }

    public class PartnersViewModel
    {
        public string name { get; set; }

        public string partnerType { get; set; }

        public string partnerAddress { get; set; }

        public  List<SuppliesViewModel> supplies { get; set; }
        
    }

    public class SuppliesViewModel
    {
        public string id { get; set; }

        public string description { get; set; }

        public string priceInCents { get; set; } // American and in Cents not dolar

        public string providerId { get; set; }

        public string materialType { get; set; }
    }



}
