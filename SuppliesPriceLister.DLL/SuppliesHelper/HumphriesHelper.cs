using SuppliesPriceLister.DLL.Importer;
using SuppliesPriceLister.ViewModel.supplies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuppliesPriceLister.DLL.SuppliesHelper
{
    public class HumphriesHelper : IHumphriesHelper
    {
        // to do import this as DI
        private IHumphriesImporter _humphriesImporter;
        
        public HumphriesHelper()
        {
            _humphriesImporter = new HumphriesImporter();
            
        }

        /// <summary>
        /// Get Supplies Price List
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IEnumerable<SuppliesPrice> GetSuppliesPriceList(string filePath)
        {
            var items = _humphriesImporter.ImportFromCSV(filePath);
            var suppliesPricelist = items.Select(i => new SuppliesPrice { id = i.identifier, itemName = i.desc, price = getPrice(i.cost) });            
            return suppliesPricelist;
        }

        /// <summary>
        /// get price as double and if the price not vailed number , set as 0
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        private double getPrice(string cost)
        {
            double price = 0;
            if (double.TryParse(cost, out price))
                return price;
            else
                return 0;            
        }
       
    }
}
