using SuppliesPriceLister.ViewModel;
using System;
using System.Collections.Generic;

namespace SuppliesPriceLister.DLL.Importer
{
    public interface IHumphriesImporter
    {
        //public void ImportFromJson(string fileName);

        /// <summary>
        /// Import provided CSV
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IEnumerable<HumphriesViewModel> ImportFromCSV(string fileName);

    }
}
