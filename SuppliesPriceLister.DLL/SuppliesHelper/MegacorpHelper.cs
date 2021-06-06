using SuppliesPriceLister.DLL.Importer;
using SuppliesPriceLister.ViewModel.supplies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SuppliesPriceLister.ViewModel;

namespace SuppliesPriceLister.DLL.SuppliesHelper
{
    public class MegacorpHelper : IMegacorpHelper
    {
        // to do import this DI
        private IMegacorpImporter _megacorpImporter;
        //to do read this from appsetings file
        private double audUsdExchangeRate = 0.7;
        public MegacorpHelper()
        {            
            _megacorpImporter = new MegacorpImporter();
        }       
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        IEnumerable<SuppliesPrice> IMegacorpHelper.GetSuppliesPriceList(string filePath)
        {
            var items = _megacorpImporter.ImportFromJson(filePath);
            List<SuppliesViewModel> megacorpSupplies = new List<SuppliesViewModel>();
            
            foreach (var p in items.partners)
            {
                megacorpSupplies.AddRange(p.supplies);
            }

            var suppliesPricelist = megacorpSupplies.Select(i => new SuppliesPrice { id = i.id, itemName = i.description, price = getPrice(i.priceInCents) });
            return suppliesPricelist;
        }

        /// <summary>
        /// get price as double, then convert it to dolar and then to AUS Currency  and if the price not vailed number , set it as 0
        /// </summary>
        /// <param name="priceInCents"></param>
        /// <returns></returns>
        private double getPrice(string priceInCents)
        {
            double price = 0;
            if (double.TryParse(priceInCents, out price))
            {
                price = (price / 100); // convert cent to dollar 
                price = (price / audUsdExchangeRate); // convert to AUD
                return price;
            }
            else
                return 0;
        }

        
    }
}
