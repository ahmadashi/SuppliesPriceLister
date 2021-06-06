using System;
using System.Collections.Generic;
using System.Text;
using SuppliesPriceLister.ViewModel.supplies;

namespace SuppliesPriceLister.DLL.SuppliesHelper
{
    public interface IMegacorpHelper
    {
        IEnumerable<SuppliesPrice> GetSuppliesPriceList(string filePath);
    }
}
