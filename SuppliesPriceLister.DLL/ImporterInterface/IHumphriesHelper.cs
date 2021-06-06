using SuppliesPriceLister.ViewModel.supplies;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuppliesPriceLister.DLL.SuppliesHelper
{
    public interface IHumphriesHelper
    {
        /// <summary>
        /// Get Supplies Price List
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        IEnumerable<SuppliesPrice> GetSuppliesPriceList(string filePath);
    }
}
