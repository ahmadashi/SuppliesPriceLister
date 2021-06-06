using SuppliesPriceLister.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace SuppliesPriceLister.DLL.Importer
{
    public class HumphriesImporter : IHumphriesImporter
    {
        /// <summary>
        /// just import the file as it is
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IEnumerable<HumphriesViewModel> ImportFromCSV(string filePath)
        {   
            var reader = new StreamReader(File.OpenRead(filePath));
            List<HumphriesViewModel> items = new List<HumphriesViewModel>();
            int i = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if( i != 0 )
                {                    
                    HumphriesViewModel item = new HumphriesViewModel();
                    item.identifier = values[0];
                    item.desc = values[1];
                    item.unit = values[2];
                    item.cost = values[3];

                    items.Add(item);
                }
                i++;
            }

            return items;
        }
        
    }
}
