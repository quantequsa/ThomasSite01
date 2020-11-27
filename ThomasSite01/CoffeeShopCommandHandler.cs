using DataAccessSite07.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ThomasSite01
{
    internal class CoffeeShopCommandHandler : ICommandHandler  //so the CoffeeShopCommandHandler also can implement this interface ICommandHandler from ICommandHandler.cs class
    {
        ///the parameters are stored here in these private fields:
        private IEnumerable<CoffeeShop> coffeeShops;
        private string line;

        /// <summary>
        /// VS created Constructor that takes the input that that user has entered on the command line via Program.cs : CoffeeShop and line
        /// </summary>
        /// <param name="coffeeShops"></param>
        /// <param name="line"></param>
        public CoffeeShopCommandHandler(IEnumerable<CoffeeShop> coffeeShops, string line)
        {
            this.coffeeShops = coffeeShops;
            this.line = line;
        }

        /// <summary>
        /// make this HandleCommand public and paste the original content logic we commented out from the program.cs
        /// </summary>
        //delete internal void HandleCommand()

        public void HandleCommand()
        {
            ///Need to MOVE because it got to big: using two inputs coffeeShops and line from this program.cs and do ctrl. to add above:  using System.Linq;
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
            //throw new NotImplementedException();
        }
    }
}