using SuppliesPriceLister.ViewModel;
using System;
using System.Collections.Generic;

namespace SuppliesPriceLister.DLL.Importer
{
    public interface IMegacorpImporter
    {
        public MegacorpViewModel ImportFromJson(string fileName);
        //public void ImportFromCSV(string fileName);



    }
}
