using Microsoft.Extensions.DependencyInjection;
using SuppliesPriceLister.DLL.SuppliesHelper;
using SuppliesPriceLister.ViewModel.supplies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SuppliesPriceLister
{
    class Program
    {
        static void Main(string[] args)
        {
            // to use MegacorpHelper and HumphriesHelper as DI, add them to serviceProvider
            var serviceProvider = configAppDI();

            var megacorpHelper = serviceProvider.GetService<IMegacorpHelper>();
            var humphriesHelper = serviceProvider.GetService<IHumphriesHelper>();
                       
            string humphriesFilePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\SuppliesPriceLister\", "humphries.csv"));
            string megacorpFilePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\SuppliesPriceLister\", "megacorp.json"));

            List<SuppliesPrice> suppliesPriceList = new List<SuppliesPrice>();

            suppliesPriceList.AddRange(humphriesHelper.GetSuppliesPriceList(humphriesFilePath));
            suppliesPriceList.AddRange(megacorpHelper.GetSuppliesPriceList(megacorpFilePath));

            var suppliesPriceListInDescOrder = suppliesPriceList.OrderByDescending(s => s.price);

            foreach (var item in suppliesPriceListInDescOrder)
            {
                Console.WriteLine("{0}, {1}, ${2}", item.id, item.itemName , item.price);
            }
            
        }

        private static ServiceProvider configAppDI()
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IMegacorpHelper, MegacorpHelper>()
            .AddSingleton<IHumphriesHelper, HumphriesHelper>()
            .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
