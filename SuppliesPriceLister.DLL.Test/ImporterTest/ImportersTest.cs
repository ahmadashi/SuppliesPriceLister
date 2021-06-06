using SuppliesPriceLister.DLL.Importer;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace SuppliesPriceLister.DLL.Test
{
   

    public class ImportersTest
    {
        // To do Add more test cases 

        private IHumphriesImporter _humphriesImporter;
        private IMegacorpImporter _megacorpImporter;
        public ImportersTest()
        {
            _humphriesImporter = new HumphriesImporter();
            _megacorpImporter = new MegacorpImporter();
        }

        [Fact]
        public void ImportHumphriesFile()
        {
            string humphriesFilePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\SuppliesPriceLister\", "humphries.csv"));            
            var items = _humphriesImporter.ImportFromCSV(humphriesFilePath);
            
            Assert.NotNull(items);
            Assert.Equal(10, items.Count());

        }

        [Fact]
        public void ImportMegacorpFile()
        {            
            string megacorpFilePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\SuppliesPriceLister\", "megacorp.json"));
            var items = _megacorpImporter.ImportFromJson(megacorpFilePath);

            Assert.NotNull(items);
            Assert.Equal(2, items.partners.Count());

        }
    }
}
