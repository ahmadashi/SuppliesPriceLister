using SuppliesPriceLister.ViewModel;
using System;
using System.Collections.Generic;

namespace SuppliesPriceLister.DLL.Importer
{
    public interface IMegacorpImporter
    {
        /// <summary>
        /// Import provided Json
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public MegacorpViewModel ImportFromJson(string fileName);
        //public void ImportFromCSV(string fileName);



    }
}
