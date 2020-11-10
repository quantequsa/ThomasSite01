using DataAccessSite07;
using System;
using System.Linq;
namespace ThomasSite01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ThomasSite01 - Shop Info Tool!");
            Console.WriteLine("Write 'help' to list available commands By Tim, " +
  "write 'quit' to exit application by Thomas");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
                else
                {
                    var foundCoffeeShops = coffeeShops
                    .Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
                    .ToList();
                    if (foundCoffeeShops.Count == 0)
                    {
                        Console.WriteLine($"> Command '{line}' not found");
                    }
                    else if (foundCoffeeShops.Count == 1)
                    {
                        var coffeeShop = foundCoffeeShops.Single();
                        Console.WriteLine($"> Location: {coffeeShop.Location}");
                        Console.WriteLine($"> Beans in stock: {coffeeShop.BeansInStockInKg} Kg");
                    }
                    else
                    {
                        Console.WriteLine($"> Multiple matching coffee shop command found:");
                        foreach (var coffeeType in foundCoffeeShops)
                        {
                            Console.WriteLine($"> {coffeeType.Location}");
                        }
                    }

                }

            }
        }
    }
}
