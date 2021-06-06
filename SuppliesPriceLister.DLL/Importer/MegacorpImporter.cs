using Newtonsoft.Json;
using SuppliesPriceLister.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace SuppliesPriceLister.DLL.Importer
{
    public class MegacorpImporter : IMegacorpImporter
    {
        /// <summary>
        /// just import the file as it is
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public MegacorpViewModel ImportFromJson(string filePath)
        {
            List<MegacorpViewModel> xx = new List<MegacorpViewModel>();            
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<MegacorpViewModel>(json);
                return items;
            }
        }
    }
}
