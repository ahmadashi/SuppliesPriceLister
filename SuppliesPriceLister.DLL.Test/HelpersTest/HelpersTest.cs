using SuppliesPriceLister.DLL.SuppliesHelper;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace SuppliesPriceLister.DLL.Test
{
   // To do Add more test cases , like test the getprice method

    public class HelpersTest
    {        
        private IHumphriesHelper _humphriesHelper;
        private IMegacorpHelper _megacorpHelper;
        public HelpersTest()
        {
            _humphriesHelper = new HumphriesHelper();
            _megacorpHelper = new MegacorpHelper();
        }

        [Fact]
        public void GetHumphriesSuppliesPriceList()
        {
            string humphriesFilePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\SuppliesPriceLister\", "humphries.csv"));
            var items = _humphriesHelper.GetSuppliesPriceList(humphriesFilePath);
            Assert.NotNull(items);
            Assert.Equal(10, items.Count());

        }

        [Fact]
        public void GetMegacorpSuppliesPriceList()
        {
            string megacorpFilePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\SuppliesPriceLister\", "megacorp.json"));
            var items = _megacorpHelper.GetSuppliesPriceList(megacorpFilePath);
            Assert.NotNull(items);
            Assert.Equal(14, items.Count());
        }
    }
}
