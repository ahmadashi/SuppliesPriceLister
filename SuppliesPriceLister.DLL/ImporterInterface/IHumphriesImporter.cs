using SuppliesPriceLister.ViewModel;
using System;
using System.Collections.Generic;

namespace SuppliesPriceLister.DLL.Importer
{
    public interface IHumphriesImporter
    {
        //public void ImportFromJson(string fileName);
        public List<HumphriesViewModel> ImportFromCSV(string fileName);



    }
}
