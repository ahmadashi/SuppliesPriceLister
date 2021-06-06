using SuppliesPriceLister.ViewModel.supplies;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuppliesPriceLister.DLL.SuppliesHelper
{
    public interface IHumphriesHelper
    {
        IEnumerable<SuppliesPrice> GetSuppliesPriceList(string filePath);
    }
}
