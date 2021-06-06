using System;
using System.Collections.Generic;
using System.Text;
using SuppliesPriceLister.ViewModel.supplies;

namespace SuppliesPriceLister.DLL.SuppliesHelper
{
    public interface IMegacorpHelper
    {
        /// <summary>
        /// Get Supplies Price List
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        IEnumerable<SuppliesPrice> GetSuppliesPriceList(string filePath);
    }
}
