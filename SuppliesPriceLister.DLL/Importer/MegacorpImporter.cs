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
        /// <param name="fileName"></param>
        /// <returns></returns>
        public MegacorpViewModel ImportFromJson(string fileName)
        {
            List<MegacorpViewModel> xx = new List<MegacorpViewModel>();
            string filePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\SuppliesPriceLister\", fileName));
            using (StreamReader r = new StreamReader(filePath))
            {
                

                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<MegacorpViewModel>(json);
                return items;
            }
        }
    }
}
