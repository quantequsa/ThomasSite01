using DataAccessSite07;
using System;

namespace ThomasSite01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ThomasSite01 - Shop Info Tool!");
            Console.WriteLine("Write 'help' to list available commands");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
            }
        }
    }
}
