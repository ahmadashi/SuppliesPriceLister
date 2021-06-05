using SuppliesPriceLister.DLL.Importer;
using System;
using Xunit;

namespace SuppliesPriceLister.DLL.Test
{
   

    public class ImportersTest
    {
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

            var items = _humphriesImporter.ImportFromCSV("humphries.csv");
            Assert.NotNull(items);

        }

        [Fact]
        public void ImportMegacorpFile()
        {
            var items = _megacorpImporter.ImportFromJson("megacorp.json");
            Assert.NotNull(items);
        }
    }
}
